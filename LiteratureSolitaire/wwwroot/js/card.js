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
            document.getElementById("drawPile")
                .insertAdjacentHTML("beforeend", html.trim());

            adjustFontSizeForOverflow(); 
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

window.addEventListener('load', adjustFontSizeForOverflow);

function allowDrop(ev) {
    ev.preventDefault();
    ev.currentTarget?.classList.add("drag-over");
}

document.querySelectorAll(".drop-slot").forEach(slot => {
    slot.addEventListener("dragleave", () => {
        slot.classList.remove("drag-over");
    });
});

function dragStart(ev) {
    const card = ev.currentTarget;
    if (!card || !card.dataset.cardId) return;

    ev.dataTransfer.effectAllowed = "move";
    ev.dataTransfer.setData("text/plain", card.dataset.cardId);

    ev.dataTransfer.setDragImage(card, 60, 80);

    card.classList.add("dragging");
}

function dragEnd(ev) {
    const card = ev.currentTarget;
    if (!card) return;

    card.classList.remove("dragging");
}

async function dropCard(ev) {
    ev.preventDefault();

    const slot = ev.target.closest(".drop-slot");
    if (!slot) return;

    const cardId = ev.dataTransfer.getData("text/plain");
    if (!cardId) return;

    const cardElem = document.querySelector(
        `.card[data-card-id="${cardId}"]`
    );
    if (!cardElem) return;

    const response = await fetch("/Deck/PlaceCard", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
            cardId: cardId,
            section: parseInt(slot.dataset.section),
            position: parseInt(slot.dataset.position)
        })
    });

    if (!response.ok) {
        showToast("Грешка при поставяне на картата", "error");
        return;
    }

    const existing = slot.querySelector(".card");
    if (existing) {
        const origin = cardElem.parentElement;
        origin.appendChild(existing);
    }

    slot.appendChild(cardElem);
    cardElem.classList.remove("dragging");
    slot.classList.remove("drag-over");
}

async function dropToDrawPile(ev) {
    ev.preventDefault();

    const cardId = ev.dataTransfer.getData("text/plain");
    if (!cardId) return;

    const cardElem = document.querySelector(
        `.card[data-card-id="${cardId}"]`
    );
    if (!cardElem) return;

    const pile = document.getElementById("drawPile");

    const response = await fetch("/Deck/ReturnToDrawPile", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ cardId })
    });

    if (!response.ok) {
        showToast("Не може да имате повече от 5 карти", "warning");
        return;
    }

    pile.appendChild(cardElem);
}

function saveCardPosition(cardId, section, position) {
    fetch("/Deck/PlaceCard", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
            cardId: cardId,
            section: parseInt(section),
            position: parseInt(position)
        })
    }).catch(() => { });
}

window.addEventListener("mouseup", () => {
    document
        .querySelectorAll(".card.dragging")
        .forEach(c => c.classList.remove("dragging"));
});

function showToast(message, type = "info") {
    const container = document.getElementById("toast-container");
    if (!container) {
        console.error("Toast container missing!");
        return;
    }

    const toast = document.createElement("div");

    toast.classList.add("app-toast", type);
    toast.textContent = message;

    container.appendChild(toast);

    setTimeout(() => {
        toast.remove();
    }, 3500);
}