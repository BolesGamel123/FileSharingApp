#pragma checksum "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\User\Blocked.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b2a4affa78161cd8056197785de0c803076fb11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Blocked), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Blocked.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b2a4affa78161cd8056197785de0c803076fb11", @"/Areas/Admin/Views/User/Blocked.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Blocked : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FileSharingApp.Areas.Admin.Models.AdminUserViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_UserCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\User\Blocked.cshtml"
  
    ViewData["Title"] = " Blocked User List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <!-- Main content -->\r\n    <section class=\"content\">\r\n\r\n        <!-- Default box -->\r\n        <div class=\"card card-solid\">\r\n            <div class=\"card-body pb-0\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 15 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\User\Blocked.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9b2a4affa78161cd8056197785de0c803076fb113848", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 17 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\User\Blocked.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 18 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\User\Blocked.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>
            </div>
            <!-- /.card-body -->
            <div class=""card-footer"">
                <nav aria-label=""Contacts Page Navigation"">
                    <ul class=""pagination justify-content-center m-0"">
                        <li class=""page-item active""><a class=""page-link"" href=""#"">1</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">4</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">5</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">6</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">7</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">8</a></li>
                    </ul>
                </nav>
        ");
            WriteLiteral("    </div>\r\n            <!-- /.card-footer -->\r\n        </div>\r\n        <!-- /.card -->\r\n\r\n    </section>\r\n    <!-- /.content -->\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FileSharingApp.Areas.Admin.Models.AdminUserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
