$(document).ready(function () {

});


function EnviarPedido() {

    const phone = '5513981711225';
    let pedido = 'oii'
    text = window.encodeURIComponent(text);
    window.open('https://api.whatsapp.com/send?phone=' + phone + '&text=' + pedido +'')
}

