#pragma checksum "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45c8eaf4e4727ea5fad5932db12be8e7d2766d45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Cliente_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Cliente/Index.cshtml")]
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
#line 3 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\_ViewImports.cshtml"
using BazarPapelaria10.Models.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\_ViewImports.cshtml"
using BazarPapelaria10.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\_ViewImports.cshtml"
using BazarPapelaria10.Models.ProdutoAgregador;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45c8eaf4e4727ea5fad5932db12be8e7d2766d45", @"/Areas/Admin/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"952fea91d92cf28967ffc5d1683418cfab8595bd", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<BazarPapelaria10.Models.Pessoa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtivarDesativar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info inativar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("inativar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Nota 10 - Clientes";
    var pesquisa = Context.Request.Query["pesquisa"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c8eaf4e4727ea5fad5932db12be8e7d2766d455759", async() => {
                WriteLiteral("\r\n        <h2 style=\"margin-top:15px; margin-bottom:30px;\"><i class=\"fas fa-th-list\"></i> Clientes</h2>\r\n\r\n        <!-- Pesquisa Cliente\r\n\r\n    --QueryString: Colaborador/Cliente/Index?pesquisa=\"\"\r\n    -->\r\n\r\n");
#nullable restore
#line 15 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
         if (TempData["MSG_S"] != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"alert alert-success alert-dismissible\" style=\"margin-top:15px\">\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\">×</button>\r\n                ");
#nullable restore
#line 19 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
           Write(TempData["MSG_S"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 21 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 25 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
         if (Model.Count > 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c8eaf4e4727ea5fad5932db12be8e7d2766d457405", async() => {
                    WriteLiteral("\r\n\r\n                <div class=\"input-group w-100\">\r\n                    <input for=\"pesquisa\" name=\"pesquisa\" id=\"pesquisa\"");
                    BeginWriteAttribute("value", " value=\"", 889, "\"", 906, 1);
#nullable restore
#line 30 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 897, pesquisa, 897, 9, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" type=""text"" class=""form-control rounded"" type=""search"" placeholder=""Nome ou e-mail do cliente."">
                    <div class=""input-group-append"">
                        <button class=""btn btn-dark rounded"" type=""submit"">
                            <i class=""fa fa-search""></i>
                        </button>
                    </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral(@"            <div class=""table-responsive rounded"" style=""margin-top:20px;"">
                <table class=""table table-hover table-striped table-bordered "">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"">");
#nullable restore
#line 42 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.First().Nome));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <th scope=\"col\">");
#nullable restore
#line 43 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.First().Email));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</th>
                            <th scope=""col"">CPF</th>
                            <th scope=""col"">Data de Nascimento</th>
                            <th scope=""col"">Sexo</th>
                            <th scope=""col"">Ações</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 51 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
                         foreach (var cliente in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 54 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
                               Write(cliente.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 55 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
                               Write(cliente.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 56 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
                               Write(cliente.Cpf);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 57 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
                               Write(cliente.Nascimento.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 58 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
                                 if (cliente.Sexo == "M")
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td>Masculino</td>\r\n");
#nullable restore
#line 61 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td>Feminino</td>\r\n");
#nullable restore
#line 65 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>\r\n");
#nullable restore
#line 67 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
                                     if (cliente.Ativo == false)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c8eaf4e4727ea5fad5932db12be8e7d2766d4513890", async() => {
                    WriteLiteral("<i class=\"fas fa-eye\"></i> Ativar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
                                                                          WriteLiteral(cliente.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 70 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c8eaf4e4727ea5fad5932db12be8e7d2766d4516723", async() => {
                    WriteLiteral("<i class=\"fas fa-eye-slash\"></i> Inativar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
                                                                          WriteLiteral(cliente.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 74 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 77 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </table>\r\n            </div>\r\n");
#nullable restore
#line 81 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
       Write(Html.PagedListPager((IPagedList)Model, pagina => Url.Action("Index", new { pagina = pagina, pesquisa = pesquisa })));

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
                                                                                                                                

        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"alert alert-dark alert-dismissible\">\r\n                <strong>Nenhum cliente cadastrado!</strong>\r\n            </div>\r\n");
#nullable restore
#line 89 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Cliente\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
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
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<BazarPapelaria10.Models.Pessoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
