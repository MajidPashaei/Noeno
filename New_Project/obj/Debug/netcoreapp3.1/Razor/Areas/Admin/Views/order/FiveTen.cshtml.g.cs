#pragma checksum "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea4d48d75153824efe5474f9cfebb5f28c774acd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_order_FiveTen), @"mvc.1.0.view", @"/Areas/Admin/Views/order/FiveTen.cshtml")]
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
#line 1 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
using New_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
using New_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea4d48d75153824efe5474f9cfebb5f28c774acd", @"/Areas/Admin/Views/order/FiveTen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_order_FiveTen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 80px ;height: 80px;border-radius: 50%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section id=""data-list-view"" class=""data-list-view-header"">
  <div class=""table-responsive"">
    <table class=""table data-list-view"">
            <thead>
                                <tr>
                                    <th></th>
                                    <th>ردیف</th>
                                    <th>شماره فاکتور</th>
                                    <th>کد سفارش </th>
                                    <th>نام محصول</th>
                                    <th> تاریخ سفارش </th>
                                    <th>مبلغ کالا </th>
                                    <th>هزینه بازرسی</th>
                                    <th>هزینه کمسیون</th>
                                    <th>شماره فروشنده</th>
                                    <th>شماره خریدار</th>
                                    <th>ادرس گیرنده</th>
                                    <th>کد پستی</th>
                                    <th>عکس کالا</th>
                                    <t");
            WriteLiteral(@"h>کد مرسوله</th>
                                    <th>عملیات</th>

                                     
                                   
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 28 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                 if (ViewBag.list != null)
                                {
                                    int i = 1;

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                     foreach (var item in ViewBag.list)
                                    {





#line default
#line hidden
#nullable disable
            WriteLiteral("                                          <tr>\r\n                                            <td></td>\r\n                                            <td>");
#nullable restore
#line 40 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 41 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                           Write(item.Id_Factro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 42 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 43 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                           Write(item.product_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td> ");
#nullable restore
#line 44 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                            Write(item.Date_Order);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 45 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                           Write(item.product_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 46 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                           Write(item.PriceB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 47 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                           Write(item.PriceK);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 48 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                           Write(item.TellSel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 49 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                           Write(item.TellBuy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 50 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                           Write(item.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 50 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                                       Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 50 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                                                  Write(item.FirstAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 51 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                           Write(item.Post);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ea4d48d75153824efe5474f9cfebb5f28c774acd10206", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2553, "~/fileupload/", 2553, 13, true);
#nullable restore
#line 52 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
AddHtmlAttributeValue("", 2566, item.Image, 2566, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 53 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                           Write(item.Send_Sales_Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n                                             ");
#nullable restore
#line 55 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                        Write(item.StatusM);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </td>
                                         
                                         
                                         
                                           

                                        </tr>
");
#nullable restore
#line 63 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                        i++;
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\FiveTen.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n    </table>\r\n  </div>\r\n\r\n</section>\r\n");
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
