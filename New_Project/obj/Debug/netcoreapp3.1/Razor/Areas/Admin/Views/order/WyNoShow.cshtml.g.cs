#pragma checksum "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\WyNoShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "132e47bd171ed6a3067b7ef9ab3f5585053db78a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_order_WyNoShow), @"mvc.1.0.view", @"/Areas/Admin/Views/order/WyNoShow.cshtml")]
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
#line 1 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
using New_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
using New_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"132e47bd171ed6a3067b7ef9ab3f5585053db78a", @"/Areas/Admin/Views/order/WyNoShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_order_WyNoShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .hover1:hover {
        background-color: #59b63fbd;
        color: #ffffff;
    }
</style>

<div class=""content-body"">
    <div class=""col-lg-12"">
        <div style=""max-width: 600px !important; margin: auto;"" class=""card"">
            <div class=""card-heade  m-3"" style=""text-align: center;  "">
                <div class=""alert   alert-square ""
                    style=""background-color: #EA5455;  color: #ffffff; box-shadow: 0 1px 12px 0 rgba(0,0,0,0.2);"">
                    <h4 style=""margin-top: 0rem; margin-bottom: 0rem; font-size: 17px;"" class=""card-title""> <span
                            style=""font-weight: bold; "" class=""text-light"">  علت عدم تایید کالا  </h4>
                </div>
            </div>
            <div class=""col-xl-12 col-lg-12"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""basic-form"">
                                <div style="" border: 1px solid #b3b3b3 !important; border-radi");
            WriteLiteral("us: 10px; margin-top: 5px; text-align: center; \">\r\n                                    <div style=\"margin: 15px;\">\r\n                                                <div class=\"form-group\">\r\n");
#nullable restore
#line 25 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\WyNoShow.cshtml"
                                                         if (ViewBag.list != null)
                                                        {
                                                            foreach (var item in ViewBag.list)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                                <p class=\"text-danger\" >توضیحات عدم تایید:</p>\r\n                                                                                <p>");
#nullable restore
#line 30 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\WyNoShow.cshtml"
                                                                              Write(item.Why_Return_Admin_Bazrasi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 31 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\WyNoShow.cshtml"
                                                                                
                                                        }
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    
                                                </div>
                                    </div>

                                </div>
                                <div class=""col-6 m-1"">
                                        <a  href=""/admin/Order/Ten"" style=""font-weight: bold; font-size:16px;  border-color: green;""
                                            class=""btn btn-sm btn-info btn-block hover1 text-light""> بازگشت </a>
                                </div>
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
