var htmlOrigin = '';

(function () {
    var today = new Date();
    var dd = today.getDate();
    var mm = today.getMonth() + 1;
    var yyyy = today.getFullYear();

    today = addZero(mm) + '/' + addZero(dd) + '/' + yyyy;
    document.getElementById('day').innerHTML = today;
    SetHour();
    setInterval(SetHour, 1000);


})();

function SetHour() {
    var d = new Date();
    var h = addZero(d.getHours());
    var m = addZero(d.getMinutes());
    var s = addZero(d.getSeconds());
    document.getElementById('hour').innerHTML = h + ":" + m + ":" + s;
}

function addZero(i) {
    if (i < 10) {
        i = "0" + i;
    }
    return i;
}

function mobileWindow(conteudo)
{
    if ($(window).width() < 724) {
        htmlOrigin = $('#conteudo').html();

        var html = '<nav class="nav-blue"> ' +
                    '    <div class="container"> ' +
                    '        <div class="navbar-header"> ' +
                    '            <header class="main-header" style="margin-top: 10px !important;"> ' +
                    '                <a class="logo" onclick="voltar();"> ' +
                    '                   <h4>&larr; Voltar</h4> ' +
                    '                </a> ' +
                    '            </header> ' +
                    '        </div> ' +
                    '    </div> ' +
                    '</nav>' +
                    '<div class="col-lg-6">' + conteudo.innerHTML.replace('s-table', '') + '</div>';
        $('#conteudo').html(html);
    }
}

function voltar()
{
    $('#conteudo').html(htmlOrigin);
}