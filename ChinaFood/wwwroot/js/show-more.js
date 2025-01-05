document.addEventListener("DOMContentLoaded", function () {
    const showMoreButtons = document.querySelectorAll(".show-more");

    showMoreButtons.forEach(button => {
        button.addEventListener("click", function () {
            // Находим родительский блок для текущей кнопки 
            const parentBlock = button.closest(".article");
            if (!parentBlock) return;

            // Находим скрытые и видимые элементы внутри родительского блока
            const hiddenItems = parentBlock.querySelectorAll("#dishes-container.hidden");
            const visibleItems = parentBlock.querySelectorAll("#dishes-container.visible");

            if (button.textContent.trim() === window.localization.showMore) {
                // Показать скрытые блоки
                hiddenItems.forEach(item => {
                    item.classList.remove("hidden");
                    item.classList.add("visible");
                });
                button.textContent = window.localization.showLess;
            } else {
                // Скрыть показанные ранее блоки
                visibleItems.forEach((item, index) => {
                    if (index > 0) { // Не трогать первый блок
                        item.classList.remove("visible");
                        item.classList.add("hidden");
                    }
                });
                button.textContent = window.localization.showMore;
            }
        });
    });
});