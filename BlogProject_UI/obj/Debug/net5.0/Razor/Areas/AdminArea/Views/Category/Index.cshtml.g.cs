#pragma checksum "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Areas\AdminArea\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f51d403843d972e3d1a7b8d34e58bbaa5d6c38a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_Category_Index), @"mvc.1.0.view", @"/Areas/AdminArea/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Areas\AdminArea\Views\Category\Index.cshtml"
using BlogProject_EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Areas\AdminArea\Views\Category\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Areas\AdminArea\Views\Category\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f51d403843d972e3d1a7b8d34e58bbaa5d6c38a8", @"/Areas/AdminArea/Views/Category/Index.cshtml")]
    public class Areas_AdminArea_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Areas\AdminArea\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Kategori Adı</th>\r\n        <th>Pasif Yap</th>\r\n        <th>Aktif Yap</th>\r\n        <th>Düzenle</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Areas\AdminArea\Views\Category\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Areas\AdminArea\Views\Category\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Areas\AdminArea\Views\Category\Index.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-danger\">Pasif Yap</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-success\">Aktif Yap</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-warning\">Düzenle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 26 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Areas\AdminArea\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br />\r\n");
#nullable restore
#line 29 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Areas\AdminArea\Views\Category\Index.cshtml"
 if (Model.Count <= 3)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Areas\AdminArea\Views\Category\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Areas\AdminArea\Views\Category\Index.cshtml"
                                                                                      
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
