#pragma checksum "C:\Users\Elias\Desktop\ASPNETCoreSignalR\Seção 04\10_Fim\RealPromo\RealPromo.ApiWeb\Views\Home\Promocao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc2517e9bf64eb2722e5f945b338c162e21ca32c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Promocao), @"mvc.1.0.view", @"/Views/Home/Promocao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Promocao.cshtml", typeof(AspNetCore.Views_Home_Promocao))]
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
#line 1 "C:\Users\Elias\Desktop\ASPNETCoreSignalR\Seção 04\10_Fim\RealPromo\RealPromo.ApiWeb\Views\_ViewImports.cshtml"
using RealPromo.ApiWeb;

#line default
#line hidden
#line 2 "C:\Users\Elias\Desktop\ASPNETCoreSignalR\Seção 04\10_Fim\RealPromo\RealPromo.ApiWeb\Views\_ViewImports.cshtml"
using RealPromo.ApiWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc2517e9bf64eb2722e5f945b338c162e21ca32c", @"/Views/Home/Promocao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51f4d859b3a80e3984875e03b0088904a9c0f8f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Promocao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("style", async() => {
                BeginContext(16, 185, true);
                WriteLiteral(" \r\n    <style type=\"text/css\">\r\n        body {\r\n            background-color: #FE602B;\r\n        }\r\n\r\n        .container-login {\r\n            text-align: left;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(204, 459, true);
            WriteLiteral(@"
<div class=""container-login"" id=""container-login"">
    <!--
    <div class=""container-promo"">
        <div class=""container-chamada"">
            <h1>Carrefour</h1>
            <p>TV LG 40"" - R$ 999,99</p>
            <p>Somente 20 unidades</p>
        </div>
        <div class=""container-botao"">
            <a href=""EnderecoURL"">Pegar</a>
        </div>
    </div>
    -->
    <span>*Todas as promoções tem um prazo de 1 hora.</span>
</div>");
            EndContext();
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
