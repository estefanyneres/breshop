$(document).ready(function () {
    $('#footer-layout').css('display', 'none');
    $('#sec-816c').css('display', 'none');
    $('.u-link').css('display', 'none');
    $('.u-backlink u-clearfix u-grey-80').css('display', 'none');
});




$('.message a').click(function () {
    $('form').animate({ height: "toggle", opacity: "toggle" }, "slow");
});
