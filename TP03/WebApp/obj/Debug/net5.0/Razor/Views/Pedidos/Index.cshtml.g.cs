#pragma checksum "C:\Taller\Repogit\tp032021-Mario1294\TP03\WebApp\Views\Pedidos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8c2346039f6927a0e57b6f3426f267aa76dd14c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidos_Index), @"mvc.1.0.view", @"/Views/Pedidos/Index.cshtml")]
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
#line 1 "C:\Taller\Repogit\tp032021-Mario1294\TP03\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Taller\Repogit\tp032021-Mario1294\TP03\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8c2346039f6927a0e57b6f3426f267aa76dd14c", @"/Views/Pedidos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApp.Entidades.Pedido>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Taller\Repogit\tp032021-Mario1294\TP03\WebApp\Views\Pedidos\Index.cshtml"
  
    ViewData["Title"] = "Pedidos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Pedidos</h1>
</div>
<p><a href=""https://localhost:44357/Pedidos/CrearPedido"">Crear Pedido</a>.</p>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Numero de Pedido</th>
            <th scope=""col"">Cliente</th>
            <th scope=""col"">Observacion</th>
            <th scope=""col"">Estado</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 22 "C:\Taller\Repogit\tp032021-Mario1294\TP03\WebApp\Views\Pedidos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "C:\Taller\Repogit\tp032021-Mario1294\TP03\WebApp\Views\Pedidos\Index.cshtml"
               Write(item.Num);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Taller\Repogit\tp032021-Mario1294\TP03\WebApp\Views\Pedidos\Index.cshtml"
               Write(item.Cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Taller\Repogit\tp032021-Mario1294\TP03\WebApp\Views\Pedidos\Index.cshtml"
               Write(item.Obs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  \r\n                <td>");
#nullable restore
#line 28 "C:\Taller\Repogit\tp032021-Mario1294\TP03\WebApp\Views\Pedidos\Index.cshtml"
               Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                \r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\Taller\Repogit\tp032021-Mario1294\TP03\WebApp\Views\Pedidos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApp.Entidades.Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591