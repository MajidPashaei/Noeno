#pragma checksum "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\Favorites.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed005fa89446b5228f0870dccb74ecf6786c551f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YourAccount_Favorites), @"mvc.1.0.view", @"/Views/YourAccount/Favorites.cshtml")]
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
#line 1 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\_ViewImports.cshtml"
using New_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\_ViewImports.cshtml"
using New_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed005fa89446b5228f0870dccb74ecf6786c551f", @"/Views/YourAccount/Favorites.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Views/_ViewImports.cshtml")]
    public class Views_YourAccount_Favorites : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n        <!-- Start main-content -->\r\n        <main class=\"main-content dt-sl mt-4 mb-3\">\r\n            <div class=\"container main-container\">\r\n                <div class=\"row\">\r\n\r\n                    <!-- Start Sidebar -->\r\n              ");
#nullable restore
#line 8 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\Favorites.cshtml"
         Write(await Html.PartialAsync("_Partial_profile"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <!-- End Sidebar -->

                    <!-- Start Content -->
                    <div class=""col-xl-9 col-lg-8 col-md-8 col-sm-12"">
                        <div class=""row"">
                            <div class=""col-12"">
                                <div class=""section-title text-sm-title title-wide mb-1 no-after-title-wide dt-sl mb-2 px-res-1"">
                                    <h2>علاقمندی ها</h2>
                                </div>
                                <div class=""dt-sl"">
                                    <div class=""row"">
");
#nullable restore
#line 20 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\Favorites.cshtml"
                                         if (ViewBag.f != null)
                                        {
                                            foreach (var item in ViewBag.f)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <div class=""col-lg-6 col-md-12 "">
                                                    <div class=""card-horizontal-product shadow"">
                                                        <div class=""card-horizontal-product-thumb"">
                                                            <a");
            BeginWriteAttribute("href", " href=\"", 1443, "\"", 1476, 2);
            WriteAttributeValue("", 1450, "/singlepage/index/", 1450, 18, true);
#nullable restore
#line 27 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\Favorites.cshtml"
WriteAttributeValue("", 1468, item.Id, 1468, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ed005fa89446b5228f0870dccb74ecf6786c551f5886", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1554, "~/fileupload/", 1554, 13, true);
#nullable restore
#line 28 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\Favorites.cshtml"
AddHtmlAttributeValue("", 1567, item.Image, 1567, 11, false);

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
            WriteLiteral(@"
                                                            </a>
                                                        </div>
                                                        <div class=""card-horizontal-product-content"">
                                                            <div class=""card-horizontal-product-title"">
                                                                <a");
            BeginWriteAttribute("href", " href=\"", 1993, "\"", 2026, 2);
            WriteAttributeValue("", 2000, "/singlepage/index/", 2000, 18, true);
#nullable restore
#line 33 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\Favorites.cshtml"
WriteAttributeValue("", 2018, item.Id, 2018, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                    <h3>");
#nullable restore
#line 34 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\Favorites.cshtml"
                                                                   Write(item.Title_Pro);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                                                                </a>
                                                            </div>
                                                            <div class=""card-horizontal-product-price"">
                                                                <span>");
#nullable restore
#line 38 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\Favorites.cshtml"
                                                                 Write(item.Main_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" تومان</span>
                                                            </div>
                                                            <div class=""card-horizontal-product-price"">
                                                                <span>");
#nullable restore
#line 41 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\Favorites.cshtml"
                                                                 Write(item.Discount_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" تومان</span>
                                                            </div>
                                                            <div class=""card-horizontal-product-buttons"">
                                                                <a");
            BeginWriteAttribute("href", " href=\"", 2987, "\"", 3020, 2);
            WriteAttributeValue("", 2994, "/singlepage/index/", 2994, 18, true);
#nullable restore
#line 44 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\Favorites.cshtml"
WriteAttributeValue("", 3012, item.Id, 3012, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn\">مشاهده محصول</a>\r\n                                                                <a");
            BeginWriteAttribute("href", " href=\"", 3118, "\"", 3158, 2);
            WriteAttributeValue("", 3125, "/YourAccount/DelFavorite/", 3125, 25, true);
#nullable restore
#line 45 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\Favorites.cshtml"
WriteAttributeValue("", 3150, item.Id, 3150, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class="" remove-btn"">
                                                                    <i class=""mdi mdi-trash-can-outline""></i>
                                                                </a>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
");
#nullable restore
#line 52 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\Favorites.cshtml"
                                            }
                                            
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- End Content -->

                </div>
            </div>
        </main>
        <!-- End main-content -->");
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
