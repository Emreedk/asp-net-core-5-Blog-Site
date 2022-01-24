#pragma checksum "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.24_BlogProject\BlogProject_UI\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0b6cf35e54739025992b03b5255a95be811916b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#line 1 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.24_BlogProject\BlogProject_UI\Views\_ViewImports.cshtml"
using BlogProject_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.24_BlogProject\BlogProject_UI\Views\_ViewImports.cshtml"
using BlogProject_UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.24_BlogProject\BlogProject_UI\Views\Blog\BlogListByWriter.cshtml"
using BlogProject_EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0b6cf35e54739025992b03b5255a95be811916b", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1831ba975c6e3e8bd8bf8b6e72a3de21cd62a9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.24_BlogProject\BlogProject_UI\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BlogListByWriter";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Yazarın Blogları</h4>
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th> # </th>
                        <th>Blog Başlığı</th>
                        <th>Oluşturma Tarihi</th>
                        <th>Kategori</th>
                        <th>Durum</th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
");
#nullable restore
#line 24 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.24_BlogProject\BlogProject_UI\Views\Blog\BlogListByWriter.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tbody>\r\n                        <tr>\r\n                            <th>");
#nullable restore
#line 28 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.24_BlogProject\BlogProject_UI\Views\Blog\BlogListByWriter.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 29 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.24_BlogProject\BlogProject_UI\Views\Blog\BlogListByWriter.cshtml"
                           Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.24_BlogProject\BlogProject_UI\Views\Blog\BlogListByWriter.cshtml"
                           Write(item.BlogCreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 31 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.24_BlogProject\BlogProject_UI\Views\Blog\BlogListByWriter.cshtml"
                           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 33 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.24_BlogProject\BlogProject_UI\Views\Blog\BlogListByWriter.cshtml"
                                 if (item.BlogStatus)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-success\">Aktif</span>\r\n");
#nullable restore
#line 36 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.24_BlogProject\BlogProject_UI\Views\Blog\BlogListByWriter.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-secondary\">Pasif</span>\r\n");
#nullable restore
#line 40 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.24_BlogProject\BlogProject_UI\Views\Blog\BlogListByWriter.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1650, "\"", 1682, 2);
            WriteAttributeValue("", 1657, "/Blog/DeleteBlog/", 1657, 17, true);
#nullable restore
#line 42 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.24_BlogProject\BlogProject_UI\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 1674, item.Id, 1674, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1755, "\"", 1785, 2);
            WriteAttributeValue("", 1762, "/Blog/EditBlog/", 1762, 15, true);
#nullable restore
#line 43 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.24_BlogProject\BlogProject_UI\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 1777, item.Id, 1777, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Düzenle</a></td>\r\n                        </tr>\r\n                    </tbody>\r\n");
#nullable restore
#line 46 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.24_BlogProject\BlogProject_UI\Views\Blog\BlogListByWriter.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n            <a href=\"/Blog/BlogAdd\" class=\"btn btn-success\">Yeni Blog Oluştur</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
