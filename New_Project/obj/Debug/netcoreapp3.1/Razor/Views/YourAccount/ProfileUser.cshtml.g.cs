#pragma checksum "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82432688de6f77be167966a92bcbe92e8252ffdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YourAccount_ProfileUser), @"mvc.1.0.view", @"/Views/YourAccount/ProfileUser.cshtml")]
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
#line 1 "C:\Users\MS\Desktop\Noeno\New_Project\Views\_ViewImports.cshtml"
using New_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MS\Desktop\Noeno\New_Project\Views\_ViewImports.cshtml"
using New_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82432688de6f77be167966a92bcbe92e8252ffdf", @"/Views/YourAccount/ProfileUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Views/_ViewImports.cshtml")]
    public class Views_YourAccount_ProfileUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/theme/chat-cart.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/theme/Sh.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("24px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
        <!-- Start main-content -->
        <main class=""main-content dt-sl mt-4 mb-3"">
            <div class=""container main-container"">
                <div >
                     <div class=""px-3"">
            <div style=""border-radius: 9px; background-image: url(../assets/img/theme/bkg.png);"" class=""dt-sl dt-sn mb-3"">
                <div class=""profile-sidebar-header dt-sl"">
");
#nullable restore
#line 9 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"
                     if (ViewBag.I != null)
                    {
                        foreach(var item in ViewBag.I){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"row profile-avatar float-right\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "82432688de6f77be167966a92bcbe92e8252ffdf6057", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 658, "~/FileUpload/", 658, 13, true);
#nullable restore
#line 13 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"
AddHtmlAttributeValue("", 671, item.Image, 671, 11, false);

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
            WriteLiteral("\r\n                                    <div class=\"profile-header-content mr-3 mt-2 float-right\">\r\n                                        <span class=\"d-block profile-username\"  style=\"font-size: 12px;\">\r\n                                            ");
#nullable restore
#line 16 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"
                                       Write(item.NameFamily);

#line default
#line hidden
#nullable disable
            WriteLiteral("  |  ");
#nullable restore
#line 16 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"
                                                            Write(item.State);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ، ");
#nullable restore
#line 16 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"
                                                                          Write(item.city);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </span>\r\n                                        <span  style=\"font-size: 12px;\">\r\n                                            ");
#nullable restore
#line 19 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"
                                       Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  | 
                                        </span>
                                    </div>
                            </div>
                            <div class=""profile-point mt-3 mb-2 dt-sl"">
                            <div class=""row"" style=""display: flex; justify-content: center;"">
                                <span class=""mr-2 ml-2  label-profile-point"">تعداد کالا</span>
                                <span class=""mr-2 ml-2  label-profile-point"">مدت فعالیت</span>
                                <span class=""mr-2 ml-2  label-profile-point"">معامله در نو نو</span>
                            </div>
                            <div class=""row"" style=""display: flex; justify-content: center;"">
                                
                                <span class=""mr-3 ml-5 mb-1"">");
#nullable restore
#line 31 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"
                                                        Write(ViewBag.b);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                <span class=""mr-3 ml-3  mb-1"">6 ماه </span>
                                <span class=""mr-5 ml-1  mb-1"">25  موفق</span>
                            </div>
                            </div>
                            <div class=""profile-link mt-2 dt-sl"">
                                <div class=""row"">
                                    <div class=""col-6 text-center"">
                                        <a style=""background-color:#1F8BFF  ;color: #fff;  font-size: 12px;"" href=""#"" class=""btn-primary-cm   btn-with-icon"" >
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "82432688de6f77be167966a92bcbe92e8252ffdf10933", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            چت با فروشنده
                                        </a>
                                    </div>
                                    <div class=""col-6 text-center"">
                                        <a style=""background-color:#90A4AE  ;color: #fff;  font-size: 12px;"" href=""#"" class=""btn-primary-cm   btn-with-icon"" >
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "82432688de6f77be167966a92bcbe92e8252ffdf12489", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" اشترلک گذاری\r\n                                        </a> \r\n                                    </div>\r\n                                </div>\r\n                            </div> \r\n");
#nullable restore
#line 51 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"

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

                <div class=""row"">
                    <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 mb-2 px-0"">
                        <nav class=""tab-cart-page"">
                            <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
                                <a  id=""nav-home-tab"" data-toggle=""tab"" href=""#nav-home"" role=""tab"" aria-controls=""nav-home"" aria-selected=""true"">لیست کالا های فروشنده </a>
                            </div>
                        </nav>
                    </div>
                    <div class=""col-12"">
                        <div class=""tab-content"" id=""nav-tabContent"">
                            <div class=""tab-pane fade show active"" id=""nav-home"" role=""tabpanel"" aria-labelledby=""nav-home-tab"">


                                            <section class=""slider-section dt-sl "">
                                   ");
            WriteLiteral("                     <div class=\"row p-2\"");
            BeginWriteAttribute("style", " style=\"", 4521, "\"", 4529, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <a class=""btn btn-warning"" href=""#"">مشاهده همه</a>
                                                        </div>
                                                        <div class=""product-carousel carousel-lg owl-carousel owl-theme"">

");
#nullable restore
#line 81 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"
               if ( ViewBag.q != null)
                        {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"
                         foreach (var item in ViewBag.q)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            <div class=""item"">
                                                                <div class=""product-card mb-3"">
                                                                    <a class=""product-thumb""");
            BeginWriteAttribute("href", " href=\"", 5255, "\"", 5288, 2);
            WriteAttributeValue("", 5262, "/SinglePage/index/", 5262, 18, true);
#nullable restore
#line 87 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"
WriteAttributeValue("", 5280, item.Id, 5280, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                        <img");
            BeginWriteAttribute("src", " src=\"", 5368, "\"", 5397, 2);
            WriteAttributeValue("", 5374, "/fileupload/", 5374, 12, true);
#nullable restore
#line 88 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"
WriteAttributeValue("", 5386, item.Image, 5386, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Product Thumbnail"">
                                                                    
                                                                    <div class=""product-card-body"">
                                                                        <h5 class=""product-title"">
                                                                            <a");
            BeginWriteAttribute("href", " href=\"", 5774, "\"", 5807, 2);
            WriteAttributeValue("", 5781, "/SinglePage/index/", 5781, 18, true);
#nullable restore
#line 92 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"
WriteAttributeValue("", 5799, item.Id, 5799, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 92 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"
                                                                                                            Write(item.Title_Pro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                                        </h5>\r\n                                                                        <a class=\"product-meta\"");
            BeginWriteAttribute("href", " href=\"", 6004, "\"", 6037, 2);
            WriteAttributeValue("", 6011, "/SinglePage/index/", 6011, 18, true);
#nullable restore
#line 94 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"
WriteAttributeValue("", 6029, item.Id, 6029, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 94 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"
                                                                                                                             Write(item.Discount_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                                                                        <span class=\"product-price\">");
#nullable restore
#line 95 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"
                                                                                               Write(item.Main_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                                                                        <span class=\"product-price\">");
#nullable restore
#line 96 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"
                                                                                               Write(item.Type_pro);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
                                                                    </div>
                                                                    </a>
                                                                </div>
                                                            </div>
");
#nullable restore
#line 101 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"



}

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\MS\Desktop\Noeno\New_Project\Views\YourAccount\ProfileUser.cshtml"
 
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        </div>           
                                            </section>
                               



                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </main>
        <!-- End main-content -->
");
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
