document.addEventListener("DOMContentLoaded", function () {
    const showMoreButton = document.getElementById("show-more");
    if (showMoreButton) {
        showMoreButton.addEventListener("click", function () {
            const hiddenItems = document.querySelectorAll("#dishes-container.hidden");
            const visibleItems = document.querySelectorAll("#dishes-container.visible");

            if (showMoreButton.textContent.trim() === "Показать больше") {
                // Показать скрытые блоки
                hiddenItems.forEach(item => {
                    item.classList.remove("hidden");
                    item.classList.add("visible");
                });
                showMoreButton.textContent = "Показать меньше";
            } else {
                // Скрыть показанные ранее блоки
                visibleItems.forEach((item, index) => {
                    if (index > 0) { // Не трогать первый блок
                        item.classList.remove("visible");
                        item.classList.add("hidden");
                    }
                });
                showMoreButton.textContent = "Показать больше";
            }
        });
    }
});