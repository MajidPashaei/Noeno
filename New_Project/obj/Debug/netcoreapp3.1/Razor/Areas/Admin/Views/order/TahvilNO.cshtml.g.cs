#pragma checksum "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\TahvilNO.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a07d4ed0713ae71f755a161d5d04b0fe347ae3d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_order_TahvilNO), @"mvc.1.0.view", @"/Areas/Admin/Views/order/TahvilNO.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a07d4ed0713ae71f755a161d5d04b0fe347ae3d1", @"/Areas/Admin/Views/order/TahvilNO.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_order_TahvilNO : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 150px; max-height: 150px; min-width: 150px; min-height: 150px; border: 1px solid #000;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                <div class=""alert    alert-square ""
                    style=""background-color: #EA5455;  color: #ffffff; box-shadow: 0 1px 12px 0 rgba(0,0,0,0.2);"">
                    <h4 style=""margin-top: 0rem; margin-bottom: 0rem; font-size: 17px;"" class=""card-title""> <span
                            style=""font-weight: bold; "" class=""text-light"">  علت مرجوع کالا  </h4>
                </div>
            </div>
            <div class=""col-xl-12 col-lg-12"">
");
#nullable restore
#line 19 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\TahvilNO.cshtml"
                 if (ViewBag.list != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\TahvilNO.cshtml"
                                 foreach (var item in ViewBag.list)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 995, "\"", 1003, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""card-body"">
                        <div class=""basic-form"">
                               
                                <div style="" border: 1px solid #b3b3b3 !important; border-radius: 10px; margin-top: 5px; "">
                                    <div style=""margin: 15px;"">
                                                <div class=""form-group"">
                                                    <div class=""row"" style=""padding: 20px;"">
                                                            <div class=""col-ting col-lg-3 col-md-3 col-6 "">
                                                                <div class=""mr-1"">
                                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a07d4ed0713ae71f755a161d5d04b0fe347ae3d16243", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1764, "~/fileupload/", 1764, 13, true);
#nullable restore
#line 33 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\TahvilNO.cshtml"
AddHtmlAttributeValue("", 1777, item.ImageReturn, 1777, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                                                </div>
                                                                
                                                            </div>

                                                    </div>    
                                                    <div style=""padding: 14px;"" class=""form-group"">
                                                            <label style=""font-weight: bold; font-size:14px""
                                                                class=""text-label mb-1""> توضیحات در مورد مرجوعی  
                                                            </label>
                                                            <input style=""border-radius: 10px;"" type=""text""
                                                                class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2849, "\"", 2881, 1);
#nullable restore
#line 46 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\TahvilNO.cshtml"
WriteAttributeValue("", 2857, item.Why_Return_Request, 2857, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                    </div>
                                                    <div class=""col-lg-12 col-md-12 mb-1"">
                                                            <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                                                            <a");
            BeginWriteAttribute("href", " href=\"", 3224, "\"", 3265, 2);
            WriteAttributeValue("", 3231, "/admin/Order/TahvilNoOk?c=", 3231, 26, true);
#nullable restore
#line 50 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\TahvilNO.cshtml"
WriteAttributeValue("", 3257, item.Id, 3257, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-info btn-sm"" >  تایید درخواست </a>
                                                            </div>
                                                            <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                                                            <a");
            BeginWriteAttribute("href", " href=\"", 3573, "\"", 3614, 2);
            WriteAttributeValue("", 3580, "/admin/Order/TahvilNoNo?c=", 3580, 26, true);
#nullable restore
#line 53 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\TahvilNO.cshtml"
WriteAttributeValue("", 3606, item.Id, 3606, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-danger btn-sm"" >  رد درخواست </a>
                                                            </div>
                                                    </div>
                                                </div>
                                    </div>
                                </div>

                        </div>
                    </div>
                </div>
");
#nullable restore
#line 63 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\TahvilNO.cshtml"
                
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\order\TahvilNO.cshtml"
                                 
                          }  

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n                                ");
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
