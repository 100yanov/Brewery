#pragma checksum "C:\Users\Stoyan Stoyanov\Desktop\homework\Brewery\Brewery.Web\Areas\Admin\Views\Brews\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96c2e62cc9f9085929cb7e3bac6b1b76a0a7f41f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Brewery.Web.Areas.Admin.Brews.Areas_Admin_Views_Brews_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Brews/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Brews/Details.cshtml", typeof(Brewery.Web.Areas.Admin.Brews.Areas_Admin_Views_Brews_Details))]
namespace Brewery.Web.Areas.Admin.Brews
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Stoyan Stoyanov\Desktop\homework\Brewery\Brewery.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Brewery.Web.Areas.Admin.Models.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Stoyan Stoyanov\Desktop\homework\Brewery\Brewery.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Brewery.Web.Areas.Admin.Models.BindingModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96c2e62cc9f9085929cb7e3bac6b1b76a0a7f41f", @"/Areas/Admin/Views/Brews/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a2e1845f0c62a4e469f33a374afb499658a4e5f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Brews_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BrewViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(26, 22, false);
#line 3 "C:\Users\Stoyan Stoyanov\Desktop\homework\Brewery\Brewery.Web\Areas\Admin\Views\Brews\Details.cshtml"
Write(Html.DisplayForModel());

#line default
#line hidden
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
