#pragma checksum "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20fd60af2cd74853a6c771b361a84d301861c2c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JRMembership_Index), @"mvc.1.0.view", @"/Views/JRMembership/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/JRMembership/Index.cshtml", typeof(AspNetCore.Views_JRMembership_Index))]
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
#line 2 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20fd60af2cd74853a6c771b361a84d301861c2c1", @"/Views/JRMembership/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"470cd81089aa75a1651402e60f78c103e8ba8a92", @"/Views/_ViewImports.cshtml")]
    public class Views_JRMembership_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JRSail.Models.Membership>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
  
    ViewData["Title"] = $"Memberships for {Context.Session.GetString("FullName")}";

#line default
#line hidden
            BeginContext(172, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(179, 17, false);
#line 7 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(196, 18, true);
            WriteLiteral("</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(214, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39191014ba3f450abe94992659b64fe5", async() => {
                BeginContext(237, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(251, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(344, 40, false);
#line 16 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(384, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(440, 39, false);
#line 19 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fee));

#line default
#line hidden
            EndContext();
            BeginContext(479, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(535, 44, false);
#line 22 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Comments));

#line default
#line hidden
            EndContext();
            BeginContext(579, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(635, 40, false);
#line 25 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Paid));

#line default
#line hidden
            EndContext();
            BeginContext(675, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(731, 42, false);
#line 28 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Member));

#line default
#line hidden
            EndContext();
            BeginContext(773, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(829, 64, false);
#line 31 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MembershipTypeNameNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(893, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 37 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1011, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1060, 39, false);
#line 40 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1155, 38, false);
#line 43 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fee));

#line default
#line hidden
            EndContext();
            BeginContext(1193, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1249, 43, false);
#line 46 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Comments));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1348, 39, false);
#line 49 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Paid));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1443, 51, false);
#line 52 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Member.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1494, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1550, 82, false);
#line 55 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MembershipTypeNameNavigation.MembershipTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(1632, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1687, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d16e490ee1b48938589738bd3cc7735", async() => {
                BeginContext(1742, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
                                       WriteLiteral(item.MembershipId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1750, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1770, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8284137218cc4714b1ac82f4d6388d71", async() => {
                BeginContext(1828, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
                                          WriteLiteral(item.MembershipId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1839, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1859, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa022b829da446d5bbaf0b17ebf0f400", async() => {
                BeginContext(1916, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
                                         WriteLiteral(item.MembershipId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1926, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 63 "C:\Users\Joel\Documents\Fall 2018\Web Tech - Scanlan\JReptaAS3\JRSail\JRSail\Views\JRMembership\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1965, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JRSail.Models.Membership>> Html { get; private set; }
    }
}
#pragma warning restore 1591