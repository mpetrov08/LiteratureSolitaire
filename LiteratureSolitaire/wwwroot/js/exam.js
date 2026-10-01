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