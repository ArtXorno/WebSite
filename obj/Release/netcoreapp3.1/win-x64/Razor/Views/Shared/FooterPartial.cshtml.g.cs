#pragma checksum "C:\Users\Xorno\Desktop\ArtXornoSite\Views\Shared\FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aeb110b2dfc7572eacc2d213045700c804def917"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_FooterPartial), @"mvc.1.0.view", @"/Views/Shared/FooterPartial.cshtml")]
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
#line 2 "C:\Users\Xorno\Desktop\ArtXornoSite\Views\_ViewImports.cshtml"
using ArtXornoSite.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Xorno\Desktop\ArtXornoSite\Views\_ViewImports.cshtml"
using ArtXornoSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Xorno\Desktop\ArtXornoSite\Views\_ViewImports.cshtml"
using ArtXornoSite.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Xorno\Desktop\ArtXornoSite\Views\_ViewImports.cshtml"
using ArtXornoSite.Models.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aeb110b2dfc7572eacc2d213045700c804def917", @"/Views/Shared/FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af8a6a6112cb5f0133133a14efe54a64e01f6ff7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div id=\"footer-wrapper\">\r\n    <div class=\"container\">    \r\n       <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <div id=\"copyright\">\r\n                    &copy; ");
#nullable restore
#line 6 "C:\Users\Xorno\Desktop\ArtXornoSite\Views\Shared\FooterPartial.cshtml"
                      Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(". All rights reserved. | Design: <a href=\"http://html5up.net\">HTML5 UP</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
