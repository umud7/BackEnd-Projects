#pragma checksum "C:\Users\user\Desktop\BackEnd-Projects\Innab\Views\Telim\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "759bad770b8d7b7d1364ee1a2d0bdb7a8d3b2f2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Telim_Index), @"mvc.1.0.view", @"/Views/Telim/Index.cshtml")]
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
#line 1 "C:\Users\user\Desktop\BackEnd-Projects\Innab\Views\_ViewImports.cshtml"
using Innab.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\BackEnd-Projects\Innab\Views\_ViewImports.cshtml"
using Innab.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\BackEnd-Projects\Innab\Views\_ViewImports.cshtml"
using Innab.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"759bad770b8d7b7d1364ee1a2d0bdb7a8d3b2f2b", @"/Views/Telim/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4caf2ea74b9ab45bff0f0b34cbf39843dc4ec35", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Telim_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\BackEnd-Projects\Innab\Views\Telim\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"banner-area\">\r\n    <h2>Təlimlər</h2>\r\n</div>\r\n\r\n<!-- Proyekt Telimler Hissesi -->\r\n<section id=\"project\">\r\n\r\n    <ul class=\"project-filter\">\r\n        <li class=\"list project-filter-active\" data-filter=\"all\">Bütün təlimlər</li>\r\n");
#nullable restore
#line 15 "C:\Users\user\Desktop\BackEnd-Projects\Innab\Views\Telim\Index.cshtml"
         foreach (var item in Model.Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list\" data-filter=\"");
#nullable restore
#line 17 "C:\Users\user\Desktop\BackEnd-Projects\Innab\Views\Telim\Index.cshtml"
                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 17 "C:\Users\user\Desktop\BackEnd-Projects\Innab\Views\Telim\Index.cshtml"
                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 18 "C:\Users\user\Desktop\BackEnd-Projects\Innab\Views\Telim\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </ul>\r\n\r\n    <div class=\"project-container\">\r\n\r\n");
#nullable restore
#line 24 "C:\Users\user\Desktop\BackEnd-Projects\Innab\Views\Telim\Index.cshtml"
        foreach (var item in Model.Telims)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 569, "\"", 576, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"project-box muhasibat\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 630, "\"", 654, 2);
            WriteAttributeValue("", 636, "img/", 636, 4, true);
#nullable restore
#line 27 "C:\Users\user\Desktop\BackEnd-Projects\Innab\Views\Telim\Index.cshtml"
WriteAttributeValue("", 640, item.ImageUrl, 640, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 655, "\"", 661, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h6>");
#nullable restore
#line 28 "C:\Users\user\Desktop\BackEnd-Projects\Innab\Views\Telim\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </a>\r\n");
#nullable restore
#line 30 "C:\Users\user\Desktop\BackEnd-Projects\Innab\Views\Telim\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</section>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
