#pragma checksum "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9154dc967c660409180b64ef83eedba95c1832aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YourAccount_OrdersReturn), @"mvc.1.0.view", @"/Views/YourAccount/OrdersReturn.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9154dc967c660409180b64ef83eedba95c1832aa", @"/Views/YourAccount/OrdersReturn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Views/_ViewImports.cshtml")]
    public class Views_YourAccount_OrdersReturn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 75px; height: 75px; border-radius: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(" <!-- Start main-content -->\r\n        <main class=\"main-content dt-sl mt-4 mb-3\">\r\n            <div class=\"container main-container\">\r\n                <div class=\"row\">\r\n\r\n                     <!-- Start Sidebar -->\r\n              ");
#nullable restore
#line 7 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
         Write(await Html.PartialAsync("_Partial_profile"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!-- End Sidebar -->\r\n\r\n                    <!-- Start Content -->\r\n                            <div class=\"col-xl-9 col-lg-8 col-md-8 col-sm-12\">\r\n                        <div class=\"row\">\r\n                            <div class=\"dt-sl\">\r\n");
#nullable restore
#line 14 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                 if (ViewBag.s != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"row m-1\">\r\n");
#nullable restore
#line 17 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                         foreach (var item in ViewBag.s)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""col-lg-6 col-md-6 col-12 "">
                                                        <div class=""card-horizontal-product shadow"">
                                                            <div class=""row"">
                                                                <a");
            BeginWriteAttribute("href", " href=\"", 1129, "\"", 1170, 2);
            WriteAttributeValue("", 1136, "/singlepage/index/", 1136, 18, true);
#nullable restore
#line 22 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
WriteAttributeValue("", 1154, item.Product_Id, 1154, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"m-2\">\r\n                                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9154dc967c660409180b64ef83eedba95c1832aa6221", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1264, "~/fileupload/", 1264, 13, true);
#nullable restore
#line 23 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
AddHtmlAttributeValue("", 1277, item.Image, 1277, 11, false);

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
                                                                </a>
                                                                <div class=""cl-6"">
                                                                    <p style=""font-size: 10px;"">?????????? ???????????? : <span>  ");
#nullable restore
#line 26 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                                                                                                  Write(item.Id_Factro);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></p>\r\n                                                                    <p style=\"font-size: 10px;\">???? ??????????: <span> ");
#nullable restore
#line 27 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                                                                                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span></p>
                                                                    <p style=""font-size: 10px;"">  ?????????? ??????????: <span> 99/02/31 </span></p>

                                                                </div>
                                                                <div class=""cl-6 mr-3"">
                                                                    <p style=""font-size: 10px;"">?????? ?????????? : <span> ");
#nullable restore
#line 32 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                                                                                              Write(item.product_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></p>\r\n                                                                    <p style=\"font-size: 10px;\">???????? : <span> ");
#nullable restore
#line 33 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                                                                                         Write(item.product_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> ?????????? </p>\r\n                                                                    <p style=\"font-size: 10px;\">?????????? :<span style=\"font-size: 8px;\"> ");
#nullable restore
#line 34 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                                                                                                                 Write(item.StatusM);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span></p>
                                                                </div>
                                                            </div>
                                                            <p style=""font-size: 10px;""> ????????:
                                                                
                                                                    <span> ");
#nullable restore
#line 39 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                                                      Write(item.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 39 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                                                                  Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 39 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                                                                             Write(item.FirstAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |");
#nullable restore
#line 39 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                                                                                                 Write(item.Post);

#line default
#line hidden
#nullable disable
            WriteLiteral("| ");
#nullable restore
#line 39 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                                                                                                             Write(item.TellBuy);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                                                                \r\n                                                            </p>\r\n                                                                \r\n");
#nullable restore
#line 43 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                                                 if (@item.StatusM=="?????? ???????????? ????????????")
                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                    <div style=\"font-size: 10px; text-align: center;\" class=\"mt-1\">\r\n                                                                            <a");
            BeginWriteAttribute("href", " href=\"", 3590, "\"", 3633, 2);
            WriteAttributeValue("", 3597, "/YourAccount/TahvilNOShow?c=", 3597, 28, true);
#nullable restore
#line 46 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
WriteAttributeValue("", 3625, item.Id, 3625, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">???????????? ??????  </a>\r\n                                                                            ???? ???????????? ?????????? ????????????\r\n                                                                    </div>\r\n");
#nullable restore
#line 49 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                                                 if (@item.StatusM=="?????????? ??????")
                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                    <div style=\"font-size: 10px; text-align: center;\" class=\"mt-1\">\r\n                                                                               <a");
            BeginWriteAttribute("href", " href=\"", 4299, "\"", 4342, 2);
            WriteAttributeValue("", 4306, "/YourAccount/TahvilNOShow?c=", 4306, 28, true);
#nullable restore
#line 53 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
WriteAttributeValue("", 4334, item.Id, 4334, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">???????????? ??????  </a>\r\n                                                                    </div>\r\n");
#nullable restore
#line 55 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                                                 if (@item.StatusM=="?????? ?????????? ?????? ????????????")
                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                    <div style=""font-size: 10px; text-align: center;"" class=""mt-1"">
                                                                           ???????????? ???????? ????????
                                                                    </div>
");
#nullable restore
#line 61 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                                                 if (@item.StatusM=="?????????? ?????????? ??????")
                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                    <p style=\"font-size: 10px;\"> ???? ????????????: ");
#nullable restore
#line 64 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                                                                                       Write(item.Send_Order_Code);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p> \r\n");
#nullable restore
#line 65 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                \r\n                                                        </div>\r\n                                            </div>\r\n");
#nullable restore
#line 69 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n");
#nullable restore
#line 71 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\OrdersReturn.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <!-- End Content -->\r\n\r\n                </div>\r\n            </div>\r\n        </main>\r\n        <!-- End main-content -->\r\n");
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
