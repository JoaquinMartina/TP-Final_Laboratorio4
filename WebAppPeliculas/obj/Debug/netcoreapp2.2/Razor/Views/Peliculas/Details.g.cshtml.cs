#pragma checksum "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "087beaedf45d4b5689ccb8ae3f7c06154b314eea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Peliculas_Details), @"mvc.1.0.view", @"/Views/Peliculas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Peliculas/Details.cshtml", typeof(AspNetCore.Views_Peliculas_Details))]
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
#line 1 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\_ViewImports.cshtml"
using WebAppPeliculas;

#line default
#line hidden
#line 2 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\_ViewImports.cshtml"
using WebAppPeliculas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"087beaedf45d4b5689ccb8ae3f7c06154b314eea", @"/Views/Peliculas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fb33ffdf5416a0b1f038ef4d422a44ae96ab75f", @"/Views/_ViewImports.cshtml")]
    public class Views_Peliculas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppPeliculas.Models.Pelicula>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("247"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
  
    ViewData["Title"] = "Detalle Película";

#line default
#line hidden
            BeginContext(94, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(101, 38, false);
#line 7 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
Write(Html.DisplayFor(model => model.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(139, 21, true);
            WriteLiteral("<span> </span><span>(");
            EndContext();
            BeginContext(161, 49, false);
#line 7 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
                                                           Write(Html.DisplayFor(model => model.FechaEstreno.Year));

#line default
#line hidden
            EndContext();
            BeginContext(210, 67, true);
            WriteLiteral(")</span></h1><br />\r\n<p>\r\n    <span class=\"text-primary\">\r\n        ");
            EndContext();
            BeginContext(278, 50, false);
#line 10 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
   Write(Html.DisplayFor(model => model.Genero.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(328, 37, true);
            WriteLiteral("\r\n    </span> |\r\n    <span>\r\n        ");
            EndContext();
            BeginContext(366, 48, false);
#line 13 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
   Write(Html.DisplayFor(model => model.FechaEstreno.Day));

#line default
#line hidden
            EndContext();
            BeginContext(414, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(425, 50, false);
#line 14 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
   Write(Html.DisplayFor(model => model.FechaEstreno.Month));

#line default
#line hidden
            EndContext();
            BeginContext(475, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(486, 49, false);
#line 15 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
   Write(Html.DisplayFor(model => model.FechaEstreno.Year));

#line default
#line hidden
            EndContext();
            BeginContext(535, 169, true);
            WriteLiteral("\r\n    </span> |\r\n    <span>\r\n        Promedio:\r\n    </span> |\r\n    <span>\r\n        Tu voto:\r\n    </span>\r\n</p>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-3\">\r\n        ");
            EndContext();
            BeginContext(704, 156, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "087beaedf45d4b5689ccb8ae3f7c06154b314eea9469", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/images/peliculas/");
#line 27 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
                         WriteLiteral(Model.FotoCartel);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 27 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
AddHtmlAttributeValue("", 818, Html.DisplayFor(model => model.Titulo), 818, 39, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(860, 110, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-sm-9 embed-responsive-16by9\">\r\n        <iframe class=\"embed-responsive-item\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 970, "\"", 990, 1);
#line 30 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
WriteAttributeValue("", 976, Model.Trailer, 976, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(991, 69, true);
            WriteLiteral(" height=\"300\" width=\"700\"></iframe>\r\n    </div>\r\n</div><br />\r\n\r\n<h2>");
            EndContext();
            BeginContext(1061, 43, false);
#line 34 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Resumen));

#line default
#line hidden
            EndContext();
            BeginContext(1104, 22, true);
            WriteLiteral("</h2><br />\r\n<p>\r\n    ");
            EndContext();
            BeginContext(1127, 39, false);
#line 36 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
Write(Html.DisplayFor(model => model.Resumen));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 132, true);
            WriteLiteral("\r\n</p>\r\n\r\n<h2>Actores</h2><br />\r\n\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1299, 72, false);
#line 45 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.PeliculasActores[0].Actor.FotoCarnet));

#line default
#line hidden
            EndContext();
            BeginContext(1371, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1427, 68, false);
#line 48 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.PeliculasActores[0].Actor.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 130, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Nombre papel\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 56 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
         foreach (var item in Model.PeliculasActores)
        {

#line default
#line hidden
            BeginContext(1691, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1751, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "087beaedf45d4b5689ccb8ae3f7c06154b314eea16069", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 60 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
                  WriteLiteral(Html.DisplayFor(modelItem => item.Actor.FotoCarnet));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 60 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1877, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1900, 51, false);
#line 61 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Actor.FotoCarnet));

#line default
#line hidden
            EndContext();
            BeginContext(1951, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2019, 47, false);
#line 64 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Actor.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(2066, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2089, 49, false);
#line 65 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Actor.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(2138, 91, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 71 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP-Final\WebAppPeliculas\WebAppPeliculas\Views\Peliculas\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(2240, 37, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2277, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "087beaedf45d4b5689ccb8ae3f7c06154b314eea20502", async() => {
                BeginContext(2340, 8, true);
                WriteLiteral("Regresar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2352, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppPeliculas.Models.Pelicula> Html { get; private set; }
    }
}
#pragma warning restore 1591
