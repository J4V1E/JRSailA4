#pragma checksum "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRBoat\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "692dd69e4ce8cd1d6ddf5adcfb1f7dfd22837d65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JRBoat_Delete), @"mvc.1.0.view", @"/Views/JRBoat/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/JRBoat/Delete.cshtml", typeof(AspNetCore.Views_JRBoat_Delete))]
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
#line 1 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\_ViewImports.cshtml"
using JRSail;

#line default
#line hidden
#line 2 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\_ViewImports.cshtml"
using JRSail.Models;

#line default
#line hidden
#line 2 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRBoat\Delete.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"692dd69e4ce8cd1d6ddf5adcfb1f7dfd22837d65", @"/Views/JRBoat/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"470cd81089aa75a1651402e60f78c103e8ba8a92", @"/Views/_ViewImports.cshtml")]
    public class Views_JRBoat_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JRSail.Models.Boat>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRBoat\Delete.cshtml"
  
    ViewData["Title"] = $"Delete boat from {Context.Session.GetString("FullName")}";

#line default
#line hidden
            BeginContext(154, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(161, 13, false);
#line 7 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRBoat\Delete.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(174, 153, true);
            WriteLiteral("</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Boat</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(328, 45, false);
#line 15 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRBoat\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BoatClass));

#line default
#line hidden
            EndContext();
            BeginContext(373, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(417, 41, false);
#line 18 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRBoat\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BoatClass));

#line default
#line hidden
            EndContext();
            BeginContext(458, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(502, 46, false);
#line 21 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRBoat\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HullColour));

#line default
#line hidden
            EndContext();
            BeginContext(548, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(592, 42, false);
#line 24 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRBoat\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HullColour));

#line default
#line hidden
            EndContext();
            BeginContext(634, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(678, 46, false);
#line 27 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRBoat\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SailNumber));

#line default
#line hidden
            EndContext();
            BeginContext(724, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(768, 42, false);
#line 30 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRBoat\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SailNumber));

#line default
#line hidden
            EndContext();
            BeginContext(810, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(854, 46, false);
#line 33 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRBoat\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HullLength));

#line default
#line hidden
            EndContext();
            BeginContext(900, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(944, 42, false);
#line 36 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRBoat\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HullLength));

#line default
#line hidden
            EndContext();
            BeginContext(986, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1030, 44, false);
#line 39 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRBoat\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BoatType));

#line default
#line hidden
            EndContext();
            BeginContext(1074, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1118, 45, false);
#line 42 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRBoat\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BoatType.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1163, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1207, 42, false);
#line 45 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRBoat\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Member));

#line default
#line hidden
            EndContext();
            BeginContext(1249, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1293, 48, false);
#line 48 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRBoat\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Member.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1341, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1385, 57, false);
#line 51 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRBoat\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ParkingCodeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1442, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1486, 65, false);
#line 54 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRBoat\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ParkingCodeNavigation.ParkingCode));

#line default
#line hidden
            EndContext();
            BeginContext(1551, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1589, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe4d22cb116f48eba43d9eefc84f1278", async() => {
                BeginContext(1615, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1625, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01a9f76ce4d84ce7ba18e815e5ce71b6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 59 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRBoat\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BoatId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1665, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1749, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2a15721b4534fd5a83d10014eebfe53", async() => {
                    BeginContext(1771, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1787, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1800, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JRSail.Models.Boat> Html { get; private set; }
    }
}
#pragma warning restore 1591
