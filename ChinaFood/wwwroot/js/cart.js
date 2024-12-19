//document.querySelectorAll('.add-to-cart').forEach(button => {
//    button.addEventListener('click', function (e) {
//        e.preventDefault();

//        const productId = this.dataset.productId;
//        const quantity = this.dataset.quantity || 1;

//        fetch('/Cart/AddToCart', {
//            method: 'POST',
//            headers: {
//                'Content-Type': 'application/json'
//            },
//            body: JSON.stringify({ productId, title: '', price: 0, quantity })
//        })
//            .then(response => response.json())
//            .then(data => {
//                if (data.success) {
//                    const cartCountElement = document.querySelector('.cart-count');
//                    const newCount = parseInt(cartCountElement.textContent) + parseInt(quantity);
//                    cartCountElement.textContent = newCount;
//                } else {
//                    alert(data.message);
//                }
//            })
//            .catch(error => console.error('Error:', error));
//    });
//});