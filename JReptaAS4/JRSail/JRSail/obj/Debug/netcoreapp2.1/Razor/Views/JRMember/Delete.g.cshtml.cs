#pragma checksum "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bde33975760599a48d8bd0f0b9f528cf7dadddcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JRMember_Delete), @"mvc.1.0.view", @"/Views/JRMember/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/JRMember/Delete.cshtml", typeof(AspNetCore.Views_JRMember_Delete))]
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
#line 1 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\_ViewImports.cshtml"
using JRSail;

#line default
#line hidden
#line 2 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\_ViewImports.cshtml"
using JRSail.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bde33975760599a48d8bd0f0b9f528cf7dadddcc", @"/Views/JRMember/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"470cd81089aa75a1651402e60f78c103e8ba8a92", @"/Views/_ViewImports.cshtml")]
    public class Views_JRMember_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JRSail.Models.Member>
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
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
  
    ViewData["Title"] = $"Delete member {ViewBag.memberFullName}";

#line default
#line hidden
            BeginContext(106, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(113, 17, false);
#line 7 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(130, 155, true);
            WriteLiteral("</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Member</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(286, 44, false);
#line 15 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(330, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(374, 40, false);
#line 18 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(414, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(458, 45, false);
#line 21 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(503, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(547, 41, false);
#line 24 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(588, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(632, 44, false);
#line 27 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(676, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(720, 40, false);
#line 30 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(760, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(804, 51, false);
#line 33 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SpouseFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(855, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(899, 47, false);
#line 36 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SpouseFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(946, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(990, 50, false);
#line 39 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SpouseLastName));

#line default
#line hidden
            EndContext();
            BeginContext(1040, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1084, 46, false);
#line 42 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SpouseLastName));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1174, 42, false);
#line 45 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Street));

#line default
#line hidden
            EndContext();
            BeginContext(1216, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1260, 38, false);
#line 48 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Street));

#line default
#line hidden
            EndContext();
            BeginContext(1298, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1342, 40, false);
#line 51 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1426, 36, false);
#line 54 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1462, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1506, 46, false);
#line 57 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1552, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1596, 42, false);
#line 60 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1638, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1682, 45, false);
#line 63 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1727, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1771, 41, false);
#line 66 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1812, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1856, 41, false);
#line 69 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1897, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1941, 37, false);
#line 72 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1978, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2022, 46, false);
#line 75 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.YearJoined));

#line default
#line hidden
            EndContext();
            BeginContext(2068, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2112, 42, false);
#line 78 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.YearJoined));

#line default
#line hidden
            EndContext();
            BeginContext(2154, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2198, 43, false);
#line 81 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(2241, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2285, 39, false);
#line 84 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(2324, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2368, 46, false);
#line 87 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TaskExempt));

#line default
#line hidden
            EndContext();
            BeginContext(2414, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2458, 42, false);
#line 90 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TaskExempt));

#line default
#line hidden
            EndContext();
            BeginContext(2500, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2544, 49, false);
#line 93 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UseCanadaPost));

#line default
#line hidden
            EndContext();
            BeginContext(2593, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2637, 45, false);
#line 96 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UseCanadaPost));

#line default
#line hidden
            EndContext();
            BeginContext(2682, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2726, 58, false);
#line 99 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProvinceCodeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2784, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2828, 67, false);
#line 102 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProvinceCodeNavigation.ProvinceCode));

#line default
#line hidden
            EndContext();
            BeginContext(2895, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2933, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc02198c525448fdb179cabd7d6bc76e", async() => {
                BeginContext(2959, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2969, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1df524b259b141f6927999d225a0ec23", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 107 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRMember\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MemberId);

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
                BeginContext(3011, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(3095, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2fc81f28a9c446da4d2473c9fec9ca6", async() => {
                    BeginContext(3117, 12, true);
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
                BeginContext(3133, 6, true);
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
            BeginContext(3146, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JRSail.Models.Member> Html { get; private set; }
    }
}
#pragma warning restore 1591
