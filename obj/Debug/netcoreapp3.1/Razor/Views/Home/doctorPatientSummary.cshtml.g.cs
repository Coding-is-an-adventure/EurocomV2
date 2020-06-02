#pragma checksum "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\Home\doctorPatientSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa156b1663a78433f6b0059307895c9396256be5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_doctorPatientSummary), @"mvc.1.0.view", @"/Views/Home/doctorPatientSummary.cshtml")]
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
#line 1 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\_ViewImports.cshtml"
using EurocomV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\_ViewImports.cshtml"
using EurocomV2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa156b1663a78433f6b0059307895c9396256be5", @"/Views/Home/doctorPatientSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"563cd55ede89a1e66ddb0358f924b2bef799b290", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_doctorPatientSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\Home\doctorPatientSummary.cshtml"
  
    ViewData["Title"] = "Patient Overzicht";
    DoctorReader doctorReader = new DoctorReader();
    int UserId = 26; // input UserId
    doctorReader.Read(UserId);
    string InfoPatients = "";
    List<string> names = new List<string>(); // List with the names of the patients
    List<string> ids = doctorReader.ReadUserIds(doctorReader.ReadPatientIds(doctorReader.ConnectionString, doctorReader.Copy), doctorReader.ConnectionString); // List with the ids
    for (int i = 0; i < doctorReader.patients.Count; i++)
    {
        names.Add(doctorReader.patients[i].FirstName + " " + doctorReader.patients[i].LastName);
    }
    for (int i = 0; i < doctorReader.patients.Count; i++)
    {
        InfoPatients += doctorReader.patients[i].FirstName + " " + doctorReader.patients[i].LastName + "\n" + doctorReader.patients[i].Number + "\n------------------------------------------\n";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa156b1663a78433f6b0059307895c9396256be54606", async() => {
                WriteLiteral("\r\n        <p>");
#nullable restore
#line 20 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\Home\doctorPatientSummary.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <textarea style=\"resize:none\" readonly id=\"TextArea1\" rows=\"15\" cols=\"27\">");
#nullable restore
#line 21 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\Home\doctorPatientSummary.cshtml"
                                                                             Write(InfoPatients);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n        <div class=\"container\">\r\n            <input class=\"search-input\" type=\"text\" placeholder=\"Search here...\" />\r\n            <div class=\"suggestions\">\r\n");
#nullable restore
#line 25 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\Home\doctorPatientSummary.cshtml"
                 for (int i = 0; i < names.Count; i++)
                 {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a");
                BeginWriteAttribute("href", " href=", 1352, "", 1365, 1);
#nullable restore
#line 27 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\Home\doctorPatientSummary.cshtml"
WriteAttributeValue("", 1358, ids[i], 1358, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><div>");
#nullable restore
#line 27 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\Home\doctorPatientSummary.cshtml"
                                    Write(names[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div></a>\r\n");
#nullable restore
#line 28 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\Home\doctorPatientSummary.cshtml"
                 } 

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </div>\r\n    ");
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
            WriteLiteral("\r\n\r\n    <script type=\"text/javascript\" language=\"javascript\">\r\n        const Patienten = [];\r\n\r\n        var arr = JSON.parse(\'");
#nullable restore
#line 36 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\Home\doctorPatientSummary.cshtml"
                         Write(Html.Raw(Json.Serialize(names)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n        var arrid = JSON.parse(\'");
#nullable restore
#line 37 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\Home\doctorPatientSummary.cshtml"
                           Write(Html.Raw(Json.Serialize(ids)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n        \r\n\r\n        for (var i = 0; i < ");
#nullable restore
#line 40 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\Home\doctorPatientSummary.cshtml"
                       Write(doctorReader.patients.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"; i++) {
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
            a.setAttribute(""href"", suggested.value);
            a.appendChild(div);
            Uberdiv.appendChild(a);
            suggestionsPanel.appendChild(Uberdiv);
        });
    })
    </script>");
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
