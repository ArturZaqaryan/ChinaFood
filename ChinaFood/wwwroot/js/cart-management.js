$(document).ready(function () {
    // Загрузка товаров корзины
    loadCartItems();

    function loadCartItems() {
        $.ajax({
            url: '/Cart/GetCartItems',
            type: 'GET',
            success: function (response) {
                if (response.success) {
                    const items = response.items;
                    const cartBody = $('table tbody');
                    cartBody.empty();

                    items.forEach(item => {
                        const rowHtml = `
                            <tr id="cart-item-${item.productId}">
                                <td>${item.title}</td>
                                <td class="item-price">${item.price.toFixed(2)}</td>
                                <td>
                                    <input type="number" class="item-quantity" data-product-id="${item.productId}" value="${item.quantity}" min="1">
                                </td>
                                <td class="item-total">${item.total.toFixed(2)}</td>
                                <td>
                                    <button class="remove-item" data-product-id="${item.productId}">Remove</button>
                                </td>
                            </tr>`;
                        cartBody.append(rowHtml);
                    });

                    $('#cart-total').text(response.cartTotal.toFixed(2));
                } else {
                    alert('Failed to load cart items.');
                }
            },
            error: function () {
                alert('Error occurred while loading cart items.');
            }
        });
    }

    // Удаление товара
    $(document).on('click', '.remove-item', function () {
        const productId = $(this).data('product-id');

        $.ajax({
            url: '/Cart/RemoveCartItem',
            type: 'POST',
            data: { productId },
            success: function (response) {
                if (response.success) {
                    $(`#cart-item-${productId}`).remove();
                    updateCartTotal(response.cartTotal);
                }
            }
        });
    });

    // Обновление количества товара
    $(document).on('change', '.item-quantity', function () {
        const productId = $(this).data('product-id');
        const quantity = parseInt($(this).val(), 10);

        $.ajax({
            url: '/Cart/UpdateCartItem',
            type: 'POST',
            data: { productId, quantity },
            success: function (response) {
                if (response.success) {
                    const row = $(`#cart-item-${productId}`);
                    const price = parseFloat(row.find('.item-price').text());
                    row.find('.item-total').text((price * quantity).toFixed(2));
                    updateCartTotal(response.cartTotal);
                }
            }
        });
    });

    function updateCartTotal(total) {
        $('#cart-total').text(total.toFixed(2));
    }
});
