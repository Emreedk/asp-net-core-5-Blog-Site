#pragma checksum "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7470e8fb11519954c274adea143aad9c3abb0bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\_ViewImports.cshtml"
using BlogProject_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\_ViewImports.cshtml"
using BlogProject_UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\Dashboard\Index.cshtml"
using BlogProject_EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7470e8fb11519954c274adea143aad9c3abb0bf", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1831ba975c6e3e8bd8bf8b6e72a3de21cd62a9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
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
#nullable restore
#line 3 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7470e8fb11519954c274adea143aad9c3abb0bf4937", async() => {
                WriteLiteral(@"
    <div class=""container-scroller"">
        <div class=""container-fluid page-body-wrapper"">
            <div class=""main-panel"">
                <div class=""content-wrapper"">

                    <div class=""page-header"">
                        <h3 class=""page-title"">
                            <span class=""page-title-icon bg-gradient-primary text-white mr-2"">
                                <i class=""mdi mdi-home""></i>
                            </span> Dashboard
                        </h3>

                    </div>
                    <div class=""row"">
                        ");
#nullable restore
#line 22 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\Dashboard\Index.cshtml"
                   Write(await Component.InvokeAsync("TotalBlogCountOnDashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 23 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\Dashboard\Index.cshtml"
                   Write(await Component.InvokeAsync("TotalBlogCountByWriter"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        
                        <div class=""col-md-4 stretch-card grid-margin"">
                            <div class=""card bg-gradient-success card-img-holder text-white"">
                                <div class=""card-body"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a7470e8fb11519954c274adea143aad9c3abb0bf6772", async() => {
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
#line 32 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\Dashboard\Index.cshtml"
                                                Write(Model.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                                    <h6 class=\"card-text\">Kültür Atölyesi</h6>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    ");
#nullable restore
#line 38 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\Dashboard\Index.cshtml"
               Write(await Component.InvokeAsync("BlogListDashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    ");
#nullable restore
#line 40 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\Dashboard\Index.cshtml"
               Write(await Component.InvokeAsync("CategoryListDashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
