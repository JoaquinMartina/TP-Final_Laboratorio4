#pragma checksum "D:\Usuario\Desktop\TP-Final_Laboratorio4\WebAppPeliculas\Views\PeliculaGeneroes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a99396554574cd47f75f4f2c1dad31d5637328fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PeliculaGeneroes_Index), @"mvc.1.0.view", @"/Views/PeliculaGeneroes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PeliculaGeneroes/Index.cshtml", typeof(AspNetCore.Views_PeliculaGeneroes_Index))]
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
#line 1 "D:\Usuario\Desktop\TP-Final_Laboratorio4\WebAppPeliculas\Views\_ViewImports.cshtml"
using WebAppPeliculas;

#line default
#line hidden
#line 2 "D:\Usuario\Desktop\TP-Final_Laboratorio4\WebAppPeliculas\Views\_ViewImports.cshtml"
using WebAppPeliculas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a99396554574cd47f75f4f2c1dad31d5637328fe", @"/Views/PeliculaGeneroes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fb33ffdf5416a0b1f038ef4d422a44ae96ab75f", @"/Views/_ViewImports.cshtml")]
    public class Views_PeliculaGeneroes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAppPeliculas.Models.PeliculaGenero>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Usuario\Desktop\TP-Final_Laboratorio4\WebAppPeliculas\Views\PeliculaGeneroes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a99396554574cd47f75f4f2c1dad31d5637328fe3924", async() => {
                BeginContext(154, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(168, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(261, 44, false);
#line 16 "D:\Usuario\Desktop\TP-Final_Laboratorio4\WebAppPeliculas\Views\PeliculaGeneroes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pelicula));

#line default
#line hidden
            EndContext();
            BeginContext(305, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(361, 42, false);
#line 19 "D:\Usuario\Desktop\TP-Final_Laboratorio4\WebAppPeliculas\Views\PeliculaGeneroes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Genero));

#line default
#line hidden
            EndContext();
            BeginContext(403, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "D:\Usuario\Desktop\TP-Final_Laboratorio4\WebAppPeliculas\Views\PeliculaGeneroes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(521, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(570, 51, false);
#line 28 "D:\Usuario\Desktop\TP-Final_Laboratorio4\WebAppPeliculas\Views\PeliculaGeneroes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pelicula.Resumen));

#line default
#line hidden
            EndContext();
            BeginContext(621, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(677, 53, false);
#line 31 "D:\Usuario\Desktop\TP-Final_Laboratorio4\WebAppPeliculas\Views\PeliculaGeneroes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genero.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(730, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(786, 65, false);
#line 34 "D:\Usuario\Desktop\TP-Final_Laboratorio4\WebAppPeliculas\Views\PeliculaGeneroes\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(851, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(872, 71, false);
#line 35 "D:\Usuario\Desktop\TP-Final_Laboratorio4\WebAppPeliculas\Views\PeliculaGeneroes\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(943, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(964, 69, false);
#line 36 "D:\Usuario\Desktop\TP-Final_Laboratorio4\WebAppPeliculas\Views\PeliculaGeneroes\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 39 "D:\Usuario\Desktop\TP-Final_Laboratorio4\WebAppPeliculas\Views\PeliculaGeneroes\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1072, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAppPeliculas.Models.PeliculaGenero>> Html { get; private set; }
    }
}
#pragma warning restore 1591
