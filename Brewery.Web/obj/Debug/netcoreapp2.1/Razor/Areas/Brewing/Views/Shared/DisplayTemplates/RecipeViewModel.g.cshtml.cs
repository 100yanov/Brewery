#pragma checksum "D:\stucky\Web Advanced\Brewery\Brewery.Web\Areas\Brewing\Views\Shared\DisplayTemplates\RecipeViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12a550ec23d0dd40c12f16412a86884ab56dc42e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Brewery.Web.Areas.Brewing.Shared.DisplayTemplates.Areas_Brewing_Views_Shared_DisplayTemplates_RecipeViewModel), @"mvc.1.0.view", @"/Areas/Brewing/Views/Shared/DisplayTemplates/RecipeViewModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Brewing/Views/Shared/DisplayTemplates/RecipeViewModel.cshtml", typeof(Brewery.Web.Areas.Brewing.Shared.DisplayTemplates.Areas_Brewing_Views_Shared_DisplayTemplates_RecipeViewModel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12a550ec23d0dd40c12f16412a86884ab56dc42e", @"/Areas/Brewing/Views/Shared/DisplayTemplates/RecipeViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f37bb2b0b09dc6633b97322b69c206a9e8bf2c4", @"/Areas/Brewing/Views/_ViewImports.cshtml")]
    public class Areas_Brewing_Views_Shared_DisplayTemplates_RecipeViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 271, true);
            WriteLiteral(@"<div>
    <hr />
    <table class=""table table-bordered table-striped"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Description</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>");
            EndContext();
            BeginContext(296, 10, false);
#line 13 "D:\stucky\Web Advanced\Brewery\Brewery.Web\Areas\Brewing\Views\Shared\DisplayTemplates\RecipeViewModel.cshtml"
               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(306, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(334, 17, false);
#line 14 "D:\stucky\Web Advanced\Brewery\Brewery.Web\Areas\Brewing\Views\Shared\DisplayTemplates\RecipeViewModel.cshtml"
               Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(351, 355, true);
            WriteLiteral(@"</td>
            </tr>
        </tbody>
    </table>
</div>
<br>
<h3>Ingredients:</h3>
<hr />
<div>
    <table class=""table table-bordered table-striped"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Quantity</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                ");
            EndContext();
            BeginContext(707, 35, false);
#line 32 "D:\stucky\Web Advanced\Brewery\Brewery.Web\Areas\Brewing\Views\Shared\DisplayTemplates\RecipeViewModel.cshtml"
           Write(Html.DisplayFor(r => r.Ingredients));

#line default
#line hidden
            EndContext();
            BeginContext(742, 63, true);
            WriteLiteral("\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
