#pragma checksum "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29c1a88c323ff672d0b74a5c7962109456b07f8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Category4), @"mvc.1.0.view", @"/Views/Home/Category4.cshtml")]
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
#line 1 "e:\project\Noeno\Noeno\New_Project\Views\_ViewImports.cshtml"
using New_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "e:\project\Noeno\Noeno\New_Project\Views\_ViewImports.cshtml"
using New_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29c1a88c323ff672d0b74a5c7962109456b07f8c", @"/Views/Home/Category4.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Category4 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("text1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- Start main-content -->
<main class=""main-content dt-sl mt-4 mb-3"">
    <div class=""header-cover"">
        <div class=""promotion-header-img""></div>
    </div>
    <div class=""container main-container mt-5"">
        <div class=""row"">


            <!-- Start Sidebar -->
            <div class=""col-lg-3 col-md-12 col-sm-12 sticky-sidebar hidden-sm"">
                <div class=""dt-sn mb-3"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29c1a88c323ff672d0b74a5c7962109456b07f8c4651", async() => {
                WriteLiteral(@"
                        <div class=""col-12"">
                            <div class=""section-title text-sm-title title-wide mb-1 no-after-title-wide"">
                                <h2>فیلتر محصولات</h2>
                            </div>
                        </div>
                        <div class=""col-12 mb-3"">
                            <div class=""widget-search"">
                                <input type=""text"" name=""s"" placeholder=""نام محصول یا برند مورد نظر را بنویسید..."">
                                <button class=""btn-search-widget"">
                                    <img src=""./assets/img/theme/search.png""");
                BeginWriteAttribute("alt", " alt=\"", 1093, "\"", 1099, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </button>
                            </div>
                        </div>
                        <div class=""col-12 filter-product mb-3"">
                            <div class=""accordion"" id=""accordionExample"">
                                <div class=""card"">
                                    <div class=""card-header"" id=""headingOne"">
                                        <h2 class=""mb-0"">
                                            <button class=""btn btn-block text-right collapsed"" type=""button""
                                                data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""false""
                                                aria-controls=""collapseOne"">
                                                 نوع کالا
                                                <i class=""mdi mdi-chevron-down""></i>
                                            </button>
                                        </h2>
                       ");
                WriteLiteral(@"             </div>
                                    <div id=""collapseOne"" class=""collapse"" aria-labelledby=""headingOne""
                                        data-parent=""#accordionExample"">
                                        <div class=""card-body"">
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck1"">
                                                <label class=""custom-control-label"" for=""customCheck1"">همه</label>
                                            </div>
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck2"">
                                                <label class=""custom-control-label"" for=""customCheck2""> کالای کسب و کار محلی و خانگی </label>
                            ");
                WriteLiteral(@"                </div>
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck3"">
                                                <label class=""custom-control-label"" for=""customCheck3""> کالای نو استفاده نشده </label>
                                            </div>
                                            
                                        </div>
                                    </div>
                                </div>
                                <div class=""card"">
                                    <div class=""card-header"" id=""headingTwo"">
                                        <h2 class=""mb-0"">
                                            <button class=""btn btn-block text-right collapsed"" type=""button""
                                                data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false""
   ");
                WriteLiteral(@"                                             aria-controls=""collapseTwo"">
                                                نوع معامله
                                                <i class=""mdi mdi-chevron-down""></i>
                                            </button>
                                        </h2>
                                    </div>
                                    <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo""
                                        data-parent=""#accordionExample"">
                                        <div class=""card-body"">
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck7"">
                                                <label class=""custom-control-label"" for=""customCheck7"">همه</label>
                                            </div>
                                   ");
                WriteLiteral(@"         <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck8"">
                                                <label class=""custom-control-label"" for=""customCheck8"">بصورت مستقیم از فروشنده</label>
                                            </div>
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck9"">
                                                <label class=""custom-control-label"" for=""customCheck9"">از طریق سیستم بازرسی کالا</label>
                                            </div>
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck10"">
                                                <l");
                WriteLiteral(@"abel class=""custom-control-label"" for=""customCheck10""> بر عهده خریدار </label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-12 mb-4"">
                            <div class=""section-title text-sm-title title-wide no-after-title-wide mb-1"">
                                <h2>فیلتر براساس قیمت :</h2>
                            </div>
                            <div class=""mt-2 mb-2"">
                                <div id=""slider-non-linear-step""></div>
                            </div>
                            <div class=""mt-2 mb-2 text-center pt-2"">
                                <input type=""number"" class=""ml-1"" min=""0"" style=""width: 100px; border: 1px solid gray; border-radius: 10px;"" placeholder=""قیمت از :"">تا <input type=""number"" max=""90000000"" ");
                WriteLiteral(@" style=""width: 100px; border: 1px solid gray; border-radius: 10px;"" placeholder=""قیمت تا:"">
                                <span class=""example-val"" id=""slider-non-linear-step-value""></span> تومان
                            </div>
                        </div>
                        <div class=""col-12 mb-3"">
                            <div class=""parent-switcher"">
                                <label class=""ui-statusswitcher"">
                                    <input type=""checkbox"" id=""switcher-1"">
                                    <span class=""ui-statusswitcher-slider"">
                                        <span class=""ui-statusswitcher-slider-toggle""></span>
                                    </span>
                                </label>
                                <label class=""label-switcher"" for=""switcher-1"">فقط کالاهای موجود</label>
                            </div>
                        </div>
                        <div class=""col-12"">
                       ");
                WriteLiteral("     <button class=\"btn btn-info btn-block\" type=\"submit\">\r\n                                فیلتر\r\n                            </button>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            <!-- End Sidebar -->


            <!-- Start Sidebar -->
            <div class=""col-lg-3 col-md-12 col-sm-12 sticky-sidebar d-md-none d-lg-none d-xl-none"">
                <div class=""dt-sn mb-3"">
                    <div class=""col-12"">
                        <div class=""section-title text-sm-title title-wide mb-1 no-after-title-wide"">
                            <input type=""checkbox""  id=""myCheck1"" onclick=""myFunction1()"">
                            <label class=""m-1 p-1""> فیلتر محصولات </label>
                        </div>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29c1a88c323ff672d0b74a5c7962109456b07f8c15275", async() => {
                WriteLiteral(@"
                        <div class=""col-12"">
                            <div class=""section-title text-sm-title title-wide mb-1 no-after-title-wide"">
                                <h2>فیلتر محصولات</h2>
                            </div>
                        </div>
                        <div class=""col-12 mb-3"">
                            <div class=""widget-search"">
                                <input type=""text"" name=""s"" placeholder=""نام محصول یا برند مورد نظر را بنویسید..."">
                                <button class=""btn-search-widget"">
                                    <img src=""./assets/img/theme/search.png""");
                BeginWriteAttribute("alt", " alt=\"", 9817, "\"", 9823, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </button>
                            </div>
                        </div>
                        <div class=""col-12 filter-product mb-3"">
                            <div class=""accordion"" id=""accordionExample"">
                                <div class=""card"">
                                    <div class=""card-header"" id=""headingOne"">
                                        <h2 class=""mb-0"">
                                            <button class=""btn btn-block text-right collapsed"" type=""button""
                                                data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""false""
                                                aria-controls=""collapseOne"">
                                                 نوع کالا
                                                <i class=""mdi mdi-chevron-down""></i>
                                            </button>
                                        </h2>
                       ");
                WriteLiteral(@"             </div>
                                    <div id=""collapseOne"" class=""collapse"" aria-labelledby=""headingOne""
                                        data-parent=""#accordionExample"">
                                        <div class=""card-body"">
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck1"">
                                                <label class=""custom-control-label"" for=""customCheck1"">همه</label>
                                            </div>
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck2"">
                                                <label class=""custom-control-label"" for=""customCheck2""> کالای کسب و کار محلی و خانگی </label>
                            ");
                WriteLiteral(@"                </div>
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck3"">
                                                <label class=""custom-control-label"" for=""customCheck3""> کالای نو استفاده نشده </label>
                                            </div>
                                            
                                        </div>
                                    </div>
                                </div>
                                <div class=""card"">
                                    <div class=""card-header"" id=""headingTwo"">
                                        <h2 class=""mb-0"">
                                            <button class=""btn btn-block text-right collapsed"" type=""button""
                                                data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false""
   ");
                WriteLiteral(@"                                             aria-controls=""collapseTwo"">
                                                نوع معامله
                                                <i class=""mdi mdi-chevron-down""></i>
                                            </button>
                                        </h2>
                                    </div>
                                    <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo""
                                        data-parent=""#accordionExample"">
                                        <div class=""card-body"">
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck7"">
                                                <label class=""custom-control-label"" for=""customCheck7"">همه</label>
                                            </div>
                                   ");
                WriteLiteral(@"         <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck8"">
                                                <label class=""custom-control-label"" for=""customCheck8"">بصورت مستقیم از فروشنده</label>
                                            </div>
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck9"">
                                                <label class=""custom-control-label"" for=""customCheck9"">از طریق سیستم بازرسی کالا</label>
                                            </div>
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck10"">
                                                <l");
                WriteLiteral(@"abel class=""custom-control-label"" for=""customCheck10""> بر عهده خریدار </label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-12 mb-4"">
                            <div class=""section-title text-sm-title title-wide no-after-title-wide mb-1"">
                                <h2>فیلتر براساس قیمت :</h2>
                            </div>
                            <div class=""mt-2 mb-2"">
                                <div id=""slider-non-linear-step""></div>
                            </div>
                            <div class=""mt-2 mb-2 text-center pt-2"">
                                <input type=""number"" class=""ml-1"" min=""0"" style=""width: 100px; border: 1px solid gray; border-radius: 10px;"" placeholder=""قیمت از :"">تا <input type=""number"" max=""90000000"" ");
                WriteLiteral(@" style=""width: 100px; border: 1px solid gray; border-radius: 10px;"" placeholder=""قیمت تا:"">
                                <span class=""example-val"" id=""slider-non-linear-step-value""></span> تومان
                            </div>
                        </div>
                        <div class=""col-12 mb-3"">
                            <div class=""parent-switcher"">
                                <label class=""ui-statusswitcher"">
                                    <input type=""checkbox"" id=""switcher-1"">
                                    <span class=""ui-statusswitcher-slider"">
                                        <span class=""ui-statusswitcher-slider-toggle""></span>
                                    </span>
                                </label>
                                <label class=""label-switcher"" for=""switcher-1"">فقط کالاهای موجود</label>
                            </div>
                        </div>
                        <div class=""col-12"">
                       ");
                WriteLiteral("     <button class=\"btn btn-info btn-block\" type=\"submit\">\r\n                                فیلتر\r\n                            </button>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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

            <script>
                function myFunction1() {
                    // Get the checkbox
                    var checkBox = document.getElementById(""myCheck1"");
                    // Get the output text
                    var text = document.getElementById(""text1"");

                    // If the checkbox is checked, display the output text
                    if (checkBox.checked == true) {
                        text.style.display = ""block"";
                    } else {
                        text.style.display = ""none"";
                    }
                }
            </script>
            <!-- End Sidebar -->

            <!-- Start Content -->
            <div class=""col-lg-9 col-md-12 col-sm-12 "">
                <div class=""dt-sl dt-sn row"">
");
#nullable restore
#line 271 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
                      if (ViewBag.oll!=null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 273 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
                                     foreach (var item in ViewBag.oll)
                                    { 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""col-lg-4 col-xl-3 m-1 card col-md-4 col-sm-12 col-12  mb-1 d-flex"">
                                            <div class="" mt-1 justify-content-center"" style=""height: 260px; width: 220px;"">
                                                            
                                                                <div class=""about-product text-center mt-1 p-1"" style=""height:160px; width: 230px;"">
                                                                    <a class=""product-thumb""");
            BeginWriteAttribute("href", " href=\"", 18779, "\"", 18812, 2);
            WriteAttributeValue("", 18786, "/SinglePage/index/", 18786, 18, true);
#nullable restore
#line 279 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
WriteAttributeValue("", 18804, item.Id, 18804, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"   border-radius: 5%;\">\r\n                                                                        <img");
            BeginWriteAttribute("src", " src=\"", 18922, "\"", 18951, 2);
            WriteAttributeValue("", 18928, "/FileUpload/", 18928, 12, true);
#nullable restore
#line 280 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
WriteAttributeValue("", 18940, item.Image, 18940, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Product Thumbnail""  style="" border-radius: 10%;  width: 100%; height: 150px;"">
                                                                    </a>
                                                                </div>
                                                                <div class=""stats "">
                                                            <h6 class=""mt-0 text-black-50""> <a style="" font-size: 14px;"" class=""text-warning""");
            BeginWriteAttribute("href", " href=\"", 19411, "\"", 19444, 2);
            WriteAttributeValue("", 19418, "/SinglePage/index/", 19418, 18, true);
#nullable restore
#line 284 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
WriteAttributeValue("", 19436, item.Id, 19436, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 284 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
                                                                                                                                                                           Write(item.Title_Pro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                                            <div class=\"d-flex justify-content-between p-price\"> <a class=\"product-meta\" style=\"color: gray; \"");
            BeginWriteAttribute("href", " href=\"", 19630, "\"", 19663, 2);
            WriteAttributeValue("", 19637, "/SinglePage/index/", 19637, 18, true);
#nullable restore
#line 285 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
WriteAttributeValue("", 19655, item.Id, 19655, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 285 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
                                                                                                                                                                                            Write(item.Type_pro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                                                            <div class=\"d-flex justify-content-between p-price\"><del style=\"color: red;\"");
            BeginWriteAttribute("id", "  id=\"", 19827, "\"", 19841, 1);
#nullable restore
#line 286 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
WriteAttributeValue("", 19833, item.Id, 19833, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 286 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
                                                                                                                                                   Write(item.Main_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                                                            <span style=\"color: gray;\"");
            BeginWriteAttribute("id", " id=\"", 19953, "\"", 19974, 2);
#nullable restore
#line 287 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
WriteAttributeValue("", 19958, item.Id, 19958, 8, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 287 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
WriteAttributeValue("", 19966, item.Id, 19966, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 287 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
                                                                                                        Write(item.Discount_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" تومان </span></div>
                                                        </div>
                                                            
                                                            
                                                            <script>
                                                                document.getElementById(""");
#nullable restore
#line 292 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
                                                                                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").innerText=document.getElementById(\"");
#nullable restore
#line 292 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
                                                                                                                                  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").innerText.toString().replace(/\\B(?=(\\d{3})+(?!\\d))/g, \",\");\r\n                                                                document.getElementById(\"");
#nullable restore
#line 293 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
                                                                                    Write(item.Id);

#line default
#line hidden
#nullable disable
#nullable restore
#line 293 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
                                                                                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").innerText=document.getElementById(\"");
#nullable restore
#line 293 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
                                                                                                                                          Write(item.Id);

#line default
#line hidden
#nullable disable
#nullable restore
#line 293 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
                                                                                                                                                  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""").innerText.toString().replace(/\B(?=(\d{3})+(?!\d))/g, "","");
                                                            </script>

                                            </div>
                                        
                                        </div>
");
#nullable restore
#line 299 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 299 "e:\project\Noeno\Noeno\New_Project\Views\Home\Category4.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <!-- End Content -->\r\n\r\n        </div>\r\n\r\n    </div>\r\n</main>\r\n<!-- End main-content -->");
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
