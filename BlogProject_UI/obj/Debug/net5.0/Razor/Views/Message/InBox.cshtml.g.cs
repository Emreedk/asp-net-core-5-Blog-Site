#pragma checksum "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\Message\InBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91cf68d6c303c15d81c4cd0ac9a499f87b62ee5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_InBox), @"mvc.1.0.view", @"/Views/Message/InBox.cshtml")]
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
#line 1 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\Message\InBox.cshtml"
using BlogProject_EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91cf68d6c303c15d81c4cd0ac9a499f87b62ee5e", @"/Views/Message/InBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1831ba975c6e3e8bd8bf8b6e72a3de21cd62a9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_InBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\Message\InBox.cshtml"
  
    ViewData["Title"] = "InBox";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Gelen Kutusu</h4>
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th> # </th>
                        <th>Konu</th>
                        <th>Gönderen</th>
                        <th>Tarih</th>
                        <th></th>

                    </tr>
                </thead>
");
#nullable restore
#line 23 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\Message\InBox.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tbody>\r\n                        <tr>\r\n                            <th>");
#nullable restore
#line 27 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\Message\InBox.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 28 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\Message\InBox.cshtml"
                           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 29 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\Message\InBox.cshtml"
                           Write(item.SenderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\Message\InBox.cshtml"
                           Write(item.MessageDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1056, "\"", 1095, 2);
            WriteAttributeValue("", 1063, "/Message/MessageDetails/", 1063, 24, true);
#nullable restore
#line 31 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\Message\InBox.cshtml"
WriteAttributeValue("", 1087, item.Id, 1087, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Mesajı Aç</a></td>\r\n                        </tr>\r\n                    </tbody>\r\n");
#nullable restore
#line 34 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.02.07_BlogProject\BlogProject_UI\Views\Message\InBox.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n            <a href=\"/Blog/BlogAdd\" class=\"btn btn-success\">Yeni Mesaj Oluştur</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
