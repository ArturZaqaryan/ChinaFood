$(document).ready(function () {
    $('#dishType').change(function () {
        var selectedDishType = $(this).val();
        var subCategorySelect = $('#subCategoryId');

        if (selectedDishType) {
            $.ajax({
                url: '/Search/GetSubCategoriesByDishType', // Путь к методу контроллера
                type: 'GET',
                data: { dishType: selectedDishType },
                success: function (response) {
                    subCategorySelect.empty(); // Очистить текущие опции
                    subCategorySelect.append('<option value="">Select SubCategory</option>'); // Добавить опцию по умолчанию

                    // Добавить новые опции из ответа
                    response.forEach(function (subCategory) {
                        subCategorySelect.append(
                            `<option value="${subCategory.id}">${subCategory.title}</option>`
                        );
                    });
                },
                error: function () {
                    console.error('Failed to load subcategories.');
                }
            });
        } else {
            // Очистить подкатегории, если ничего не выбрано
            subCategorySelect.empty();
            subCategorySelect.append('<option value="">Select SubCategory</option>');
        }
    });
});
