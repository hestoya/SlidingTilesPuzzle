window.launchConfetti = function ()
{
    var duration = 5 * 1000;
    var animationEnd = Date.now() + duration;
    var defaults = { startVelocity: 30, spread: 360, ticks: 60, zIndex: 999 };

    var interval = setInterval(function () {
        var timeLeft = animationEnd - Date.now();
        if (timeLeft <= 0) return clearInterval(interval);

        var particleCount = 50 * (timeLeft / duration);
        confetti(Object.assign({}, defaults, { particleCount, origin: { x: Math.random(), y: Math.random() - 0.2 } }));
    }, 250);
}

window.playWinSound = () => {
    var audio = new Audio('assets/sounds/win.mp3');
    audio.play().catch(e => console.error('Audio play error:', e));
};

window.playClickButtonSound = () => {
    var audio = new Audio('assets/sounds/click.mp3');
    audio.play().catch(e => console.error('Audio play error:', e));
};

let gameLoopAudio = null;

window.playGameLoopSound = () => {
    if (!gameLoopAudio) {
        gameLoopAudio = new Audio('assets/sounds/game-loop2.mp3');
        gameLoopAudio.loop = true; 
    }
    gameLoopAudio.play().catch(e => console.error('Audio play error:', e));
};

window.stopGameLoopSound = () => {
    if (gameLoopAudio) {
        gameLoopAudio.pause();
        gameLoopAudio.currentTime = 0;
    }
};

window.playTileMoveSound = () => {
    var audio = new Audio('assets/sounds/swipe.mp3');
    audio.play().catch(e => console.error('Audio play error:', e));
};

window.playStartButtonSound = () => {
    var audio = new Audio('assets/sounds/start.mp3');
    audio.play().catch(e => console.error('Audio play error:', e));
};

let homeLoopAudio = null;

window.playHomeLoopSound = () => {
    if (!homeLoopAudio) {
        homeLoopAudio = new Audio('assets/sounds/game-loop1.mp3');
        homeLoopAudio.loop = true;
    }

    homeLoopAudio.play().catch(e => console.error('Audio play error:', e));
};

window.stopHomeLoopSound = () => {
    if (homeLoopAudio) {
        homeLoopAudio.pause();
        homeLoopAudio.currentTime = 0;
    }
};
