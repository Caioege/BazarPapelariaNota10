#pragma checksum "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Report\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98d2410a3f5c4daa5483d05fce9e6da7879b10b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Report_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Report/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98d2410a3f5c4daa5483d05fce9e6da7879b10b8", @"/Areas/Admin/Views/Report/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60a38d1721f382072dddce50f0e7c0f348a38c6f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Report_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\inetpub\wwwroot\BazarPapelaria10\Areas\Admin\Views\Report\Index.cshtml"
  
    ViewData["Title"] = "Produtos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-bordered"" id=""tabelaProduto"">

    <thead class=""thead-dark"">
        <tr>
            <th>Nome</th>
            <th>Descrição</th>
            <th>Quantidade</th>
            <th>Valor</th>
            <th>Status</th>
            <th>Obs</th>
        </tr>
    </thead>
</table>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/v/dt/dt-1.10.21/datatables.min.css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.21/css/jquery.dataTables.min.css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/buttons/1.6.2/css/buttons.dataTables.min.css"" />

    <script type=""text/javascript"" src=""https://cdn.datatables.net/v/dt/dt-1.10.21/datatables.min.js""></script>
    <script type=""text/javascript"" src=""https://code.jquery.com/jquery-3.5.1.js""></script>
    <script type=""text/javascript"" src=""https://cdn.datatables.net/1.10.21/js/jquery.dataTables.min.js""></script>
    <script type=""text/javascript"" src=""https://cdn.datatables.net/buttons/1.6.2/js/dataTables.buttons.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/pdfmake.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/vf");
                WriteLiteral(@"s_fonts.js""></script>
    <script type=""text/javascript"" src=""https://cdn.datatables.net/buttons/1.6.2/js/buttons.html5.min.js""></script>

    <script>
        $(document).ready(function () {

            $(""#tabelaProduto"").DataTable({
                ajax: {
                    ""url"": ""/Colaborador/Report/GetProdutos"",
                    ""dataSrc"": """"
                },
                ""columns"": [
                    { ""data"": ""nomeprod"" },
                    { ""data"": ""descprod"" },
                    { ""data"": ""quantidade"" },
                    { ""data"": ""valorprod"" },
                    { ""data"": ""ativo"" },
                    { ""data"": ""obsprod"" }
                ],
                dom: 'Bfrtip',
                buttons: [
                    'copy', 'pdf'
                ],
                ""language"": {
                    ""url"": ""//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Portuguese-Brasil.json""
                }
            });
        });
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
