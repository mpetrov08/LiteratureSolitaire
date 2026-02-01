let drawing = false;

async function drawCard() {
    if (drawing) return;
    drawing = true;

    try {
        const response = await fetch("/Deck/DrawCardAjax", { method: "POST" });
        const html = await response.text();

        if (html === "LIMIT") {
            showToast("Може да изтеглите максимум 5 карти!", "warning");
            return;
        }

        if (html === "EMPTY") {
            showToast("Тестето е празно. Няма повече карти.", "info");
            return;
        }

        if (html.trim() !== "") {
            const drawPile = document.getElementById("drawPile");
            drawPile.insertAdjacentHTML("beforeend", html.trim());

            drawPile
                .querySelectorAll(".card")
                .forEach(c => c._origin ??= c.parentElement);

            adjustFontSizeForOverflow();
            adjustCardAlignment();
        }
    } catch (e) {
        console.error("Draw failed", e);
    } finally {
        drawing = false;
    }
}

function adjustFontSizeForOverflow() {
    document.querySelectorAll('.card-content').forEach(el => {
        const baseFont = el.closest('.card')?.dataset.type === 'Character'
            ? 12.5
            : 14;

        let fontSize = baseFont;
        el.style.fontSize = fontSize + 'px';

        while (
            (el.scrollHeight > el.clientHeight || el.scrollWidth > el.clientWidth) &&
            fontSize > 11
        ) {
            fontSize -= 0.5;
            el.style.fontSize = fontSize + 'px';
        }
    });
}

function adjustCardAlignment() {
    document.querySelectorAll('.card-content').forEach(el => {
        const card = el.closest('.card');

        if (el.scrollHeight > el.clientHeight + 1) {
            card.classList.add('has-overflow');
        } else {
            card.classList.remove('has-overflow');
        }
    });
}

window.addEventListener('load', adjustFontSizeForOverflow);

let activeCard = null;

//document.addEventListener("pointerdown", onPointerDown);
document.addEventListener("pointerdown", e => {
    const card = e.target.closest(".card");
    if (!card) return;

    onPointerDown(e);
});
document.addEventListener("pointermove", onPointerMove);
document.addEventListener("pointerup", onPointerUp);
document.addEventListener("pointercancel", cancelDrag);

function onPointerDown(e) {
    if (
        e.target.closest("button") ||
        e.target.closest("form") ||
        e.target.closest("a")
    ) {
        e.stopPropagation();
        return;
    }

    const card = e.target.closest(".card");
    if (!card) return;

    activeCard = card;
    card._origin ??= card.parentElement;

    const rect = card.getBoundingClientRect();
    card.dataset.offsetX = e.clientX - rect.left;
    card.dataset.offsetY = e.clientY - rect.top;

    card.classList.add("dragging");
    card.setPointerCapture(e.pointerId);

    card.style.left = rect.left + "px";
    card.style.top = rect.top + "px";
}

function onPointerMove(e) {
    if (!activeCard) return;

    const cardRect = activeCard.getBoundingClientRect();

    const rawX = e.clientX - activeCard.dataset.offsetX;
    const rawY = e.clientY - activeCard.dataset.offsetY;

    const maxX = window.innerWidth - cardRect.width;
    const maxY = window.innerHeight - cardRect.height;

    const x = clamp(rawX, 0, maxX);
    const y = clamp(rawY, 0, maxY);

    activeCard.style.left = x + "px";
    activeCard.style.top = y + "px";

    handleAutoScroll(e.clientY);
    highlightSlot(e.clientX, e.clientY);
}

function onPointerUp(e) {
    if (!activeCard) return;

    activeCard.releasePointerCapture(e.pointerId);

    const target = document.elementFromPoint(e.clientX, e.clientY);
    const slot = target?.closest(".drop-slot");
    const drawPile = target?.closest("#drawPile");

    if (slot) {
        placeCardToSlot(activeCard, slot);
    }
    else if (drawPile) {
        returnToDrawPile(activeCard);
    }
    else {
        resetCard(activeCard);
    }

    stopAutoScroll();
    clearHighlights();
    activeCard = null;
}

function cancelDrag() {
    if (!activeCard) return;

    stopAutoScroll();
    resetCard(activeCard);
    activeCard = null;
}

const scrollContainer = document.getElementById("page-scroll");

const AUTO_SCROLL_MARGIN = 100; 
const AUTO_SCROLL_MIN_SPEED = 4;
const AUTO_SCROLL_MAX_SPEED = 26;

