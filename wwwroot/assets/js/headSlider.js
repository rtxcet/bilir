const messages = [
    "🚀 Bilir Teknoloji – Yazılımda güvenin adresi! | Kampanyalarımız başladı!",
    "💻 Bilir 2 Teknoloji – Dijital çözümlerle geleceği yazıyoruz!",
    "🌐 Web ve yazılım çözümlerinde lideriz!"
];

let index = 0;
const marquee = document.getElementById("bannerText");

// Animasyon her tur tamamlandığında yazıyı değiştir
marquee.addEventListener("animationiteration", () => {
    index = (index + 1) % messages.length;
    marquee.textContent = messages[index];
});

// Fare üstüne gelince durdur
marquee.addEventListener("mouseenter", () => {
    marquee.style.animationPlayState = "paused";
});

// Fare ayrılınca devam et
marquee.addEventListener("mouseleave", () => {
    marquee.style.animationPlayState = "running";
});