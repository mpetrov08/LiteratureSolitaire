document.addEventListener("click", async (e) => {
    const option = e.target.closest(".answer-option");
    if (!option) return;

    const questionEl = option.closest(".exam-question");
    if (!questionEl) return;

    const radio = option.querySelector('input[type="radio"]');
    if (radio.disabled) return;

    const questionId = parseInt(questionEl.dataset.questionId);
    const answerId = parseInt(option.dataset.answerId);

    questionEl.querySelectorAll(".answer-option").forEach(o => o.classList.remove("selected"));
    option.classList.add("selected");
    radio.checked = true;

    try {
        const response = await fetch("/Exam/SelectAnswer", {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify({ questionId, answerId })
        });

        if (!response.ok) {
            console.error("Неуспешно запазване на отговора");
        }
    } catch (err) {
        console.error("SelectAnswer failed", err);
    }
});

document.addEventListener("DOMContentLoaded", () => {
    const result = document.querySelector(".result-box");

    if (result && result.dataset.allCorrect === "true") {
        launchConfetti();
    }
});

const textTimers = new Map();

async function saveTextAnswer(textarea) {
    try {
        await fetch("/Exam/SaveTextAnswer", {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify({
                questionId: parseInt(textarea.dataset.questionId),
                text: textarea.value
            })
        });
    } catch (err) {
        console.error("SaveTextAnswer failed", err);
    }
}

document.addEventListener("input", e => {
    const textarea = e.target.closest(".text-answer");
    if (!textarea || textarea.readOnly) return;

    clearTimeout(textTimers.get(textarea));
    textTimers.set(textarea, setTimeout(() => saveTextAnswer(textarea), 400));
});

document.addEventListener("submit", async e => {
    if (!e.target.matches('form[action*="Validate"]')) return;

    e.preventDefault();

    const textareas = [...document.querySelectorAll(".text-answer")]
        .filter(t => !t.readOnly);

    textareas.forEach(t => clearTimeout(textTimers.get(t)));
    await Promise.all(textareas.map(saveTextAnswer));

    e.target.submit();
});