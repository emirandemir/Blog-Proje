#pragma checksum "C:\Users\DEMİR\Source\Repos\CoreDemo\CoreDemo\Views\DashBoard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0ad43a34d680c3f20e66e6a8a53a73ff4d859bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DashBoard_Index), @"mvc.1.0.view", @"/Views/DashBoard/Index.cshtml")]
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
#line 1 "C:\Users\DEMİR\Source\Repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DEMİR\Source\Repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0ad43a34d680c3f20e66e6a8a53a73ff4d859bf", @"/Views/DashBoard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_DashBoard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/writer/assets/images/dashboard/circle.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-absolute"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("circle-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\DEMİR\Source\Repos\CoreDemo\CoreDemo\Views\DashBoard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0ad43a34d680c3f20e66e6a8a53a73ff4d859bf4637", async() => {
                WriteLiteral(@"

                    <div class=""page-header"">
                        <h3 class=""page-title"">
                            <span class=""page-title-icon bg-gradient-primary text-white mr-2"">
                                <i class=""mdi mdi-home""></i>
                            </span> Dashboard
                        </h3>
                        <nav aria-label=""breadcrumb"">
                            <ul class=""breadcrumb"">
                                <li class=""breadcrumb-item active"" aria-current=""page"">
                                    <span></span>Overview <i class=""mdi mdi-alert-circle-outline icon-sm text-primary align-middle""></i>
                                </li>
                            </ul>
                        </nav>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-4 stretch-card grid-margin"">
                            <div class=""card bg-gradient-danger card-img-holder text-white"">
             ");
                WriteLiteral("                   <div class=\"card-body\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f0ad43a34d680c3f20e66e6a8a53a73ff4d859bf6059", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    <h4 class=""font-weight-normal mb-3"">
                                        Toplam Blog Sayısı <i class=""mdi mdi-chart-line mdi-24px float-right""></i>
                                    </h4>
                                    <h2 class=""mb-5"">");
#nullable restore
#line 34 "C:\Users\DEMİR\Source\Repos\CoreDemo\CoreDemo\Views\DashBoard\Index.cshtml"
                                                Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
                                    <h6 class=""card-text"">Core 5.0 Kampı</h6>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4 stretch-card grid-margin"">
                            <div class=""card bg-gradient-info card-img-holder text-white"">
                                <div class=""card-body"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f0ad43a34d680c3f20e66e6a8a53a73ff4d859bf8330", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    <h4 class=""font-weight-normal mb-3"">
                                        Sizin Blog Sayınız <i class=""mdi mdi-bookmark-outline mdi-24px float-right""></i>
                                    </h4>
                                    <h2 class=""mb-5"">");
#nullable restore
#line 46 "C:\Users\DEMİR\Source\Repos\CoreDemo\CoreDemo\Views\DashBoard\Index.cshtml"
                                                Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
                                    <h6 class=""card-text"">Core 5.0 Kampı</h6>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4 stretch-card grid-margin"">
                            <div class=""card bg-gradient-success card-img-holder text-white"">
                                <div class=""card-body"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f0ad43a34d680c3f20e66e6a8a53a73ff4d859bf10610", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    <h4 class=""font-weight-normal mb-3"">
                                        Toplam Kategori Sayısı<i class=""mdi mdi-diamond mdi-24px float-right""></i>
                                    </h4>
                                    <h2 class=""mb-5"">");
#nullable restore
#line 58 "C:\Users\DEMİR\Source\Repos\CoreDemo\CoreDemo\Views\DashBoard\Index.cshtml"
                                                Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                                    <h6 class=\"card-text\">Core 5.0 Kampı</h6>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    ");
#nullable restore
#line 64 "C:\Users\DEMİR\Source\Repos\CoreDemo\CoreDemo\Views\DashBoard\Index.cshtml"
               Write(await Component.InvokeAsync("BlogListDashBoard"));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                    \r\n                    ");
#nullable restore
#line 66 "C:\Users\DEMİR\Source\Repos\CoreDemo\CoreDemo\Views\DashBoard\Index.cshtml"
               Write(await Component.InvokeAsync("WriterAboutOnDashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"row\">\r\n                        ");
#nullable restore
#line 68 "C:\Users\DEMİR\Source\Repos\CoreDemo\CoreDemo\Views\DashBoard\Index.cshtml"
                   Write(await Component.InvokeAsync("CategoryListDashBoard"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
