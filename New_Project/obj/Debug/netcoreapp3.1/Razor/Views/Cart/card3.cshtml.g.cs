#pragma checksum "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\Cart\card3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c287d748dc666ae9ca2b5f6913e706cb0a617a4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_card3), @"mvc.1.0.view", @"/Views/Cart/card3.cshtml")]
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
#nullable restore
#line 5 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\Cart\card3.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c287d748dc666ae9ca2b5f6913e706cb0a617a4f", @"/Views/Cart/card3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_card3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\Cart\card3.cshtml"
  
   Layout = "_layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</style>
<main class=""dt-sl mt-2 mb-3"">
        <div class=""row"">
            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-12 mr-auto ml-auto"" >
                <div class=""row"">
                    <div class=""col-md-10 col-sm-12 mx-auto"">
                        <div class=""px-3 px-res-0"">
                            <div class=""form-ui additional-info dt-sl dt-sn pt-4"">
                                <div class=""row"">
                                    <div class=""col-6"">
                                        مبلغ کل سفارش :
                                    </div>
                                    <div class=""col-6 text-success""> 
                                           ");
#nullable restore
#line 21 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\Cart\card3.cshtml"
                                      Write(HttpContextAccessor.HttpContext.Session.GetString("sum"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <hr>
                                <div class=""row"">
                                    <div class=""col-6"">
                                     پرداخت شده از کیف پول:
                                    </div>
                                    <div class=""col-6 text-primary"">
");
#nullable restore
#line 30 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\Cart\card3.cshtml"
                                         if (ViewBag.A != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p > ");
#nullable restore
#line 32 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\Cart\card3.cshtml"
                            Write(ViewBag.A);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 33 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\Cart\card3.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                </div>
                                <hr>
                                <div class=""row"">
                                    <div class=""col-6"">
                                      مبلغ  قابل پرداخت : 
                                    </div>
                                    <div class=""col-6 text-danger"">
");
#nullable restore
#line 42 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\Cart\card3.cshtml"
                                                         if (ViewBag.R != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p >");
#nullable restore
#line 44 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\Cart\card3.cshtml"
                           Write(ViewBag.R);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 45 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\Cart\card3.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                </div>
                                <hr>
                                    <div class=""dt-sl"">
                                        <div class=""form-row mt-3 justify-content-center"">
                                            <a href=""/cart/factor""
                                                class=""btn-primary-cm btn-with-icon ml-2"">
                                                <i class=""mdi mdi-account-circle-outline""></i>
                                                 پرداخت 
                                            </a>
                                            <a href=""#""
                                                class=""btn-primary-cm bg-secondary"">بازگشت</a>
                                        </div>
                                    </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
    ");
            WriteLiteral("    </div>\r\n</main>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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
