#pragma checksum "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c764a1bbd78dff34616797f55d1f45eaad0c79e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JRAnnualFeeStructure_Delete), @"mvc.1.0.view", @"/Views/JRAnnualFeeStructure/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/JRAnnualFeeStructure/Delete.cshtml", typeof(AspNetCore.Views_JRAnnualFeeStructure_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c764a1bbd78dff34616797f55d1f45eaad0c79e", @"/Views/JRAnnualFeeStructure/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"470cd81089aa75a1651402e60f78c103e8ba8a92", @"/Views/_ViewImports.cshtml")]
    public class Views_JRAnnualFeeStructure_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JRSail.Models.AnnualFeeStructure>
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
  
    ViewData["Title"] = "Delete Annual Fee Structure";

#line default
#line hidden
            BeginContext(106, 200, true);
            WriteLiteral("\r\n<h2>Delete Annual Fee Structure</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>AnnualFeeStructure</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(307, 45, false);
#line 15 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AnnualFee));

#line default
#line hidden
            EndContext();
            BeginContext(352, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(396, 41, false);
#line 18 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AnnualFee));

#line default
#line hidden
            EndContext();
            BeginContext(437, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(481, 54, false);
#line 21 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EarlyDiscountedFee));

#line default
#line hidden
            EndContext();
            BeginContext(535, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(579, 50, false);
#line 24 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EarlyDiscountedFee));

#line default
#line hidden
            EndContext();
            BeginContext(629, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(673, 56, false);
#line 27 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EarlyDiscountEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(729, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(773, 52, false);
#line 30 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EarlyDiscountEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(825, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(869, 53, false);
#line 33 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RenewDeadlineDate));

#line default
#line hidden
            EndContext();
            BeginContext(922, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(966, 49, false);
#line 36 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RenewDeadlineDate));

#line default
#line hidden
            EndContext();
            BeginContext(1015, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1059, 52, false);
#line 39 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TaskExemptionFee));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1155, 48, false);
#line 42 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TaskExemptionFee));

#line default
#line hidden
            EndContext();
            BeginContext(1203, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1247, 49, false);
#line 45 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SecondBoatFee));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1340, 45, false);
#line 48 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SecondBoatFee));

#line default
#line hidden
            EndContext();
            BeginContext(1385, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1429, 48, false);
#line 51 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ThirdBoatFee));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1521, 44, false);
#line 54 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ThirdBoatFee));

#line default
#line hidden
            EndContext();
            BeginContext(1565, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1609, 61, false);
#line 57 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ForthAndSubsequentBoatFee));

#line default
#line hidden
            EndContext();
            BeginContext(1670, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1714, 57, false);
#line 60 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ForthAndSubsequentBoatFee));

#line default
#line hidden
            EndContext();
            BeginContext(1771, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1815, 46, false);
#line 63 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NonSailFee));

#line default
#line hidden
            EndContext();
            BeginContext(1861, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1905, 42, false);
#line 66 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NonSailFee));

#line default
#line hidden
            EndContext();
            BeginContext(1947, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1991, 59, false);
#line 69 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NewMember25DiscountDate));

#line default
#line hidden
            EndContext();
            BeginContext(2050, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2094, 55, false);
#line 72 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NewMember25DiscountDate));

#line default
#line hidden
            EndContext();
            BeginContext(2149, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2193, 59, false);
#line 75 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NewMember50DiscountDate));

#line default
#line hidden
            EndContext();
            BeginContext(2252, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2296, 55, false);
#line 78 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NewMember50DiscountDate));

#line default
#line hidden
            EndContext();
            BeginContext(2351, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2395, 59, false);
#line 81 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NewMember75DiscountDate));

#line default
#line hidden
            EndContext();
            BeginContext(2454, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2498, 55, false);
#line 84 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NewMember75DiscountDate));

#line default
#line hidden
            EndContext();
            BeginContext(2553, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2591, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaffc0d9264c42a3b854a98d30385d93", async() => {
                BeginContext(2617, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2627, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "beb952574d5048f19577704d76f1a203", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 89 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS4\JRSail\JRSail\Views\JRAnnualFeeStructure\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Year);

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
                BeginContext(2665, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2749, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4afa46855df40cea708eb6a1193e72b", async() => {
                    BeginContext(2771, 12, true);
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
                BeginContext(2787, 6, true);
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
            BeginContext(2800, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JRSail.Models.AnnualFeeStructure> Html { get; private set; }
    }
}
#pragma warning restore 1591
