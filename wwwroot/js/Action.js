$(document).ready(function () {
    $(".btn-outline-danger").click(function (e) {
        var resultado = confirm("Tem certeza que deseja excluir?");

        //swal("Good job!", "You clicked the button!", "success");

        if (resultado == false) {
            e.preventDefault();
        }
    });
    $(".inativar").click(function (e) {
        var resultado = confirm("Tem certeza que deseja inativar?");

        //swal("Good job!", "You clicked the button!", "success");

        if (resultado == false) {
            e.preventDefault();
        }
    });

    AjaxUploadImagemProduto();

    $('.dinheiro').mask('000.000.000.000.000,00', { reverse: true });
});

function AjaxUploadImagemProduto() {
    $(".img-upload").click(function () {
        $(this).parent().parent().find(".input-file").click();
    });

    $(".btn-imagem-excluir").click(function () {
        var CampoHidden = $(this).parent().find("input[name=imagem]");
        var Imagem = $(this).parent().find(".img-upload");
        var BtnExcluir = $(this).parent().find(".btn-imagem-excluir");
        var InputFile = $(this).parent().find(".input-file");

        $.ajax({
            type: "GET",
            url: "/Admin/Imagem/Deletar?caminho=" + CampoHidden.val(),
            error: function () {
                alert("Erro ao deletar a imagem.");
            },
            success: function (data) {
                Imagem.attr("src", "/images/noimage.png")
                BtnExcluir.addClass("btn-ocultar");
                CampoHidden.val("");
                InputFile.val("");
            }
        });
    });

    $(".input-file").change(function () {
        //FORMULARIO VIA JS

        var Binario = $(this)[0].files[0];
        var Formulario = new FormData();
        Formulario.append("file", Binario);

        var CampoHidden = $(this).parent().find("input[name=imagem]");
        var Imagem = $(this).parent().find(".img-upload");
        var BtnExcluir = $(this).parent().find(".btn-imagem-excluir");

        //APRESENTA GIF LOADING
        Imagem.attr("src", "/images/iconeloading.gif");

        //REQUISIÇÃO AJAX ENVIANDO FORMULARIO
        $.ajax({
            type: "POST",
            url: "/Admin/Imagem/Armazenar",
            data: Formulario,
            contentType: false,
            processData: false,
            error: function () {
                alert("Erro no envio do arquivo");
                Imagem.attr("src", "/images/noimage.png")
            },
            success: function (data) {
                var caminho = data.caminho;
                Imagem.attr("src", caminho);
                CampoHidden.val(caminho);
                BtnExcluir.removeClass("btn-ocultar");
            }
        });
    });
}