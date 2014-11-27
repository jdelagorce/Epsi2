$(function () {
    $('#alertePwd').hide();
    if ($('#initialPwd').val() != $('#confirmPwd').val()) {
        $('#alertePwd').show('100');

    } else {
        $('#alertePwd').hide();

    }
});