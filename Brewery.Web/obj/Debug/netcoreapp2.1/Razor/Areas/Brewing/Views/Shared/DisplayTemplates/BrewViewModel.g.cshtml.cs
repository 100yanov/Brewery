#pragma checksum "D:\stucky\Web Advanced\Brewery\Brewery.Web\Areas\Brewing\Views\Shared\DisplayTemplates\BrewViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "027d73afbc25e3728e3e96e7b32b332f6c9ac4c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Brewery.Web.Areas.Brewing.Shared.DisplayTemplates.Areas_Brewing_Views_Shared_DisplayTemplates_BrewViewModel), @"mvc.1.0.view", @"/Areas/Brewing/Views/Shared/DisplayTemplates/BrewViewModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Brewing/Views/Shared/DisplayTemplates/BrewViewModel.cshtml", typeof(Brewery.Web.Areas.Brewing.Shared.DisplayTemplates.Areas_Brewing_Views_Shared_DisplayTemplates_BrewViewModel))]
namespace Brewery.Web.Areas.Brewing.Shared.DisplayTemplates
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\stucky\Web Advanced\Brewery\Brewery.Web\Areas\Brewing\Views\_ViewImports.cshtml"
using Brewery.Web.Areas.Brewing.Models.ViewModels;

#line default
#line hidden
#line 2 "D:\stucky\Web Advanced\Brewery\Brewery.Web\Areas\Brewing\Views\_ViewImports.cshtml"
using Brewery.Web.Areas.Brewing.Models.BindingModels;

#line default
#line hidden
#line 3 "D:\stucky\Web Advanced\Brewery\Brewery.Web\Areas\Brewing\Views\_ViewImports.cshtml"
using Brewery.Core.Constants;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"027d73afbc25e3728e3e96e7b32b332f6c9ac4c0", @"/Areas/Brewing/Views/Shared/DisplayTemplates/BrewViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f37bb2b0b09dc6633b97322b69c206a9e8bf2c4", @"/Areas/Brewing/Views/_ViewImports.cshtml")]
    public class Areas_Brewing_Views_Shared_DisplayTemplates_BrewViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BrewViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 335, true);
            WriteLiteral(@"
    <div>
    <h4>Brew</h4>
    <hr />
    <table  class=""table table-bordered table-striped"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Description</th>
                <th>Recipe Name</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>");
            EndContext();
            BeginContext(358, 10, false);
#line 16 "D:\stucky\Web Advanced\Brewery\Brewery.Web\Areas\Brewing\Views\Shared\DisplayTemplates\BrewViewModel.cshtml"
               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(368, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(396, 17, false);
#line 17 "D:\stucky\Web Advanced\Brewery\Brewery.Web\Areas\Brewing\Views\Shared\DisplayTemplates\BrewViewModel.cshtml"
               Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(413, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(441, 16, false);
#line 18 "D:\stucky\Web Advanced\Brewery\Brewery.Web\Areas\Brewing\Views\Shared\DisplayTemplates\BrewViewModel.cshtml"
               Write(Model.RecipeName);

#line default
#line hidden
            EndContext();
            BeginContext(457, 69, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BrewViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
