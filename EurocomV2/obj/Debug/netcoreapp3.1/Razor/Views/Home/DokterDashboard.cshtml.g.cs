#pragma checksum "C:\Users\Julia\Documents\GitHub\EurocomV2\EurocomV2\Views\Home\DokterDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f2acbc7162e225635108b345498bc9d0bf1fef7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DokterDashboard), @"mvc.1.0.view", @"/Views/Home/DokterDashboard.cshtml")]
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
#line 1 "C:\Users\Julia\Documents\GitHub\EurocomV2\EurocomV2\Views\_ViewImports.cshtml"
using EurocomV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Julia\Documents\GitHub\EurocomV2\EurocomV2\Views\_ViewImports.cshtml"
using EurocomV2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Julia\Documents\GitHub\EurocomV2\EurocomV2\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f2acbc7162e225635108b345498bc9d0bf1fef7", @"/Views/Home/DokterDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aab1f4d1d05d5e26acf194c03e6e93b22f616065", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DokterDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EurocomV2.ViewModels.patientenviewmodel>
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
#nullable restore
#line 2 "C:\Users\Julia\Documents\GitHub\EurocomV2\EurocomV2\Views\Home\DokterDashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f2acbc7162e225635108b345498bc9d0bf1fef73906", async() => {
                WriteLiteral(@"
    <div class=""Head"">Welkom, Dr de Laat</div>
    <div class=""container"">
        <div class=""row"">
            <div><br /><br /></div>
            <div class=""col-xl-6 col-12 w-100"" style=""height:25rem;"">
                <div class=""w-100 Privacytext"" style=""height:3rem"">Meldingen</div>
                <div class=""col-12 Privacytext w-100"" style=""height:22rem"">
                    <div>
");
                WriteLiteral(@"                    </div>
                </div>
            </div>
            <div class=""col-12 d-xl-none"" style=""height:60px;""></div>
            <div class=""col-xl-5 col-12"" style=""text-align:center; height:25rem;"">
                <div class=""w-100 Privacytext"" style=""height:3rem"">Patienten</div>
                <input type=""text"" class=""w-100 search-input"" style=""height:2rem; border-style:solid; border-color:white;"" placeholder=""Zoek hier..."" />
                <div class=""list-group w-100 Privacytext suggestions"" style=""overflow-y:scroll; height:17.5rem;"">
");
#nullable restore
#line 30 "C:\Users\Julia\Documents\GitHub\EurocomV2\EurocomV2\Views\Home\DokterDashboard.cshtml"
                     foreach (EurocomV2.Models.Classes.patient patient in Model.patienten)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"searchresults\"><a style=\"color:white;\"");
                BeginWriteAttribute("href", " href=", 1585, "", 1606, 1);
#nullable restore
#line 32 "C:\Users\Julia\Documents\GitHub\EurocomV2\EurocomV2\Views\Home\DokterDashboard.cshtml"
WriteAttributeValue("", 1591, patient.Number, 1591, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><div>");
#nullable restore
#line 32 "C:\Users\Julia\Documents\GitHub\EurocomV2\EurocomV2\Views\Home\DokterDashboard.cshtml"
                                                                                                Write(patient.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div></a></div>\r\n");
#nullable restore
#line 33 "C:\Users\Julia\Documents\GitHub\EurocomV2\EurocomV2\Views\Home\DokterDashboard.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                <button class=\"btn btn-primary w-100\" style=\"height:2.5rem\">Create patient</button>\r\n            </div>\r\n            <div class=\"col-12\" style=\"height:60px\"></div>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n\r\n<script type=\"text/javascript\" language=\"javascript\">\r\n    const Patienten = [\r\n    ];\r\n    var count = ");
#nullable restore
#line 45 "C:\Users\Julia\Documents\GitHub\EurocomV2\EurocomV2\Views\Home\DokterDashboard.cshtml"
           Write(Model.patienten.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var arr = JSON.parse(\'");
#nullable restore
#line 46 "C:\Users\Julia\Documents\GitHub\EurocomV2\EurocomV2\Views\Home\DokterDashboard.cshtml"
                     Write(Html.Raw(Json.Serialize(@Model.Namen)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n    var arrid = JSON.parse(\'");
#nullable restore
#line 47 "C:\Users\Julia\Documents\GitHub\EurocomV2\EurocomV2\Views\Home\DokterDashboard.cshtml"
                       Write(Html.Raw(Json.Serialize(@Model.ids)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');

    for (var i = 0; i < count; i++) {
        Patienten.push({ name: arr[i], value: arrid[i] });
    }
    const searchInput = document.querySelector('.search-input');
    const suggestionsPanel = document.querySelector('.suggestions');


    searchInput.addEventListener('keyup', function () {
        const input = searchInput.value;
        suggestionsPanel.innerHTML = '';
        const suggestions = Patienten.filter(function (patient) {
            return patient.name.toLowerCase().startsWith(input);
        });
        suggestions.forEach(function (suggested) {
            const Uberdiv = document.createElement('div');
            const a = document.createElement('a');
            const div = document.createElement('div');
            div.innerHTML = suggested.name;
            a.setAttribute(""Asp-Action"", ""Overview_Start"");
            a.setAttribute(""Asp-Route-ID"", suggested.value);
            a.setAttribute(""style"", ""color:white;"");
            a.appendChild(div);
         ");
            WriteLiteral("   Uberdiv.setAttribute(\"class\", \"searchresults\")\r\n            Uberdiv.appendChild(a);\r\n            suggestionsPanel.appendChild(Uberdiv);\r\n        });\r\n    })\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EurocomV2.ViewModels.patientenviewmodel> Html { get; private set; }
    }
}
#pragma warning restore 1591