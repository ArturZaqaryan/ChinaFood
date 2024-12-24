$(document).ready(function () {
    $('#js-carousel-review, #js-carousel-polaroid-1, #js-carousel-city-1, #js-carousel-hotel-1').owlCarousel({
        items: 1,
    });

    $('#js-carousel-polaroid-5').owlCarousel({
        items: 5,
    });

    $('#js-carousel-polaroid-4, #js-carousel-city-4').owlCarousel({
        items: 4,
    });

    $('#js-carousel-polaroid-3, #js-carousel-hotel-3, #js-carousel-city-3').owlCarousel({
        items: 3,
    });

    $('#js-carousel-polaroid-2, #js-carousel-hotel-2, #js-carousel-city-2').owlCarousel({
        items: 2,
    });
});

document.addEventListener("DOMContentLoaded", function () {
    const hint = document.querySelector('.carousel-hint');
    const carousel = document.querySelector('#js-carousel-polaroid-5');

    if (carousel && hint) {
        carousel.addEventListener('mousedown', () => hint.style.display = 'none');
        carousel.addEventListener('touchstart', () => hint.style.display = 'none');
    }
});