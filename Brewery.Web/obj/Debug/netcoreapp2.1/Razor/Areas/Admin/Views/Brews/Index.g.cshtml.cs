#pragma checksum "C:\Users\Stoyan Stoyanov\Desktop\homework\Brewery\Brewery.Web\Areas\Admin\Views\Brews\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb154f6f5144e13c239b1e5521833a40a2d755f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Brewery.Web.Areas.Admin.Brews.Areas_Admin_Views_Brews_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Brews/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Brews/Index.cshtml", typeof(Brewery.Web.Areas.Admin.Brews.Areas_Admin_Views_Brews_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb154f6f5144e13c239b1e5521833a40a2d755f4", @"/Areas/Admin/Views/Brews/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a2e1845f0c62a4e469f33a374afb499658a4e5f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Brews_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BrewViewModel[]>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "IdentifiableViewModelActions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 463, true);
            WriteLiteral(@"
<div>
    <table id=""table_id"" class=""table table-bordered table-striped"">
        <thead>
            <tr>
                <th>
                    Name
                </th>
                <th>
                    Description
                </th>
                <th>
                    Recipe
                </th>
                <th>
                    Action
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 22 "C:\Users\Stoyan Stoyanov\Desktop\homework\Brewery\Brewery.Web\Areas\Admin\Views\Brews\Index.cshtml"
             foreach (var brew in Model)
            {

#line default
#line hidden
            BeginContext(544, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(617, 9, false);
#line 26 "C:\Users\Stoyan Stoyanov\Desktop\homework\Brewery\Brewery.Web\Areas\Admin\Views\Brews\Index.cshtml"
                   Write(brew.Name);

#line default
#line hidden
            EndContext();
            BeginContext(626, 99, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"description\">\r\n                        ");
            EndContext();
            BeginContext(726, 16, false);
#line 29 "C:\Users\Stoyan Stoyanov\Desktop\homework\Brewery\Brewery.Web\Areas\Admin\Views\Brews\Index.cshtml"
                   Write(brew.Description);

#line default
#line hidden
            EndContext();
            BeginContext(742, 94, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"recipe\">\r\n                        ");
            EndContext();
            BeginContext(837, 15, false);
#line 32 "C:\Users\Stoyan Stoyanov\Desktop\homework\Brewery\Brewery.Web\Areas\Admin\Views\Brews\Index.cshtml"
                   Write(brew.RecipeName);

#line default
#line hidden
            EndContext();
            BeginContext(852, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(931, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "13b8a5c4d95d4b6ba07142efd2394bb5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 35 "C:\Users\Stoyan Stoyanov\Desktop\homework\Brewery\Brewery.Web\Areas\Admin\Views\Brews\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = brew;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(990, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 38 "C:\Users\Stoyan Stoyanov\Desktop\homework\Brewery\Brewery.Web\Areas\Admin\Views\Brews\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1057, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BrewViewModel[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
