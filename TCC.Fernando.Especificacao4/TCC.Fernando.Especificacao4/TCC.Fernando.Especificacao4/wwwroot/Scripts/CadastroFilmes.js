function chamadaAjax(url, parametros, funcaoSucesso) {
    $.ajax({
        type: "POST",
        url: url,
        data: parametros,
        success: funcaoSucesso
    });
}

function filtrar() {
    var TituloFilme = $('#idTituloFilme').val();
    var Genero = $('#idGenero').val();
    var Estudio = $('#idEstudio').val();
    var Ano = $('#idAno').val();

    var redirectLink = "https://localhost:44342/Home/Index?TituloFilme=" + TituloFilme + "&&Genero=" + Genero + "&&Estudio=" + Estudio + "&&Ano=" + Ano;

    window.location.replace(redirectLink);
}

function salvar() {
    var TituloFilme = $('#idTituloFilme').val();
    var Genero = $('#idGenero').val();
    var Estudio = $('#idEstudio').val();
    var Ano = $('#idAno').val();

    var parametro =
    {
        tituloFilme: TituloFilme,
        genero: Genero,
        estudio: Estudio,
        ano: Ano
    };

    chamadaAjax(urlSalvar, parametro, filtrar);
}