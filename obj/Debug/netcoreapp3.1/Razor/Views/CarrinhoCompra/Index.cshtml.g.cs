#pragma checksum "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f84dd9a79e3de3fce76a197697b994df63d0895e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarrinhoCompra_Index), @"mvc.1.0.view", @"/Views/CarrinhoCompra/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\inetpub\wwwroot\BazarPapelaria10\Views\_ViewImports.cshtml"
using BazarPapelaria10;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\inetpub\wwwroot\BazarPapelaria10\Views\_ViewImports.cshtml"
using BazarPapelaria10.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\BazarPapelaria10\Views\_ViewImports.cshtml"
using BazarPapelaria10.Models.ProdutoAgregador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\BazarPapelaria10\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\BazarPapelaria10\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\BazarPapelaria10\Views\_ViewImports.cshtml"
using BazarPapelaria10.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f84dd9a79e3de3fce76a197697b994df63d0895e", @"/Views/CarrinhoCompra/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c030953df67c643875230b79b7642293c8c6fefe", @"/Views/_ViewImports.cshtml")]
    public class Views_CarrinhoCompra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BazarPapelaria10.Models.ProdutoAgregador.ProdutoItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Visualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CarrinhoCompra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoverItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-continuar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnderecoEntrega", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
  
    ViewData["Title"] = "Carrinho";
    decimal subTotal = 0;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f84dd9a79e3de3fce76a197697b994df63d0895e7466", async() => {
                WriteLiteral("\r\n    <title>Nota 10 - Carrinho</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f84dd9a79e3de3fce76a197697b994df63d0895e8477", async() => {
                WriteLiteral(@"
    <main role=""main"">

        <section class=""container"" id=""order"" style=""margin-top: 50px"">

            <h2 class=""title-doc text-center""><i class=""fas fa-shopping-cart""></i> Carrinho de Compras</h2>

            <div class=""alert alert-danger alert-dismissible fade show"" style=""display:none;"" role=""alert"">
                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <div id=""code_cart"">

");
#nullable restore
#line 26 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                 if (Model.Count() > 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""card"">

                        <table class=""table table-hover shopping-cart-wrap"">
                            <thead class=""text-muted"">
                                <tr>
                                    <th scope=""col"">Produto</th>
                                    <th scope=""col"" class=""text-center"" width=""200"">Quantidade</th>
                                    <th scope=""col"" width=""200"">Preço</th>
                                    <th scope=""col"" width=""120"" class=""text-center"">Ações</th>
                                </tr>
                            </thead>
                            <tbody>

");
#nullable restore
#line 41 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            <figure class=\"itemside\">\r\n\r\n");
#nullable restore
#line 47 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                 if (item.Imagens != null && item.Imagens.Count > 0)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <div class=\"img-wrap aside\" style=\"max-width:70px; max-height: 70px;\">\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f84dd9a79e3de3fce76a197697b994df63d0895e11244", async() => {
                    WriteLiteral("\r\n                                                            <img");
                    BeginWriteAttribute("src", " src=\"", 2298, "\"", 2342, 1);
#nullable restore
#line 51 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 2304, item.Imagens.FirstOrDefault().Caminho, 2304, 38, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"img-thumbnail img-sm\">\r\n                                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    </div>\r\n");
#nullable restore
#line 54 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                }
                                                else 
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <div class=\"img-wrap aside\" style=\"max-width:70px; max-height: 70px;\"><img src=\"/images/noimage.png\" class=\"img-thumbnail img-sm\"></div>\r\n");
#nullable restore
#line 58 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                <figcaption class=\"media-body\" style=\"margin-left:10px;\">\r\n                                                    <h6 class=\"title text-truncate\">");
#nullable restore
#line 61 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                                               Write(item.Nomeprod);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n");
#nullable restore
#line 62 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                     if (item.Marca != null)
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <dl class=\"dlist-inline small\">\r\n\r\n                                                            <dt>Marca: </dt>\r\n                                                            <dd>");
#nullable restore
#line 67 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                           Write(item.Marca);

#line default
#line hidden
#nullable disable
                WriteLiteral("</dd>\r\n\r\n                                                        </dl>\r\n");
#nullable restore
#line 70 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                     if (item.Modelo != null)
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <dl class=\"dlist-inline small\">\r\n\r\n                                                            <dt>Modelo: </dt>\r\n                                                            <dd>");
#nullable restore
#line 76 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                           Write(item.Modelo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</dd>\r\n\r\n                                                        </dl>\r\n");
#nullable restore
#line 79 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                     if (item.Cor != null)
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <dl class=\"dlist-inline small\">\r\n\r\n                                                            <dt>Cor: </dt>\r\n                                                            <dd>");
#nullable restore
#line 85 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                           Write(item.Cor);

#line default
#line hidden
#nullable disable
                WriteLiteral("</dd>\r\n\r\n                                                        </dl>\r\n");
