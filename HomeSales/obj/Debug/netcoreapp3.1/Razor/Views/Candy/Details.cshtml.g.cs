#pragma checksum "C:\Users\Jakub\source\repos\HomeSales\HomeSales\Views\Candy\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "190c0b082959540975ed4f188ec9d1d5e1f55b98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candy_Details), @"mvc.1.0.view", @"/Views/Candy/Details.cshtml")]
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
#line 1 "C:\Users\Jakub\source\repos\HomeSales\HomeSales\Views\_ViewImports.cshtml"
using HomeSales.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jakub\source\repos\HomeSales\HomeSales\Views\_ViewImports.cshtml"
using HomeSales.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"190c0b082959540975ed4f188ec9d1d5e1f55b98", @"/Views/Candy/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25c8d17420d6a91758775396a43bcc317abacc87", @"/Views/_ViewImports.cshtml")]
    public class Views_Candy_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Candy>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jakub\source\repos\HomeSales\HomeSales\Views\Candy\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\Jakub\source\repos\HomeSales\HomeSales\Views\Candy\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"thumbnail\">\r\n    <img");
            BeginWriteAttribute("alt", " alt=\"", 118, "\"", 135, 1);
#nullable restore
#line 10 "C:\Users\Jakub\source\repos\HomeSales\HomeSales\Views\Candy\Details.cshtml"
WriteAttributeValue("", 124, Model.Name, 124, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 136, "\"", 157, 1);
#nullable restore
#line 10 "C:\Users\Jakub\source\repos\HomeSales\HomeSales\Views\Candy\Details.cshtml"
WriteAttributeValue("", 142, Model.ImageUrl, 142, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 171, "\"", 179, 0);
            EndWriteAttribute();
            WriteLiteral("caption-full\">\r\n        <h3 class=\"pull-right\">");
#nullable restore
#line 12 "C:\Users\Jakub\source\repos\HomeSales\HomeSales\Views\Candy\Details.cshtml"
                          Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h3><a href=\"#\">");
#nullable restore
#line 13 "C:\Users\Jakub\source\repos\HomeSales\HomeSales\Views\Candy\Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n        <p>");
#nullable restore
#line 14 "C:\Users\Jakub\source\repos\HomeSales\HomeSales\Views\Candy\Details.cshtml"
      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Candy> Html { get; private set; }
    }
}
#pragma warning restore 1591
