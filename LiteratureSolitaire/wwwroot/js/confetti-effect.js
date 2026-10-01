function launchConfetti() {
    if (typeof confetti !== "function") return;

    const end = Date.now() + 3000;
    (function frame() {
        confetti({ particleCount: 6, angle: 60, spread: 55, origin: { x: 0 } });
        confetti({ particleCount: 6, angle: 120, spread: 55, origin: { x: 1 } });
        confetti({ particleCount: 8, angle: 90, spread: 90, origin: { x: 0.5 } });

        if (Date.now() < end) requestAnimationFrame(frame);
    })();
}