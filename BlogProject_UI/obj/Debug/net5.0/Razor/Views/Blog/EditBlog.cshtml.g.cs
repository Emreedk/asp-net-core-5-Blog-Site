#pragma checksum "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.17_BlogProject\BlogProject_UI\Views\Blog\EditBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efcf71f1d565bdc34b96c1cfe3e451b1e58ae2e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_EditBlog), @"mvc.1.0.view", @"/Views/Blog/EditBlog.cshtml")]
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
#line 1 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.17_BlogProject\BlogProject_UI\Views\_ViewImports.cshtml"
using BlogProject_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.17_BlogProject\BlogProject_UI\Views\_ViewImports.cshtml"
using BlogProject_UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efcf71f1d565bdc34b96c1cfe3e451b1e58ae2e9", @"/Views/Blog/EditBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1831ba975c6e3e8bd8bf8b6e72a3de21cd62a9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_EditBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogProject_EntityLayer.Concrete.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.17_BlogProject\BlogProject_UI\Views\Blog\EditBlog.cshtml"
  
    ViewData["Title"] = "EditBlog";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Blog Düzenleme</h1>\r\n");
#nullable restore
#line 8 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.17_BlogProject\BlogProject_UI\Views\Blog\EditBlog.cshtml"
 using (Html.BeginForm("EditBlog", "Blog", FormMethod.Post))
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.17_BlogProject\BlogProject_UI\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Id"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.17_BlogProject\BlogProject_UI\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.Id, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.17_BlogProject\BlogProject_UI\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.17_BlogProject\BlogProject_UI\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.17_BlogProject\BlogProject_UI\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Thumbnail"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.17_BlogProject\BlogProject_UI\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogThumbnailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 20 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.17_BlogProject\BlogProject_UI\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Görseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.17_BlogProject\BlogProject_UI\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 23 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.17_BlogProject\BlogProject_UI\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.17_BlogProject\BlogProject_UI\Views\Blog\EditBlog.cshtml"
Write(Html.DropDownListFor(x => x.CategoryId, (List<SelectListItem>)ViewBag.categoryValues, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 26 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.17_BlogProject\BlogProject_UI\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog İçeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.17_BlogProject\BlogProject_UI\Views\Blog\EditBlog.cshtml"
Write(Html.TextAreaFor(x => x.BlogContent, 7, 10, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Güncelle</button>\r\n");
#nullable restore
#line 30 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.17_BlogProject\BlogProject_UI\Views\Blog\EditBlog.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogProject_EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591