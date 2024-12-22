// Глобальное определение функции
function updateCartCountFromServer() {
    $.ajax({
        url: '/Cart/GetCartCount',
        type: 'GET',
        success: function (response) {
            if (response.itemCount !== undefined) {
                $('.cart-count').text(response.itemCount);
            }
        },
        error: function () {
            console.error('Failed to load cart count.');
        }
    });
}

$(document).ready(function () {
    // Вызов функции при загрузке страницы
    updateCartCountFromServer();
});