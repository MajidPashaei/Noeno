<<<<<<< HEAD
#pragma checksum "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10f9f0181a40838e2118710a5e499371375c407d"
=======
#pragma checksum "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10f9f0181a40838e2118710a5e499371375c407d"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_order_OneTen), @"mvc.1.0.view", @"/Areas/Admin/Views/order/OneTen.cshtml")]
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
<<<<<<< HEAD
#line 1 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
using New_Project;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
using New_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10f9f0181a40838e2118710a5e499371375c407d", @"/Areas/Admin/Views/order/OneTen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_order_OneTen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
<<<<<<< HEAD
#line 28 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 28 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                 if (ViewBag.list != null)
                                {
                                    int i = 1;

                                    

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 32 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 32 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                     foreach (var item in ViewBag.list)
                                    {





#line default
#line hidden
#nullable disable
            WriteLiteral("                                          <tr>\r\n                                            <td></td>\r\n                                            <td>");
#nullable restore
<<<<<<< HEAD
#line 40 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 40 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
<<<<<<< HEAD
#line 41 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 41 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                           Write(item.Id_Factro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
<<<<<<< HEAD
#line 42 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 42 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
<<<<<<< HEAD
#line 43 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 43 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                           Write(item.product_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td> ");
#nullable restore
<<<<<<< HEAD
#line 44 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 44 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                            Write(item.Date_Order);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
<<<<<<< HEAD
#line 45 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 45 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                           Write(item.product_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
<<<<<<< HEAD
#line 46 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 46 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                           Write(item.PriceB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
<<<<<<< HEAD
#line 47 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 47 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                           Write(item.PriceK);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
<<<<<<< HEAD
#line 48 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 48 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                           Write(item.TellSel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
<<<<<<< HEAD
#line 49 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 49 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                           Write(item.TellBuy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
<<<<<<< HEAD
#line 50 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 50 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                           Write(item.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
<<<<<<< HEAD
#line 50 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 50 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                                       Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
<<<<<<< HEAD
#line 50 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 50 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                                                  Write(item.FirstAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
<<<<<<< HEAD
#line 51 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 51 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                           Write(item.Post);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "10f9f0181a40838e2118710a5e499371375c407d9919", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2553, "~/fileupload/", 2553, 13, true);
#nullable restore
<<<<<<< HEAD
#line 52 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 52 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
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
<<<<<<< HEAD
#line 53 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 53 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                           Write(item.Send_Admin_Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
<<<<<<< HEAD
#line 54 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 54 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                           Write(item.StatusM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                         \r\n                                         \r\n                                         \r\n                                           \r\n\r\n                                        </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 61 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 61 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                        i++;
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 62 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
=======
#line 62 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\order\OneTen.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                     
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
