#pragma checksum "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\WyNoShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "357361b0d9ec67cc02aa64ee949cc34618656af5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YourAccount_WyNoShow), @"mvc.1.0.view", @"/Views/YourAccount/WyNoShow.cshtml")]
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
#line 1 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\_ViewImports.cshtml"
using New_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\_ViewImports.cshtml"
using New_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"357361b0d9ec67cc02aa64ee949cc34618656af5", @"/Views/YourAccount/WyNoShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Views/_ViewImports.cshtml")]
    public class Views_YourAccount_WyNoShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 100%; width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 25 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\WyNoShow.cshtml"
                                                         if (ViewBag.list != null)
                                                        {
                                                            foreach (var item in ViewBag.list)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                                <p class=\"text-danger\" >توضیحات عدم تایید:</p>\r\n                                                                                <p>");
#nullable restore
#line 30 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\WyNoShow.cshtml"
                                                                              Write(item.Why_Return_Admin_Bazrasi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                                                <div style=\"height: 120px; width: 150px;\">\r\n                                                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "357361b0d9ec67cc02aa64ee949cc34618656af56035", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1981, "~/fileupload/", 1981, 13, true);
#nullable restore
#line 32 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\WyNoShow.cshtml"
AddHtmlAttributeValue("", 1994, item.ImgNoB, 1994, 12, false);

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
            WriteLiteral("\r\n                                                                                </div>\r\n");
#nullable restore
#line 34 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\WyNoShow.cshtml"
                                                                                
                                                                                
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
                                        <a  href=""/YourAccount/Orders"" style=""font-weight: bold; font-size:16px;  border-color: green;""
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