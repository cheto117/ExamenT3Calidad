#pragma checksum "D:\2022-1\Calida\aaaaaaa-master\TEJADA_T3\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab7307ed0e2e5456d3d15d4079d123557272f57e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\2022-1\Calida\aaaaaaa-master\TEJADA_T3\Views\_ViewImports.cshtml"
using TEJADA_T3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\2022-1\Calida\aaaaaaa-master\TEJADA_T3\Views\_ViewImports.cshtml"
using TEJADA_T3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab7307ed0e2e5456d3d15d4079d123557272f57e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e84597d94a3f9694b12887e5389618622b7fcc94", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\2022-1\Calida\aaaaaaa-master\TEJADA_T3\Views\Home\Index.cshtml"
   var Historis = (List<Historia>)Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\n    <h1 class=\"display-4\">Historias de Mascotas</h1>\n</div>\n\n<a href=\"/home/privacy\" class=\"btn btn-primary\">Nuevo registro</a>\n<br />\n<br />\n<br />\n<div class=\"row text-center\">\n");
#nullable restore
#line 11 "D:\2022-1\Calida\aaaaaaa-master\TEJADA_T3\Views\Home\Index.cshtml"
     foreach (var item in Historis)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card col-sm-6\">\n            <h4 class=\"card-header text-center\"><strong>");
#nullable restore
#line 14 "D:\2022-1\Calida\aaaaaaa-master\TEJADA_T3\Views\Home\Index.cshtml"
                                                   Write(item.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 14 "D:\2022-1\Calida\aaaaaaa-master\TEJADA_T3\Views\Home\Index.cshtml"
                                                                  Write(item.Dueno);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 14 "D:\2022-1\Calida\aaaaaaa-master\TEJADA_T3\Views\Home\Index.cshtml"
                                                                                Write(item.Mascota);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h4>\n            <div class=\"card-body\">\n                <p class=\"card-text\"><strong>Fecha de Nacimiento: </strong>");
#nullable restore
#line 16 "D:\2022-1\Calida\aaaaaaa-master\TEJADA_T3\Views\Home\Index.cshtml"
                                                                      Write(string.Format("{0:dd MMMM yyyy}", item.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p class=\"card-text\"><strong>Fecha de Registro: </strong>");
#nullable restore
#line 17 "D:\2022-1\Calida\aaaaaaa-master\TEJADA_T3\Views\Home\Index.cshtml"
                                                                    Write(string.Format("{0:dd MMMM yyyy}", item.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p class=\"card-text\"><strong>Direccion del Due??o: </strong>");
#nullable restore
#line 18 "D:\2022-1\Calida\aaaaaaa-master\TEJADA_T3\Views\Home\Index.cshtml"
                                                                      Write(item.DuenoDireccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p class=\"card-text\"><strong>Telefono del Due??o: </strong>");
#nullable restore
#line 19 "D:\2022-1\Calida\aaaaaaa-master\TEJADA_T3\Views\Home\Index.cshtml"
                                                                     Write(item.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p class=\"card-text\"><strong>Email del Due??o: </strong>");
#nullable restore
#line 20 "D:\2022-1\Calida\aaaaaaa-master\TEJADA_T3\Views\Home\Index.cshtml"
                                                                  Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p class=\"card-text\"><strong>Sexo Mascota: </strong>");
#nullable restore
#line 21 "D:\2022-1\Calida\aaaaaaa-master\TEJADA_T3\Views\Home\Index.cshtml"
                                                               Write(item.Sexo.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p class=\"card-text\"><strong>Especie Mascota: </strong>");
#nullable restore
#line 22 "D:\2022-1\Calida\aaaaaaa-master\TEJADA_T3\Views\Home\Index.cshtml"
                                                                  Write(item.Especie.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p class=\"card-text\"><strong>Raza Mascota: </strong>");
#nullable restore
#line 23 "D:\2022-1\Calida\aaaaaaa-master\TEJADA_T3\Views\Home\Index.cshtml"
                                                               Write(item.Raza.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p class=\"card-text\"><strong>Datos Particulares: </strong>");
#nullable restore
#line 24 "D:\2022-1\Calida\aaaaaaa-master\TEJADA_T3\Views\Home\Index.cshtml"
                                                                     Write(item.DatosParticulares);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p class=\"card-text\"><strong>Tama??o: </strong>");
#nullable restore
#line 25 "D:\2022-1\Calida\aaaaaaa-master\TEJADA_T3\Views\Home\Index.cshtml"
                                                         Write(item.Tamano);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n        </div>\n");
#nullable restore
#line 28 "D:\2022-1\Calida\aaaaaaa-master\TEJADA_T3\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
