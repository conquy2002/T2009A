#pragma checksum "C:\Users\dong\Desktop\T2009A\WebMCVBook\Đông\WebMVCBook\WebMVCBook\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d767de3819dd2346ace1922a89b1c7e6fc06fa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\dong\Desktop\T2009A\WebMCVBook\Đông\WebMVCBook\WebMVCBook\Views\_ViewImports.cshtml"
using WebMVCBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dong\Desktop\T2009A\WebMCVBook\Đông\WebMVCBook\WebMVCBook\Views\_ViewImports.cshtml"
using WebMVCBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d767de3819dd2346ace1922a89b1c7e6fc06fa9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97a7f890afbe734783f06bd1d084288bf01d526f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebMVCBook.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\dong\Desktop\T2009A\WebMCVBook\Đông\WebMVCBook\WebMVCBook\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Sách Store";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>
<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.4.0/font/bootstrap-icons.css"">
<style>
    .child-item-bottom {
        background-color: rgb(81, 81, 82, 0.8);
        color: white;
        bottom: 0px;
        right: 20px;
        padding: 3px;
        position: absolute;
    }

    .child-item-top {
        background-color: rgb(81, 81, 82, 0.8);
        color: white;
        width: 100% !important;
        text-align: center;
        padding: 3px;
    }
    .title {
        background-color: grey;
        width: 100%;
        text-align: center;
        font-weight: bold;
       ");
            WriteLiteral(@" color: white;
        padding: 5px;
        margin-bottom: 2px !important;
        margin-top: 10px;
    }
    .thumbnail {
        width: 100%;
        height: 220px;
        background-size: cover;
        background-repeat: no-repeat;
       
    }
    .col-md-3{
        margin-top: 20px;
    }
</style>

<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <div class=""row"">
");
#nullable restore
#line 52 "C:\Users\dong\Desktop\T2009A\WebMCVBook\Đông\WebMVCBook\WebMVCBook\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3\">\r\n                <p class=\"title\">");
#nullable restore
#line 55 "C:\Users\dong\Desktop\T2009A\WebMCVBook\Đông\WebMVCBook\WebMVCBook\Views\Home\Index.cshtml"
                            Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"thumbnail\"");
            BeginWriteAttribute("style", " style=\"", 1733, "\"", 1774, 4);
            WriteAttributeValue("", 1741, "background-image:", 1741, 17, true);
            WriteAttributeValue(" ", 1758, "url(", 1759, 5, true);
#nullable restore
#line 56 "C:\Users\dong\Desktop\T2009A\WebMCVBook\Đông\WebMVCBook\WebMVCBook\Views\Home\Index.cshtml"
WriteAttributeValue("", 1763, item.Img, 1763, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1772, ");", 1772, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <label class=\"child-item-top\">");
#nullable restore
#line 57 "C:\Users\dong\Desktop\T2009A\WebMCVBook\Đông\WebMVCBook\WebMVCBook\Views\Home\Index.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <label class=\"child-item-bottom\">");
#nullable restore
#line 58 "C:\Users\dong\Desktop\T2009A\WebMCVBook\Đông\WebMVCBook\WebMVCBook\Views\Home\Index.cshtml"
                                                Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 61 "C:\Users\dong\Desktop\T2009A\WebMCVBook\Đông\WebMVCBook\WebMVCBook\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebMVCBook.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
