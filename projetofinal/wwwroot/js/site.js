// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// Seleciona todas as imagens com a classe "zoomable"
const zoomableImages = document.querySelectorAll('.zoomable');
const modal = document.getElementById('zoomModal');
const modalImage = document.getElementById('modalImage');

// Adiciona evento de clique a todas as imagens
zoomableImages.forEach(image => {
    image.addEventListener('click', () => {
        modalImage.src = image.src; // Define a imagem no modal
        modal.style.display = 'flex'; // Mostra o modal
    });
});

// Fecha o modal ao clicar fora da imagem
modal.addEventListener('click', (e) => {
    if (e.target !== modalImage) {
        modal.style.display = 'none';
    }
});

const track = document.querySelector('.carousel-track');
const slides = Array.from(track.children);
const nextButton = document.getElementById('next');
const prevButton = document.getElementById('prev');

let currentSlideIndex = 0;

function updateCarousel() {
    const slideWidth = slides[0].getBoundingClientRect().width;
    track.style.transform = `translateX(-${currentSlideIndex * slideWidth}px)`;
}

nextButton.addEventListener('click', () => {
    currentSlideIndex = (currentSlideIndex + 1) % slides.length;
    updateCarousel();
});

prevButton.addEventListener('click', () => {
    currentSlideIndex = (currentSlideIndex - 1 + slides.length) % slides.length;
    updateCarousel();
});

window.addEventListener('resize', updateCarousel);