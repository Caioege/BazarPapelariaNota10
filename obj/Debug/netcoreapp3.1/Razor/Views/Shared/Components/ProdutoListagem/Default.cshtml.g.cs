#pragma checksum "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e0589ffd78ff7c0d39f40b58c7d3fda50917c62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProdutoListagem_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProdutoListagem/Default.cshtml")]
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
#line 4 "C:\inetpub\wwwroot\BazarPapelaria10\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\BazarPapelaria10\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\BazarPapelaria10\Views\_ViewImports.cshtml"
using BazarPapelaria10.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e0589ffd78ff7c0d39f40b58c7d3fda50917c62", @"/Views/Shared/Components/ProdutoListagem/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6023a6ada7180362064a56f703cf1d46f3f0ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProdutoListagem_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProdutoListagemViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ordenacao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/semimagem.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml"
   
    var pesquisa = Context.Request.Query["pesquisa"];
    var ordenacao = Context.Request.Query["ordenacao"].ToString();

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml"
 if (Model.lista.Count > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\" style=\"margin-top:10px;\">\r\n        <div class=\"offset-md-10 col-md-2\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0589ffd78ff7c0d39f40b58c7d3fda50917c626230", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 11 "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => ordenacao);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 11 "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ordenacao;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"row\" style=\"margin-top:50px\">\r\n");
#nullable restore
#line 16 "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml"
         foreach (var produto in Model.lista)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3 col-md-6 mb-4\"");
            BeginWriteAttribute("value", " value=\"", 591, "\"", 610, 1);
#nullable restore
#line 18 "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml"
WriteAttributeValue("", 599, produto.Id, 599, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"card h-100\">\r\n                    <a>\r\n");
#nullable restore
#line 21 "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                         if (produto.Imagens != null && produto.Imagens.Count() > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 847, "\"", 907, 1);
#nullable restore
#line 23 "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml"
WriteAttributeValue("", 853, Url.Content(produto.Imagens.FirstOrDefault().Caminho), 853, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 908, "\"", 914, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 24 "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8e0589ffd78ff7c0d39f40b58c7d3fda50917c6210398", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </a>\r\n                    <div class=\"card-body\">\r\n                        <h4 class=\"card-title text-center\">\r\n                            ");
#nullable restore
#line 32 "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                       Write(Html.ActionLink(produto.ToLower(produto.Nomeprod), "Produto", new { Prod = UrlSlugger.ToUrlSlug(produto.Nomeprod) }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h4>\r\n                        <h5 class=\"text-center\">");
#nullable restore
#line 34 "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                                           Write(produto.Valorprod.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n");
#nullable restore
#line 36 "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                         if (produto.Descprod != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"card-text\">");
#nullable restore
#line 38 "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                                            Write(produto.Descprod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 39 "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"card-text text-center\">Produto sem descrição.</p>\r\n");
#nullable restore
#line 43 "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""card-footer text-center"">
                        <small class=""text-muted"">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 50 "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 52 "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"margin-left:auto; margin-right: auto;\">\r\n        <div class=\"offset-md-3 col-md-6\">\r\n            ");
#nullable restore
#line 55 "C:\inetpub\wwwroot\BazarPapelaria10\Views\Shared\Components\ProdutoListagem\Default.cshtml"
       Write(Html.PagedListPager((IPagedList)Model.lista, pagina => Url.Action("Index", new { pagina = pagina, pesquisa = pesquisa, ordenacao = ordenacao })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProdutoListagemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
