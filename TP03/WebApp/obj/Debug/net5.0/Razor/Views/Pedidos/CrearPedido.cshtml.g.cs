#pragma checksum "C:\Taller\Repogit\tp032021-Mario1294\TP03\WebApp\Views\Pedidos\CrearPedido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a74e6b6c12cd18848b4fbc3bded87ee007642b2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidos_CrearPedido), @"mvc.1.0.view", @"/Views/Pedidos/CrearPedido.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a74e6b6c12cd18848b4fbc3bded87ee007642b2d", @"/Views/Pedidos/CrearPedido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_CrearPedido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CrearPedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pedidos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Taller\Repogit\tp032021-Mario1294\TP03\WebApp\Views\Pedidos\CrearPedido.cshtml"
  
    ViewData["Title"] = "Crear Pedido";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h3 >Datos del Pedido</h3>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a74e6b6c12cd18848b4fbc3bded87ee007642b2d4435", async() => {
                WriteLiteral("\r\n\r\n    <fieldset>\r\n\r\n        <div class=\"col-md-6\">\r\n            <label for=\"obs\" class=\"form-label\">Osbservacion:</label>\r\n            <input type=\"text\" class=\"form-control\" name=\"obs\"");
                BeginWriteAttribute("value", " value=\"", 356, "\"", 364, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"obs\" required />\r\n        </div>\r\n\r\n        <div class=\"col-md-6\">\r\n            <label for=\"est\" class=\"form-label\">Estado: </label>\r\n            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("id", " id=\"", 555, "\"", 560, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"est\"");
                BeginWriteAttribute("value", " value=\"", 572, "\"", 580, 0);
                EndWriteAttribute();
                WriteLiteral(" required />\r\n        </div>\r\n        <br /><h3>Datos del Cliente</h3>\r\n        <div class=\"col-md-6\">\r\n            <label for=\"name\" class=\"form-label\">Nombre: </label>\r\n            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("id", " id=\"", 803, "\"", 808, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 821, "\"", 829, 0);
                EndWriteAttribute();
                WriteLiteral(" required />\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <label for=\"phone\" class=\"form-label\">Telefono: </label>\r\n            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("id", " id=\"", 1013, "\"", 1018, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"phone\"");
                BeginWriteAttribute("value", " value=\"", 1032, "\"", 1040, 0);
                EndWriteAttribute();
                WriteLiteral(" required />\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <label for=\"address\" class=\"form-label\">Direccion: </label>\r\n            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("id", " id=\"", 1227, "\"", 1232, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"address\"");
                BeginWriteAttribute("value", " value=\"", 1248, "\"", 1256, 0);
                EndWriteAttribute();
                WriteLiteral(" required />\r\n        </div>\r\n\r\n\r\n        <div class=\"col-md-6\">\r\n            <br />\r\n            <input type=\"submit\" class=\"btn-primary\" />\r\n        </div>\r\n\r\n    </fieldset>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
