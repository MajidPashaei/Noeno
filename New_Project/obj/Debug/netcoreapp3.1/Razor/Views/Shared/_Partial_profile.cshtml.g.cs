#pragma checksum "C:\Users\MS\Desktop\Noeno\New_Project\Views\Shared\_Partial_profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c265d98022d67ac9fb0a20e5b9973d0109a62644"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Partial_profile), @"mvc.1.0.view", @"/Views/Shared/_Partial_profile.cshtml")]
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
#nullable restore
#line 1 "C:\Users\MS\Desktop\Noeno\New_Project\Views\Shared\_Partial_profile.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c265d98022d67ac9fb0a20e5b9973d0109a62644", @"/Views/Shared/_Partial_profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Partial_profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/profile.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/banner/sidebar-banner-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<!-- Start Sidebar -->
<div class=""col-xl-3 col-lg-4 col-md-4 col-sm-12 sticky-sidebar"">
    <div class=""profile-sidebar dt-sl"">

        <div class=""px-3"">
            <div style=""border-radius: 9px;"" class=""dt-sl dt-sn mb-1"">
                <div class=""profile-sidebar-header dt-sl"">
                    <div class=""profile-avatar float-right"">
");
#nullable restore
#line 11 "C:\Users\MS\Desktop\Noeno\New_Project\Views\Shared\_Partial_profile.cshtml"
                          
                            var b = HttpContextAccessor.HttpContext.Session.GetString("img");
                            if (b !=null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c265d98022d67ac9fb0a20e5b9973d0109a626445506", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 680, "~/FileUpload/", 680, 13, true);
#nullable restore
#line 15 "C:\Users\MS\Desktop\Noeno\New_Project\Views\Shared\_Partial_profile.cshtml"
AddHtmlAttributeValue("", 693, b, 693, 2, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\MS\Desktop\Noeno\New_Project\Views\Shared\_Partial_profile.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c265d98022d67ac9fb0a20e5b9973d0109a626447370", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\MS\Desktop\Noeno\New_Project\Views\Shared\_Partial_profile.cshtml"

                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"profile-header-content mr-3 mt-1 float-right\">\r\n                        <span class=\"d-block profile-username\">\r\n                            ");
#nullable restore
#line 26 "C:\Users\MS\Desktop\Noeno\New_Project\Views\Shared\_Partial_profile.cshtml"
                       Write(HttpContextAccessor.HttpContext.Session.GetString("name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                        <span\r\n                            class=\"d-block profile-phone\">");
#nullable restore
#line 29 "C:\Users\MS\Desktop\Noeno\New_Project\Views\Shared\_Partial_profile.cshtml"
                                                     Write(HttpContextAccessor.HttpContext.Session.GetString("mobile"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"profile-point mt-2 mb-1 dt-sl\">\r\n");
#nullable restore
#line 32 "C:\Users\MS\Desktop\Noeno\New_Project\Views\Shared\_Partial_profile.cshtml"
                           
                            var s = HttpContextAccessor.HttpContext.Session.GetString("RLink");
                                if (b !=null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"float-right label-profile-point\">کد معرف من:</span>\r\n                                    <a class=\"float-left value-profile-point\" href=\"/YourAccount/ShowInvite\">www.noeno.ir/invite/");
#nullable restore
#line 37 "C:\Users\MS\Desktop\Noeno\New_Project\Views\Shared\_Partial_profile.cshtml"
                                                                                                                            Write(s);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 38 "C:\Users\MS\Desktop\Noeno\New_Project\Views\Shared\_Partial_profile.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"float-right label-profile-point\"></span>\r\n                                    <a class=\"float-left value-profile-point\" href=\"#\"></a>\r\n");
#nullable restore
#line 43 "C:\Users\MS\Desktop\Noeno\New_Project\Views\Shared\_Partial_profile.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <div class=""profile-link mt-1 dt-sl"">
                        <div class=""row"">
                            <div class=""col-6 text-center"">
                                <a href=""#"">
                                    <i class=""mdi mdi-lock-reset""></i>
                                    <span class=""d-block"">تغییر رمز</span>
                                </a>
                            </div>
                            <div class=""col-6 text-center"">
                                <a href=""/home/exit"">
                                    <i class=""mdi mdi-logout-variant""></i>
                                    <span class=""d-block"">خروج از حساب</span>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

                        <div class=""dt-sl dt-sn mb-1 text-center"">
                            ");
            WriteLiteral("<a href=\"/YourAccount/ShowInvite\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c265d98022d67ac9fb0a20e5b9973d0109a6264412624", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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

                                
                        
                    <div class=""px-3 mb-1"">
                        <div class=""dt-sl mb-1 text-center "">
                            <a style=""font-size:15px"" href=""/CreateAdvertising/index""
                                class=""btn-primary-cm btn-with-icon ml-2 form-control"">
                                <i class=""mdi mdi-account-circle-outline ""></i>
                                ثبت کالای جدید
                            </a>
                        </div>
                    </div>
                    
                    
                    
                    <div class=""px-3"">
                                        <div");
            BeginWriteAttribute("style", " style=\"", 4245, "\"", 4253, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""  d-md-none d-lg-none d-xl-none"">
                                            <div class=""profile-menu-section "">
                                                <a  onclick=""myFunction()""  style=""font-size: 15px; text-align: center;""
                                                            class=""btn-primary-cm btn-with-icon ml-2 form-control"">
                                                            <i  class=""mdi mdi-chevron-down m1"" style=""color: white;""></i> 
                                                            <span style=""color: white;""> منوی کاربری</span>
                                                       
                                                </a>
                                    
                                                    <div style=""width: 325px; display: none; left: auto; right: auto; text-align: center; "" id=""myDIV"" class=""dropdown-menu profile-menu"">
                                                                                <ul>
    ");
            WriteLiteral(@"                                                        <li>
                                                                <a href=""/YourAccount/Profile"" class=""active"">
                                                                    <i class=""mdi mdi-account-circle-outline""></i> کالا های من
                                                                </a>
                                                            </li>
                                                            <li>
                                                                <a href=""/YourAccount/AccountMe"">
                                                                    <i class=""mdi mdi-basket""></i> کیف پول
                                                                </a>
                                                            </li>

                                                            <li>
                                                                <a href=""/YourAccount/Orders"">
           ");
            WriteLiteral(@"                                                         <i class=""mdi mdi-basket""></i> همه خرید ها
                                                                </a>
                                                            </li>
                                                            <li>
                                                                <a href=""/YourAccount/sales"">
                                                                    <i class=""mdi mdi-basket""></i> همه فروش ها
                                                                </a>
                                                            </li>
                                                            <li>
                                                                <a href=""/YourAccount/OrdersReturn"">
                                                                    <i class=""mdi mdi-backburger""></i> درخواست مرجوعی
                                                                </a>
                   ");
            WriteLiteral(@"                                         </li>
                                                            <li>
                                                                <a href=""/YourAccount/Favorites"">
                                                                    <i class=""mdi mdi-heart-outline""></i> لیست علاقمندی ها
                                                                </a>
                                                            </li>
                                                            <li>
                                                                <a href=""/YourAccount/additionalinfoshow"">
                                                                    <i class=""mdi mdi-account-edit-outline""></i> اطلاعات شخصی
                                                                </a>
                                                            </li>
                                                        </ul>
                                                 ");
            WriteLiteral(@"   
                                                </div>
                                            </div>
                                        </div>




                    </div>
  
            
            
            
            
            <div class=""dt-sl dt-sn mb-3 hidden-sm"">
                        <div class=""profile-menu-section dt-sl"">
                            <div class=""label-profile-menu mt-2 mb-2"">
                                <span>حساب کاربری شما</span>
                            </div>
                            <div class=""profile-menu"">
                                <ul>
                                    <li>
                                        <a href=""/YourAccount/Profile"" class=""active"">
                                            <i class=""mdi mdi-account-circle-outline""></i> کالا های من
                                        </a>
                                    </li>

                                    <li>
                ");
            WriteLiteral(@"                        <a href=""/YourAccount/AccountMe"">
                                            <i class=""mdi mdi-basket""></i>  کیف پول
                                        </a>
                                    </li>

                                    <li>
                                        <a href=""/YourAccount/Orders"">
                                            <i class=""mdi mdi-basket""></i> همه خرید ها
                                        </a>
                                    </li>
                                    <li>
                                                                <a href=""/YourAccount/sales"">
                                                                    <i class=""mdi mdi-basket""></i> همه فروش ها
                                                                </a>
                                                            </li>
                                    <li>
                                        <a href=""/YourAccount/OrdersRe");
            WriteLiteral(@"turn"">
                                            <i class=""mdi mdi-backburger""></i> درخواست مرجوعی
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""/YourAccount/Favorites"">
                                            <i class=""mdi mdi-heart-outline""></i> لیست علاقمندی ها
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""/YourAccount/additionalinfoshow"">
                                            <i class=""mdi mdi-account-edit-outline""></i> اطلاعات شخصی
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
             </div>
       

        

        

    </div>
</div>
<!-- End Sidebar -->

<");
            WriteLiteral(@"script>
    function myFunction() {

        var x = document.getElementById(""myDIV"");
        if (x.style.display === ""none"") {
            x.style.display = ""block"";
        } else {
            x.style.display = ""none"";
        }
    }
</script>");
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
