#pragma checksum "F:\RenseGit\Eurocom\Views\Home\Status.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf9eb3456e9f396aca41676f3cc579dd07bbc02d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Status), @"mvc.1.0.view", @"/Views/Home/Status.cshtml")]
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
#line 1 "F:\RenseGit\Eurocom\Views\_ViewImports.cshtml"
using EurocomV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\RenseGit\Eurocom\Views\_ViewImports.cshtml"
using EurocomV2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\RenseGit\Eurocom\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf9eb3456e9f396aca41676f3cc579dd07bbc02d", @"/Views/Home/Status.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aab1f4d1d05d5e26acf194c03e6e93b22f616065", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Status : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background: #9fdefa"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\RenseGit\Eurocom\Views\Home\Status.cshtml"
  
    ViewData["Title"] = "Status";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf9eb3456e9f396aca41676f3cc579dd07bbc02d3700", async() => {
                WriteLiteral("\r\n        <div class=\"Head\">Status</div>\r\n        <div class=\"Head2\">Mvr. de Vries<br /><br /><br /></div>\r\n        <div class=\"row\">\r\n            <div class=\"col-4 Textvlak\" style=\"text-align:center;\">\r\n                INR ");
#nullable restore
#line 12 "F:\RenseGit\Eurocom\Views\Home\Status.cshtml"
               Write(TempData["INR"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n");
#nullable restore
#line 13 "F:\RenseGit\Eurocom\Views\Home\Status.cshtml"
         switch (TempData["Statusicon"])
        {
            case "Perfect":

#line default
#line hidden
#nullable disable
                WriteLiteral("                <span class=\"glyphicon glyphicon-ok-sign\"></span>\r\n");
#nullable restore
#line 17 "F:\RenseGit\Eurocom\Views\Home\Status.cshtml"
                break;
            case "Goed":

#line default
#line hidden
#nullable disable
                WriteLiteral("                <span class=\"glyphicon glyphicon-minus-sign\"></span>\r\n");
#nullable restore
#line 20 "F:\RenseGit\Eurocom\Views\Home\Status.cshtml"
                break;
            case "Slecht":

#line default
#line hidden
#nullable disable
                WriteLiteral("                <span class=\"glyphicon glyphicon-remove-sign\"></span>\r\n");
#nullable restore
#line 23 "F:\RenseGit\Eurocom\Views\Home\Status.cshtml"
                break;
            default:
                break;
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n            <div class=\"col-1\">\r\n            </div>\r\n            <div class=\"col-7 Textvlak2\" style=\"text-align:center;\">\r\n                ");
#nullable restore
#line 31 "F:\RenseGit\Eurocom\Views\Home\Status.cshtml"
           Write(ViewBag.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
