#pragma checksum "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.26_BlogProject\BlogProject_UI\Views\Shared\Components\BlogLast3Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87212b16030df37ffdf435993ac8d952a830d57f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLast3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
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
#line 1 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.26_BlogProject\BlogProject_UI\Views\_ViewImports.cshtml"
using BlogProject_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.26_BlogProject\BlogProject_UI\Views\_ViewImports.cshtml"
using BlogProject_UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.26_BlogProject\BlogProject_UI\Views\Shared\Components\BlogLast3Post\Default.cshtml"
using BlogProject_EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87212b16030df37ffdf435993ac8d952a830d57f", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1831ba975c6e3e8bd8bf8b6e72a3de21cd62a9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogLast3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"tech-btm\">\r\n    <h3>Son Gönderiler</h3>\r\n");
#nullable restore
#line 7 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.26_BlogProject\BlogProject_UI\Views\Shared\Components\BlogLast3Post\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 272, "\"", 305, 2);
            WriteAttributeValue("", 279, "/Blog/BlogReadAll/", 279, 18, true);
#nullable restore
#line 12 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.26_BlogProject\BlogProject_UI\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 297, item.Id, 297, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 333, "\"", 375, 2);
            WriteAttributeValue("", 339, "/CoreBlogTema/images/", 339, 21, true);
#nullable restore
#line 13 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.26_BlogProject\BlogProject_UI\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 360, item.BlogImage, 360, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 407, "\"", 413, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a class=\"text-white\">");
#nullable restore
#line 20 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.26_BlogProject\BlogProject_UI\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                     Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    <br />\r\n                    ");
#nullable restore
#line 22 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.26_BlogProject\BlogProject_UI\Views\Shared\Components\BlogLast3Post\Default.cshtml"
               Write(item.BlogContent.Substring(0, item.BlogContent.Substring(0, 50).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...\r\n                    <small><a");
            BeginWriteAttribute("href", " href=\"", 764, "\"", 797, 2);
            WriteAttributeValue("", 771, "/Blog/BlogReadAll/", 771, 18, true);
#nullable restore
#line 23 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.26_BlogProject\BlogProject_UI\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 789, item.Id, 789, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-success\">Devamını Oku...</a></small>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 27 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.26_BlogProject\BlogProject_UI\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                Write(item.BlogCreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 33 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.26_BlogProject\BlogProject_UI\Views\Shared\Components\BlogLast3Post\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
