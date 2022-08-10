#pragma checksum "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\ContactUs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b32a2c1bb8777f2054bcb13591376b37335623fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ContactUs_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ContactUs/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b32a2c1bb8777f2054bcb13591376b37335623fc", @"/Areas/Admin/Views/ContactUs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ContactUs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FileSharingApp.Areas.Admin.Models.ContactUsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ContactUs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "false", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "true", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\ContactUs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""/Admin/plugins/datatables-bs4/css/dataTables.bootstrap4.min.css"">
<link rel=""stylesheet"" href=""/Admin/plugins/datatables-responsive/css/responsive.bootstrap4.min.css"">
<link rel=""stylesheet"" href=""/Admin/plugins/datatables-buttons/css/buttons.bootstrap4.min.css"">



<section class=""content"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Responsive Hover Table</h3>
                    <div class=""card-tools"">
                        <div class=""input-group input-group-sm"" style=""width: 150px;"">
                            <input type=""text"" name=""table_search"" class=""form-control float-right"" placeholder=""Search"">
                            <div class=""input-group-append"">
                                <button type=""submit"" class=""btn btn-default"">
                                    <i class=""fas fa-search""></i>
                           ");
            WriteLiteral(@"     </button>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /.card-header -->
                <div class=""card-body table-responsive p-0"">
                    <table id=""Content-table"" class=""table table-hover text-nowrap "">
                        <thead>
                            <tr>

                                <th>Name</th>
                                <th>Email</th>
                                <th>Date</th>
                                <th>Status</th>
                                <th>Subject</th>
                                <th>Details</th>
                                <th>Change Status</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 45 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 48 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 49 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td><span class=\"moment-date\">");
#nullable restore
#line 50 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                             Write(item.SentDate.ToString("yyyy-MM-dd hh-mm-ss", new System.Globalization.CultureInfo("en-US")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                    <td><span");
            BeginWriteAttribute("class", " class=\"", 2435, "\"", 2492, 3);
            WriteAttributeValue("", 2443, "tag", 2443, 3, true);
#nullable restore
#line 51 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\ContactUs\Index.cshtml"
WriteAttributeValue(" ", 2446, item.Status? "tag-success" : "tag-danger", 2447, 44, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2491, "", 2492, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                                                                    Write(item.Status? "Closed" : "Open");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                    <td>");
#nullable restore
#line 52 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                   Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b32a2c1bb8777f2054bcb13591376b37335623fc10449", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b32a2c1bb8777f2054bcb13591376b37335623fc13208", async() => {
                WriteLiteral("\r\n                                            <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 3061, "\"", 3077, 1);
#nullable restore
#line 58 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\ContactUs\Index.cshtml"
WriteAttributeValue("", 3069, item.Id, 3069, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                            <select");
                BeginWriteAttribute("onchange", " onchange=\"", 3134, "\"", 3201, 3);
                WriteAttributeValue("", 3145, "document.getElementById(\'Status-form-", 3145, 37, true);
#nullable restore
#line 59 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\ContactUs\Index.cshtml"
WriteAttributeValue("", 3182, item.Id, 3182, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3190, "\').submit()", 3190, 11, true);
                EndWriteAttribute();
                WriteLiteral(" name=\"Status\" class=\"form-control\">\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b32a2c1bb8777f2054bcb13591376b37335623fc14635", async() => {
                    WriteLiteral("Select Status");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b32a2c1bb8777f2054bcb13591376b37335623fc15914", async() => {
                    WriteLiteral("Open");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b32a2c1bb8777f2054bcb13591376b37335623fc17184", async() => {
                    WriteLiteral("Closed");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            </select>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2949, "Status-form-", 2949, 12, true);
#nullable restore
#line 57 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\ContactUs\Index.cshtml"
AddHtmlAttributeValue("", 2961, item.Id, 2961, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 67 "D:\Te-data\FileSharingApp\FileSharingApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n                <!-- /.card-body -->\r\n            </div>\r\n            <!-- /.card -->\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""/Admin/plugins/datatables/jquery.dataTables.min.js""></script>
    <script src=""/Admin/plugins/datatables-bs4/js/dataTables.bootstrap4.min.js""></script>
    <script src=""/Admin/plugins/datatables-responsive/js/dataTables.responsive.min.js""></script>
    <script src=""/Admin/plugins/datatables-responsive/js/responsive.bootstrap4.min.js""></script>
    <script src=""/Admin/plugins/datatables-buttons/js/dataTables.buttons.min.js""></script>
    <script src=""/Admin/plugins/datatables-buttons/js/buttons.bootstrap4.min.js""></script>
    <script src=""/Admin/plugins/jszip/jszip.min.js""></script>
    <script src=""/Admin/plugins/pdfmake/pdfmake.min.js""></script>
    <script src=""/Admin/plugins/pdfmake/vfs_fonts.js""></script>
    <script src=""/Admin/plugins/datatables-buttons/js/buttons.html5.min.js""></script>
    <script src=""/Admin/plugins/datatables-buttons/js/buttons.print.min.js""></script>
    <script src=""/Admin/plugins/datatables-buttons/js/buttons.colVis.min.js""></script>
    <script>
");
                WriteLiteral(@"        $(document).ready(function () {
            $(""#Content-table"").DataTable({
                ""responsive"": true, ""lengthChange"": false, ""autoWidth"": false,
                ""buttons"": [""copy"", ""csv"", ""excel"", ""pdf"", ""print"", ""colvis""]
            }).buttons().container().appendTo('#Content-table_wrapper .col-md-6:eq(0)');
        });
    </script>
");
            }
            );
            WriteLiteral("            \r\n\r\n   \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FileSharingApp.Areas.Admin.Models.ContactUsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591