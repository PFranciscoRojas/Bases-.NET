#pragma checksum "D:\A Material de estudio\Platzi\Asp .Net\Views\Escuela\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55f36d885ce6cd4a1230e389622173e180d16c6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Escuela/Index.cshtml", typeof(AspNetCore.Views_Escuela_Index))]
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
#line 1 "D:\A Material de estudio\Platzi\Asp .Net\Views\_ViewImports.cshtml"
using Asp_.Net;

#line default
#line hidden
#line 2 "D:\A Material de estudio\Platzi\Asp .Net\Views\_ViewImports.cshtml"
using Asp_.Net.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f36d885ce6cd4a1230e389622173e180d16c6a", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b1e026266f3354ee2f874cf6ffa12eca4e2d311", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\A Material de estudio\Platzi\Asp .Net\Views\Escuela\Index.cshtml"
  
    ViewData["Title"] = "Información Escuela";
    Layout = "Simple";

#line default
#line hidden
            BeginContext(96, 55, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
            EndContext();
            BeginContext(152, 17, false);
#line 8 "D:\A Material de estudio\Platzi\Asp .Net\Views\Escuela\Index.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(169, 23, true);
            WriteLiteral("</h1>\r\n    <h1>Escuela ");
            EndContext();
            BeginContext(193, 12, false);
#line 9 "D:\A Material de estudio\Platzi\Asp .Net\Views\Escuela\Index.cshtml"
           Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(205, 32, true);
            WriteLiteral("</h1>\r\n    <h3>Tipo de Escuela: ");
            EndContext();
            BeginContext(238, 17, false);
#line 10 "D:\A Material de estudio\Platzi\Asp .Net\Views\Escuela\Index.cshtml"
                    Write(Model.TipoEscuela);

#line default
#line hidden
            EndContext();
            BeginContext(255, 33, true);
            WriteLiteral("</h3>\r\n    <address>\r\n        <p>");
            EndContext();
            BeginContext(289, 10, false);
#line 12 "D:\A Material de estudio\Platzi\Asp .Net\Views\Escuela\Index.cshtml"
      Write(Model.Pais);

#line default
#line hidden
            EndContext();
            BeginContext(299, 18, true);
            WriteLiteral(":</p>\r\n        <p>");
            EndContext();
            BeginContext(318, 12, false);
#line 13 "D:\A Material de estudio\Platzi\Asp .Net\Views\Escuela\Index.cshtml"
      Write(Model.Ciudad);

#line default
#line hidden
            EndContext();
            BeginContext(330, 18, true);
            WriteLiteral(":</p>\r\n        <p>");
            EndContext();
            BeginContext(349, 15, false);
#line 14 "D:\A Material de estudio\Platzi\Asp .Net\Views\Escuela\Index.cshtml"
      Write(Model.Dirección);

#line default
#line hidden
            EndContext();
            BeginContext(364, 52, true);
            WriteLiteral("</p>\r\n    </address>\r\n    <p><strong>Año Fundación: ");
            EndContext();
            BeginContext(417, 19, false);
#line 16 "D:\A Material de estudio\Platzi\Asp .Net\Views\Escuela\Index.cshtml"
                         Write(Model.AñoDeCreación);

#line default
#line hidden
            EndContext();
            BeginContext(436, 22, true);
            WriteLiteral("</strong></p>\r\n    <p>");
            EndContext();
            BeginContext(459, 20, false);
#line 17 "D:\A Material de estudio\Platzi\Asp .Net\Views\Escuela\Index.cshtml"
  Write(ViewBag.CosaDinamica);

#line default
#line hidden
            EndContext();
            BeginContext(479, 14, true);
            WriteLiteral("</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela> Html { get; private set; }
    }
}
#pragma warning restore 1591