#nullable restore
#line 88 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                     if (item.Material != null)
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <dl class=\"dlist-inline small\">\r\n\r\n                                                            <dt>Marca: </dt>\r\n                                                            <dd>");
#nullable restore
#line 94 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                           Write(item.Material);

#line default
#line hidden
#nullable disable
                WriteLiteral("</dd>\r\n\r\n                                                        </dl>\r\n");
#nullable restore
#line 97 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                </figcaption>
                                            </figure>
                                        </td>

                                        <td>
                                            <div class=""col-auto"">
                                                <div class=""input-group mb-2 custom-control-inline"">
                                                    <input type=""hidden"" class=""inputProdutoId""");
                BeginWriteAttribute("value", " value=\"", 5606, "\"", 5622, 1);
#nullable restore
#line 105 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 5614, item.Id, 5614, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                    <input type=\"hidden\" class=\"inputQuantidadeEstoque\"");
                BeginWriteAttribute("value", " value=\"", 5731, "\"", 5755, 1);
#nullable restore
#line 106 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 5739, item.Quantidade, 5739, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                    <input type=\"hidden\" class=\"inputValorUnitario\"");
                BeginWriteAttribute("value", " value=\"", 5860, "\"", 5883, 1);
#nullable restore
#line 107 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 5868, item.Valorprod, 5868, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                                    <div class=""input-group-prepend"">
                                                        <a href=""#"" class=""btn btn-dark btn-car diminuir rounded""> - </a>
                                                    </div>
                                                    <input type=""text"" readonly class=""form-control text-center rounded inputQuantidadeProdutoCarrinho""");
                BeginWriteAttribute("value", " value=\"", 6310, "\"", 6349, 1);
#nullable restore
#line 111 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 6318, item.QuantidadeProdutoCarrinho, 6318, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                    <div class=""input-group-append"">
                                                        <a href=""#"" class=""btn btn-dark btn-car aumentar rounded""> + </a>
                                                    </div>
                                                </div>
                                            </div>
                                        </td>

");
#nullable restore
#line 119 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                          
                                            var resultado = item.Valorprod * item.QuantidadeProdutoCarrinho;
                                            subTotal += resultado;
                                        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        <td>\r\n                                            <div class=\"price-wrap\">\r\n                                                <var class=\"price\">");
#nullable restore
#line 126 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                               Write(resultado.ToString("C"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</var>\r\n                                                <small class=\"text-muted\">/");
#nullable restore
#line 127 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                                      Write(item.Valorprod.ToString("C"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" cada</small>\r\n                                            </div>\r\n                                        </td>\r\n                                        <td> \r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f84dd9a79e3de3fce76a197697b994df63d0895e24737", async() => {
                    WriteLiteral("<i class=\"fas fa-trash\"></i> Remover");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 131 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 134 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 140 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"alert alert-gray-light\" role=\"alert\"><p>Não existem produtos no carrinho.</p></div>\r\n");
#nullable restore
#line 144 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
        </section>
        <br />
        <br />

        <section class=""container"">
            <div class=""row"">
                <aside class=""col-md-6 text-center"" style=""margin-right:auto; margin-left:auto;"">
                    <div id=""code_desc_right"">
                        <div class=""box"">
                            <h4 class=""subtitle-doc"" style=""margin-bottom:15px;"">
                                <i class=""fas fa-money-bill-wave""></i> Resumo
                            </h4>
                            <dl class=""dlist-align"">
                                <dt><i class=""fas fa-map-marked-alt""></i><strong> Entrega:</strong></dt>
                                <dd class=""text-right"">
                                    Aparecida de Goiânia e Goiânia
                                    <small class=""text-muted"">/frete grátis</small>
                                </dd>
                            </dl>
                            <dl class=""dlist-alig");
                WriteLiteral("n\" style=\"margin-bottom:15px;\">\r\n                                <dt><i class=\"fas fa-money-check-alt\"></i><strong> Valor total:</strong></dt>\r\n                                <dd class=\"text-right h5 b subtotal\">");
#nullable restore
#line 168 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                                Write(subTotal.ToString("C"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</dd>\r\n                            </dl>\r\n\r\n");
#nullable restore
#line 171 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                             if (_loginCliente.GetCliente() == null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f84dd9a79e3de3fce76a197697b994df63d0895e30344", async() => {
                    WriteLiteral("<i class=\"fas fa-truck-loading\"></i> Continuar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 173 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                                                                                                        WriteLiteral(Url.Action("EnderecoEntrega", "CarrinhoCompra", new { area = "" }));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 174 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f84dd9a79e3de3fce76a197697b994df63d0895e33599", async() => {
                    WriteLiteral("<i class=\"fas fa-truck-loading\"></i> Continuar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 178 "C:\inetpub\wwwroot\BazarPapelaria10\Views\CarrinhoCompra\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </aside>\r\n            </div>\r\n        </section>\r\n\r\n        <hr class=\"featurette-divider\">\r\n    </main>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public BazarPapelaria10.Bibliotecas.Login.LoginCliente _loginCliente { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BazarPapelaria10.Models.ProdutoAgregador.ProdutoItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
