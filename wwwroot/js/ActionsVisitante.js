$(document).ready(function () {
    MudarOrdenacao();
});

function MudarOrdenacao() {
    $("#ordenacao").change(function () {
        var pagina = 1;
        var pesquisa = "";
        var ordenacao = $(this).val();

        var queryString = new URLSearchParams(window.location.search);

        if (queryString.has("pagina")) {
            pagina = queryString.get("pagina");
        }
        if (queryString.has("pesquisa")) {
            pesquisa = queryString.get("pesquisa");
        }

        // /Index?pagina{}&pesquisa={}&ordenacao={}
        var url = window.location.protocol + "//" + window.location.host + window.location.pathname;
        var urlParametros = url + "?pagina=" + pagina + "&pesquisa=" + pesquisa + "&ordenacao=" + ordenacao;

        window.location.href = urlParametros;
    });
};