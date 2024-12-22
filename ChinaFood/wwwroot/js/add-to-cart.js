$(document).ready(function () {
    $('.add-to-cart-form').submit(function (event) {
        event.preventDefault();
        var $form = $(this);
        var formData = $form.serialize();
        var url = $form.data('url'); // Чтение URL из data-url

        $.ajax({
            url: url,
            type: 'POST',
            data: formData,
            success: function (response) {
                if (response.success) {
                    $form.next('.cart-status').text(response.message);
                    updateCartCountFromServer();
                } else {
                    $form.next('.cart-status').text('Failed to add product to cart.');
                }
            },
            error: function () {
                $form.next('.cart-status').text('An error occurred while adding to the cart.');
            }
        });
    });
});