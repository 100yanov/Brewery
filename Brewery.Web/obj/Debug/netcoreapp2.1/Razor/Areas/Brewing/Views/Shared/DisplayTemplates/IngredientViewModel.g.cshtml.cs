#pragma checksum "D:\stucky\Web Advanced\Brewery\Brewery.Web\Areas\Brewing\Views\Shared\DisplayTemplates\IngredientViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fa50b873071b2819ba7f31dbff81ff8b6d5a254"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Brewery.Web.Areas.Brewing.Shared.DisplayTemplates.Areas_Brewing_Views_Shared_DisplayTemplates_IngredientViewModel), @"mvc.1.0.view", @"/Areas/Brewing/Views/Shared/DisplayTemplates/IngredientViewModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Brewing/Views/Shared/DisplayTemplates/IngredientViewModel.cshtml", typeof(Brewery.Web.Areas.Brewing.Shared.DisplayTemplates.Areas_Brewing_Views_Shared_DisplayTemplates_IngredientViewModel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fa50b873071b2819ba7f31dbff81ff8b6d5a254", @"/Areas/Brewing/Views/Shared/DisplayTemplates/IngredientViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f37bb2b0b09dc6633b97322b69c206a9e8bf2c4", @"/Areas/Brewing/Views/_ViewImports.cshtml")]
    public class Areas_Brewing_Views_Shared_DisplayTemplates_IngredientViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IngredientViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 24, true);
            WriteLiteral("    <tr>\r\n\r\n        <td>");
            EndContext();
            BeginContext(53, 10, false);
#line 4 "D:\stucky\Web Advanced\Brewery\Brewery.Web\Areas\Brewing\Views\Shared\DisplayTemplates\IngredientViewModel.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(63, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(83, 14, false);
#line 5 "D:\stucky\Web Advanced\Brewery\Brewery.Web\Areas\Brewing\Views\Shared\DisplayTemplates\IngredientViewModel.cshtml"
       Write(Model.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(97, 20, true);
            WriteLiteral("</td>\r\n    </tr>\r\n  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IngredientViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591