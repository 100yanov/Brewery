#pragma checksum "D:\stucky\Web Advanced\Brewery\Brewery.Web\Areas\Brewing\Views\Brews\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "844c464dcc3b75a8a32d62399a68fba2ff062ed0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Brewery.Web.Areas.Brewing.Brews.Areas_Brewing_Views_Brews_Details), @"mvc.1.0.view", @"/Areas/Brewing/Views/Brews/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Brewing/Views/Brews/Details.cshtml", typeof(Brewery.Web.Areas.Brewing.Brews.Areas_Brewing_Views_Brews_Details))]
namespace Brewery.Web.Areas.Brewing.Brews
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"844c464dcc3b75a8a32d62399a68fba2ff062ed0", @"/Areas/Brewing/Views/Brews/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f37bb2b0b09dc6633b97322b69c206a9e8bf2c4", @"/Areas/Brewing/Views/_ViewImports.cshtml")]
    public class Areas_Brewing_Views_Brews_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BrewViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(27, 10, false);
#line 2 "D:\stucky\Web Advanced\Brewery\Brewery.Web\Areas\Brewing\Views\Brews\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(37, 13, true);
            WriteLiteral("</h2>\r\n<hr>\r\n");
            EndContext();
            BeginContext(51, 22, false);
#line 4 "D:\stucky\Web Advanced\Brewery\Brewery.Web\Areas\Brewing\Views\Brews\Details.cshtml"
Write(Html.DisplayForModel());

#line default
#line hidden
            EndContext();
            BeginContext(73, 7, true);
            WriteLiteral("\r\n<div>");
            EndContext();
            BeginContext(81, 37, false);
#line 5 "D:\stucky\Web Advanced\Brewery\Brewery.Web\Areas\Brewing\Views\Brews\Details.cshtml"
Write(Html.DisplayFor(r => r.Id, "Actions"));

#line default
#line hidden
            EndContext();
            BeginContext(118, 6, true);
            WriteLiteral("</div>");
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
