#pragma checksum "C:\Users\recep\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e71a55100eb1b6495cffae70bc7bfc997ef45644"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\recep\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\recep\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\recep\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e71a55100eb1b6495cffae70bc7bfc997ef45644", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca0fc599d5f51e519f75ff6712b592ffabce4a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\recep\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Blog Posts</h3>
        <div class=""inner-sec"">
            <!--left-->
            <div class=""left-blog-info-w3layouts-agileits text-left"">
                <div class=""row"">
");
#nullable restore
#line 15 "C:\Users\recep\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                     foreach (var item in Model)
                    {
                       

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 card\">\r\n                            <a href=\"single.html\">\r\n                                <img src=\"/web/images/1.jpg\" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 725, "\"", 731, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""card-body"">
                                <ul class=""blog-icons my-4"">
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 26 "C:\Users\recep\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                                            Write(((DateTime)item.BlogCreateDate).ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </li>
                                    <li class=""mx-2"">
                                        <a href=""#"">
                                            <i class=""far fa-comment""></i> 0
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""fas fa-eye""></i> ");
#nullable restore
#line 36 "C:\Users\recep\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                                  Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n\r\n                                </ul>\r\n                                <h5 class=\"card-title\">\r\n                                    <a href=\"single.html\">");
#nullable restore
#line 42 "C:\Users\recep\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                     Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h5>\r\n                                <p class=\"card-text mb-3\">");
#nullable restore
#line 44 "C:\Users\recep\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                     Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,120).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2168, "\"", 2205, 2);
            WriteAttributeValue("", 2175, "/Blog/BlogDetails/", 2175, 18, true);
#nullable restore
#line 45 "C:\Users\recep\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2193, item.BlogID, 2193, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Read More</a>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 48 "C:\Users\recep\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n\r\n                </div>\r\n                <!--//left-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
