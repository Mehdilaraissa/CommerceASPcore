#pragma checksum "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\ProductStock\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2223c7c204afd21b30dc536d1bde09584cd58062"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductStock_Index), @"mvc.1.0.view", @"/Views/ProductStock/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductStock/Index.cshtml", typeof(AspNetCore.Views_ProductStock_Index))]
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
#line 1 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core;

#line default
#line hidden
#line 2 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core.Models;

#line default
#line hidden
#line 4 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using System.Collections;

#line default
#line hidden
#line 5 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core.BootstrapModal;

#line default
#line hidden
#line 6 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core.Code;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2223c7c204afd21b30dc536d1bde09584cd58062", @"/Views/ProductStock/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71cfa9c3ae2f1e0493d4ca25e3a3394ef37b5862", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductStock_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ecommerce_MVC_Core.ViewModel.ProductStockListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("createModel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ProductStock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddEditProductStock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editUserModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteUserModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#modal-popUP"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\ProductStock\Index.cshtml"
  
    ViewData["Title"] = "Product Stock";

#line default
#line hidden
            BeginContext(121, 24, true);
            WriteLiteral("\n\n<div class=\"row\">\n    ");
            EndContext();
            BeginContext(145, 586, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5adb01baf37843ad98a1504386a1a14e", async() => {
                BeginContext(204, 93, true);
                WriteLiteral("\n        <div class=\"form-horizontal\">\n\n            <div class=\"form-group\">\n                ");
                EndContext();
                BeginContext(297, 189, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6961cc473c0e455ca69ca539c3d1671d", async() => {
                    BeginContext(401, 81, true);
                    WriteLiteral("\n                    <i class=\"glyphicon glyphicon-plus\"></i>Add\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(486, 49, true);
                WriteLiteral("\n                <input type=\"text\" name=\"search\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 535, "\"", 569, 1);
#line 15 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\ProductStock\Index.cshtml"
WriteAttributeValue("", 543, Html.ViewBag.SearchString, 543, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(570, 154, true);
                WriteLiteral(" class=\"form-control\" />\n                <input type=\"submit\" value=\"Search\" class=\"btn btn-default pull-right\" />\n\n            </div>\n        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(731, 15, true);
            WriteLiteral("\n</div>\n<hr />\n");
            EndContext();
#line 23 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\ProductStock\Index.cshtml"
  
    if (Model.ToList().Count <= 0)
    {

#line default
#line hidden
            BeginContext(790, 35, true);
            WriteLiteral("        <h1>No Item Added Yet</h1>\n");
            EndContext();
#line 27 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\ProductStock\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(846, 431, true);
            WriteLiteral(@"        <table class=""table table-responsive table-hover"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Product</th>
                    <th>In Stock</th>
                    <th>In Quantity</th>
                    <th>Out Quantity</th>
                    <th>Last Updated</th>
                    <th>Action</th>
                </tr>
            </thead>

            <tbody>
");
            EndContext();
#line 44 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\ProductStock\Index.cshtml"
                  
                    int count = 1;
                    foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1401, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(1447, 5, false);
#line 49 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\ProductStock\Index.cshtml"
                   Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1452, 55, true);
            WriteLiteral("</td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(1508, 16, false);
#line 51 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\ProductStock\Index.cshtml"
                   Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1524, 51, true);
            WriteLiteral("\n                    </td>\n                    <td>");
            EndContext();
            BeginContext(1576, 12, false);
#line 53 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\ProductStock\Index.cshtml"
                   Write(item.InStock);

#line default
#line hidden
            EndContext();
            BeginContext(1588, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1619, 15, false);
#line 54 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\ProductStock\Index.cshtml"
                   Write(item.InQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(1634, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1665, 16, false);
#line 55 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\ProductStock\Index.cshtml"
                   Write(item.OutQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(1681, 134, true);
            WriteLiteral("</td>\n                    <th>\n                        \n                        <a href=\"#\" data-toggle=\"tooltip\" data-placement=\"top\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1815, "\"", 1844, 2);
            WriteAttributeValue("", 1823, "Added", 1823, 5, true);
#line 58 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\ProductStock\Index.cshtml"
WriteAttributeValue(" ", 1828, item.AddedDate, 1829, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1845, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1847, 17, false);
#line 58 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\ProductStock\Index.cshtml"
                                                                                                        Write(item.ModifiedDate);

#line default
#line hidden
            EndContext();
            BeginContext(1864, 72, true);
            WriteLiteral("</a>\n                    </th>\n                <td>\n                    ");
            EndContext();
            BeginContext(1936, 221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50d3812b307c4f66bdbd55ea58ee6fba", async() => {
                BeginContext(2059, 94, true);
                WriteLiteral("\n                        <i class=\"glyphicon glyphicon-pencil\"></i>  Edit\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\ProductStock\Index.cshtml"
                                                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2157, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(2178, 237, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2eb06147083f40369e7a70125c09509f", async() => {
                BeginContext(2316, 95, true);
                WriteLiteral("\n                        <i class=\"glyphicon glyphicon-trash\"></i>  Delete\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\ProductStock\Index.cshtml"
                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2415, 45, true);
            WriteLiteral("\n                </td>\n                </tr>\n");
            EndContext();
#line 70 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\ProductStock\Index.cshtml"
                        count++;
                    }
                

#line default
#line hidden
            BeginContext(2533, 38, true);
            WriteLiteral("            </tbody>\n        </table>\n");
            EndContext();
#line 75 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\ProductStock\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2580, 127, false);
#line 77 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\ProductStock\Index.cshtml"
Write(Html.Partial("_Modal", new BootstrapModel { ID = "modal-popUP", AreaLabeledId = "modal-popUP-label", Size = ModalSize.Medium }));

#line default
#line hidden
            EndContext();
            BeginContext(2707, 3, true);
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ecommerce_MVC_Core.ViewModel.ProductStockListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
