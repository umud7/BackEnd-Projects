#pragma checksum "C:\Users\user\source\repos\EduTech2\EduTech2\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "942ad82d4a12e80c15adcccfa1e6f6c72b31741f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\user\source\repos\EduTech2\EduTech2\Views\_ViewImports.cshtml"
using EduTech2.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\EduTech2\EduTech2\Views\_ViewImports.cshtml"
using EduTech2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\EduTech2\EduTech2\Views\_ViewImports.cshtml"
using EduTech2.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"942ad82d4a12e80c15adcccfa1e6f6c72b31741f", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e56ad95b42e98113eaf48bc9042201b4ef024c20", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\source\repos\EduTech2\EduTech2\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"about-home\">\r\n    <h2>About TechEduca /</h2>\r\n</section>\r\n\r\n<section id=\"about-container\">\r\n    <div class=\"about-img\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "942ad82d4a12e80c15adcccfa1e6f6c72b31741f3986", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 210, "~/images/", 210, 9, true);
#nullable restore
#line 12 "C:\Users\user\source\repos\EduTech2\EduTech2\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 219, Model.AboutUs.ImageUrl1, 219, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"about-text\">\r\n        <h2>\r\n            ");
#nullable restore
#line 16 "C:\Users\user\source\repos\EduTech2\EduTech2\Views\About\Index.cshtml"
       Write(Model.AboutUs.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h2>\r\n        <p>\r\n            ");
#nullable restore
#line 19 "C:\Users\user\source\repos\EduTech2\EduTech2\Views\About\Index.cshtml"
       Write(Model.AboutUs.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <div class=\"about-fe\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "942ad82d4a12e80c15adcccfa1e6f6c72b31741f6173", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 474, "~/images/", 474, 9, true);
#nullable restore
#line 22 "C:\Users\user\source\repos\EduTech2\EduTech2\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 483, Model.AboutUs.ImageUrl2, 483, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"fe-text\">\r\n                <h5>");
#nullable restore
#line 24 "C:\Users\user\source\repos\EduTech2\EduTech2\Views\About\Index.cshtml"
               Write(Model.AboutUs.CourseCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p>\r\n                    ");
#nullable restore
#line 26 "C:\Users\user\source\repos\EduTech2\EduTech2\Views\About\Index.cshtml"
               Write(Model.AboutUs.CourseDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n        <div class=\"about-fe\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "942ad82d4a12e80c15adcccfa1e6f6c72b31741f8424", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 788, "~/images/", 788, 9, true);
#nullable restore
#line 31 "C:\Users\user\source\repos\EduTech2\EduTech2\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 797, Model.AboutUs.ImageUrl3, 797, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"fe-text\">\r\n                <h5>");
#nullable restore
#line 33 "C:\Users\user\source\repos\EduTech2\EduTech2\Views\About\Index.cshtml"
               Write(Model.AboutUs.LifeTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p>\r\n                    ");
#nullable restore
#line 35 "C:\Users\user\source\repos\EduTech2\EduTech2\Views\About\Index.cshtml"
               Write(Model.AboutUs.LifeTimeDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
            </div>
        </div>
    </div>
</section>

<!-- features -->
<section id=""features"">
    <h1>Awesome Features</h1>
    <p>Replenish man have thing gathering lights yielding shall you</p>
    <div class=""fea-base"">
        <div class=""fea-box"">
            <i class=""fa-solid fa-graduation-cap""></i>
            <h3>Shcolarship Facility</h3>
            <p>
                One make creepeth, man bearing theira firmament won't great heaven
            </p>
        </div>
        <div class=""fea-box"">
            <i class=""fa-solid fa-award""></i>
            <h3>Dell Online Courses</h3>
            <p>
                One make creepeth, man bearing theira firmament won't great heaven
            </p>
        </div>
        <div class=""fea-box"">
            <i class=""fa-solid fa-award""></i>
            <h3>Global certification</h3>
            <p>
                One make creepeth, man bearing theira firmament won't great heaven
            </p>
  ");
            WriteLiteral("      </div>\r\n    </div>\r\n</section>\r\n\r\n<section id=\"trust\">\r\n    <h1>Trusted By</h1>\r\n    <p>Replenish man have thing gathering lights yielding shall you</p>\r\n    <div class=\"trust-img\">\r\n");
#nullable restore
#line 75 "C:\Users\user\source\repos\EduTech2\EduTech2\Views\About\Index.cshtml"
         foreach (var item in Model.TrustedBies)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "942ad82d4a12e80c15adcccfa1e6f6c72b31741f12092", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2281, "~/images/", 2281, 9, true);
#nullable restore
#line 77 "C:\Users\user\source\repos\EduTech2\EduTech2\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 2290, item.ImageUrl, 2290, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 78 "C:\Users\user\source\repos\EduTech2\EduTech2\Views\About\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n\r\n");
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
