$(document).ready(function () {
    // ������� ����� ���������� ������
    $('#checkout-button').click(function () {
        $('.checkout-form').show();
    });

    // �������� ����� ���������� ������
    $('#checkout-form').submit(function (event) {
        event.preventDefault();

        const formData = $(this).serialize();
        $.ajax({
            url: '/Cart/Checkout',
            type: 'POST',
            data: formData,
            success: function (response) {
                if (response.success) {
                    alert(response.message);
                    location.reload();
                } else {
                    alert(response.message);
                }
            }
        });
    });
});