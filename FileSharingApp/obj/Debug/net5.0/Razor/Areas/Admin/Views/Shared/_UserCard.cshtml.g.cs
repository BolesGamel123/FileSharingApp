#pragma checksum "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\Shared\_UserCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "297f66c7a9469c6f589ad9c7f9ea0acab2826492"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__UserCard), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_UserCard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"297f66c7a9469c6f589ad9c7f9ea0acab2826492", @"/Areas/Admin/Views/Shared/_UserCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__UserCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FileSharingApp.Areas.Admin.Models.AdminUserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Blocked", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-12 col-sm-6 col-md-4 d-flex align-items-stretch flex-column"">
    <div class=""card bg-light d-flex flex-fill"" style=""width:100%"">
        <div class=""card-header text-muted border-bottom-0"">
            Digital Strategist
        </div>
        <div class=""card-body pt-0"">
            <div class=""row"">
                <div class=""col-7"">
                    <h2 class=""lead""><b>Name:");
#nullable restore
#line 10 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\Shared\_UserCard.cshtml"
                                         Write(Model.FirstName+""+Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\r\n                    <p class=\"text-muted text-sm\"><b>Email: </b> ");
#nullable restore
#line 11 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\Shared\_UserCard.cshtml"
                                                            Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                    <ul class=""ml-4 mb-0 fa-ul text-muted"">
                        <li class=""small"">
                            <span class=""fa-li""><i class=""fas fa-lg fa-calendar""></i></span>
                            <strong>CreatedDate: </strong>  <span class=""moment-date""> ");
#nullable restore
#line 15 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\Shared\_UserCard.cshtml"
                                                                                  Write(Model.CreatedDate.ToString("yyyy-MM-dd hh-mm-ss", new System.Globalization.CultureInfo("en-US")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </li>\r\n");
            WriteLiteral(@"                    </ul>
                </div>
                <div class=""col-5 text-center"">
                    <img src=""/Admin/dist/img/user1-128x128.jpg"" alt=""user-avatar"" class=""img-circle img-fluid"">
                </div>
            </div>
        </div>
        <div class=""card-footer"">
            <div class=""text-right"">
                <a href=""#"" class=""btn btn-sm bg-teal "">
                    <i class=""fas fa-comments""></i>
                </a>
                <button");
            BeginWriteAttribute("form", " form=\"", 1670, "\"", 1701, 2);
            WriteAttributeValue("", 1677, "block-form-", 1677, 11, true);
#nullable restore
#line 30 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\Shared\_UserCard.cshtml"
WriteAttributeValue("", 1688, Model.UserId, 1688, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"submit\"");
            BeginWriteAttribute("class", " class=\"", 1716, "\"", 1781, 4);
            WriteAttributeValue("", 1724, "btn", 1724, 3, true);
            WriteAttributeValue(" ", 1727, "btn-sm", 1728, 7, true);
#nullable restore
#line 30 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\Shared\_UserCard.cshtml"
WriteAttributeValue(" ", 1734, Model.IsBlocked?"btn-danger":"btn-primary", 1735, 45, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1780, "", 1781, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i");
            BeginWriteAttribute("class", " class=\"", 1807, "\"", 1863, 2);
            WriteAttributeValue("", 1815, "fas", 1815, 3, true);
#nullable restore
#line 31 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\Shared\_UserCard.cshtml"
WriteAttributeValue("  ", 1818, Model.IsBlocked?"fa-user":"fa-user-lock", 1820, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> ");
#nullable restore
#line 31 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\Shared\_UserCard.cshtml"
                                                                                 Write(Model.IsBlocked? "Unblock User" : " Block User");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "297f66c7a9469c6f589ad9c7f9ea0acab28264928162", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("value", " value=\"", 2117, "\"", 2138, 1);
#nullable restore
#line 34 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\Shared\_UserCard.cshtml"
WriteAttributeValue("", 2125, Model.UserId, 2125, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1975, "block-form-", 1975, 11, true);
#nullable restore
#line 33 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\Shared\_UserCard.cshtml"
AddHtmlAttributeValue("", 1986, Model.UserId, 1986, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FileSharingApp.Areas.Admin.Models.AdminUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591