let autoScrollDir = 0;
let autoScrollSpeed = 0;
let autoScrollRAF = null;

function startAutoScroll() {
    if (autoScrollRAF) return;

    const step = () => {
        if (!autoScrollDir) {
            autoScrollRAF = null;
            return;
        }

        scrollContainer.scrollTop += autoScrollDir * autoScrollSpeed;
        autoScrollRAF = requestAnimationFrame(step);
    };

    autoScrollRAF = requestAnimationFrame(step);
}

function clamp(value, min, max) {
    return Math.max(min, Math.min(max, value));
}

function easeOutQuad(t) {
    return t * (2 - t);
}

function handleAutoScroll(pointerY) {
    const rect = scrollContainer.getBoundingClientRect();

    if (pointerY < rect.top + AUTO_SCROLL_MARGIN) {
        const distance = Math.max(pointerY - rect.top, 0);
        const ratio = 1 - distance / AUTO_SCROLL_MARGIN;

        autoScrollDir = -1;
        autoScrollSpeed =
            AUTO_SCROLL_MIN_SPEED +
            (AUTO_SCROLL_MAX_SPEED - AUTO_SCROLL_MIN_SPEED) * easeOutQuad(ratio);

        startAutoScroll();
        return;
    }

    if (pointerY > rect.bottom - AUTO_SCROLL_MARGIN) {
        const distance = Math.max(rect.bottom - pointerY, 0);
        const ratio = 1 - distance / AUTO_SCROLL_MARGIN;

        autoScrollDir = 1;
        autoScrollSpeed =
            AUTO_SCROLL_MIN_SPEED +
            (AUTO_SCROLL_MAX_SPEED - AUTO_SCROLL_MIN_SPEED) * easeOutQuad(ratio);

        startAutoScroll();
        return;
    }

    stopAutoScroll();
}

function stopAutoScroll() {
    autoScrollDir = 0;
    autoScrollSpeed = 0;
}

async function placeCardToSlot(card, slot) {
    const response = await fetch("/Deck/PlaceCard", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
            cardId: card.dataset.cardId,
            section: parseInt(slot.dataset.section),
            position: parseInt(slot.dataset.position)
        })
    });

    if (!response.ok) {
        showToast("Грешка при поставяне на картата", "error");
        resetCard(card);
        return;
    }

    const existing = slot.querySelector(".card");
    if (existing) {
        card._origin.appendChild(existing);
    }

    slot.appendChild(card);
    cleanupCard(card);
}

async function returnToDrawPile(card) {
    const response = await fetch("/Deck/ReturnToDrawPile", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ cardId: card.dataset.cardId })
    });

    if (!response.ok) {
        showToast("Не може да имате повече от 5 карти", "warning");
        resetCard(card);
        return;
    }

    document.getElementById("drawPile").appendChild(card);
    cleanupCard(card);
}

function resetCard(card) {
    cleanupCard(card);
    card._origin.appendChild(card);
}

function cleanupCard(card) {
    card.classList.remove("dragging");
    card.style.left = "";
    card.style.top = "";
}

function highlightSlot(x, y) {
    clearHighlights();
    const el = document.elementFromPoint(x, y);
    const slot = el?.closest(".drop-slot");
    if (slot) slot.classList.add("drag-over");
}

function clearHighlights() {
    document
        .querySelectorAll(".drop-slot.drag-over")
        .forEach(s => s.classList.remove("drag-over"));
}

function showToast(message, type = "info") {
    const container = document.getElementById("toast-container");
    if (!container) return;

    const toast = document.createElement("div");
    toast.classList.add("app-toast", type);
    toast.textContent = message;

    container.appendChild(toast);

    setTimeout(() => toast.remove(), 3500);
}

function launchConfetti() {
    const end = Date.now() + 3000;
    (function frame() {
        confetti({ particleCount: 6, angle: 60, spread: 55, origin: { x: 0 } });
        confetti({ particleCount: 6, angle: 120, spread: 55, origin: { x: 1 } });
        confetti({ particleCount: 8, angle: 90, spread: 90, origin: { x: 0.5 } });

        if (Date.now() < end) requestAnimationFrame(frame);
    })();
}

document.addEventListener("click", e => {
    if (window.innerWidth > 600) return;

    const card = e.target.closest(".card");
    if (!card) return;

    if (card.dataset.type === "Character") {
        card.classList.toggle("expanded");
    }
});