$(document).ready(function () {
    MudarOrdenacao();
    MudarImagemPrincipalProduto();
    MudarQuantidadeProdutoCarrinho();
});

function MudarQuantidadeProdutoCarrinho() {
    $("#order .btn-car").click(function () {
        //var pai = $(this).parent().parent();
        if ($(this).hasClass("diminuir")) {
            LogicaMudarQuantidadeProdutoUnitarioCarrinho("diminuir", $(this));

            
        }
        if ($(this).hasClass("aumentar")) {
            LogicaMudarQuantidadeProdutoUnitarioCarrinho("aumentar", $(this));


        }
        
    });
}

function LogicaMudarQuantidadeProdutoUnitarioCarrinho(operacao, botao) {
    var pai = botao.parent().parent();
    var produtoId = pai.find(".inputProdutoId").val();
    var quantidadeEstoque = pai.find(".inputQuantidadeEstoque").val();
    var valorUnitario = pai.find(".inputValorUnitario").val();

    var campoQuantitadeProdutoCarrinho = pai.find("inputQuantidadeProdutoCarrinho");
    var quantitadeProdutoCarrinho = parseInt(campoQuantitadeProdutoCarrinho.val());

    if (operacao == "aumentar") {
        quantitadeProdutoCarrinho++;

        campoQuantitadeProdutoCarrinho.val(quantitadeProdutoCarrinho);
    } else if (operacao == "diminuir") {
        quantitadeProdutoCarrinho--;
    }
}

function MudarImagemPrincipalProduto() {
    $(".img-small-wrap").click(function () {
        var caminho = $(this).attr("src");
        $(".img-big-wrap img").attr("src", caminho);

        $(".img-big-wrap a").attr("href", caminho);
    });
}

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