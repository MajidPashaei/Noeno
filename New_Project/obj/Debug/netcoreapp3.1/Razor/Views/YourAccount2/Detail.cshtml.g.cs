#pragma checksum "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c4f2afe85de87bc10be759b0ac1d5fd555067a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YourAccount2_Detail), @"mvc.1.0.view", @"/Views/YourAccount2/Detail.cshtml")]
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
#line 1 "c:\Users\ms\Desktop\Noeno\New_Project\Views\_ViewImports.cshtml"
using New_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\ms\Desktop\Noeno\New_Project\Views\_ViewImports.cshtml"
using New_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c4f2afe85de87bc10be759b0ac1d5fd555067a2", @"/Views/YourAccount2/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Views/_ViewImports.cshtml")]
    public class Views_YourAccount2_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" p-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100% ;height: 100%;border-radius: 15%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("p-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100% ;height: 100%;border-radius: 10%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            <div class=""card-heade  m-1"" style=""text-align: center;  "">
                <div class=""alert   alert-square ""
                    style=""background-color: #3D27B6;  color: #ffffff; box-shadow: 0 1px 12px 0 rgba(0,0,0,0.2);"">
                    <h4 style=""margin-top: 0rem; margin-bottom: 0rem; font-size: 17px;"" class=""card-title""> <span
                            style=""font-weight: bold; "" class=""text-light""> ثبت کالا جدید </h4>
                </div>
            </div>

            <div class=""col-xl-12 col-lg-12"">
                <div class=""card mb-2 pb-2"">
                    
                        
");
#nullable restore
#line 24 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
                             if (ViewBag.listp != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
                                 foreach (var item in ViewBag.listp)
                                {
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""col-12 row"">
                                            <div class=""col-12"">
                                                <label style=""font-weight: bold; font-size:16px; color: #59b63f;""
                                            class=""text-label"">
                                                    اطلاعات درخواست
                                                </label>
                                            </div>

                                            <div class=""col-6"">
                                                <label style=""font-weight: bold; font-size:14px"" class=""text-label"">
                                                    کد کالا:
                                                </label>
                                            </div>
                                            <div class=""col-6"">
                                                <p
                                            style=""font-wei");
            WriteLiteral("ght: bold; font-size: 14px; margin-right: 8px; margin-top: 5px;\">\r\n                                                    ");
#nullable restore
#line 45 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
                                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </p>
                                            </div>
                                            
                                            <div class=""col-6"">
                                                <label style=""font-weight: bold; font-size:14px"" class=""text-label"">
                                                    تاریخ ثبت:
                                                </label>
                                            </div>
                                            <div class=""col-6"">
                                                <p
                                            style=""font-weight: bold; font-size: 14px; margin-right: 8px; margin-top: 5px;"">
                                                    ");
#nullable restore
#line 57 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
                                               Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </p>
                                            </div>

                                            <div class=""col-6"">
                                                <label style=""font-weight: bold; font-size:14px"" class=""text-label"">
                                                    دسته اصلی:
                                                </label>
                                            </div>
                                            <div class=""col-6"">
                                                <p
                                            style=""font-weight: bold; font-size: 14px; margin-right: 8px; margin-top: 5px;"">
                                                    ");
#nullable restore
#line 69 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
                                               Write(item.FatherCat);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </p>
                                            </div>

                                            <div class=""col-6"">
                                                <label style=""font-weight: bold; font-size:14px"" class=""text-label"">
                                                    دسته فرعی :
                                                </label>
                                            </div>
                                            <div class=""col-6"">
                                                <p
                                            style=""font-weight: bold; font-size: 14px; margin-right: 8px; margin-top: 5px;"">
                                                     ");
#nullable restore
#line 81 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
                                                Write(item.Cat);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </p>
                                            </div>

                                            <div class=""col-6"">
                                                <label style=""font-weight: bold; font-size:14px"" class=""text-label"">
                                                    زیر دسته فرعی:
                                                </label>
                                            </div>
                                            <div class=""col-6"">
                                                <p
                                            style=""font-weight: bold; font-size: 14px; margin-right: 8px; margin-top: 5px;"">
                                                    ");
#nullable restore
#line 93 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
                                               Write(item.ChildCat);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </p>
                                            </div>
                                             

                                            <hr>
                                            <div class=""col-12"">
                                                <label style=""font-weight: bold; font-size:16px; color: #59b63f;""
                                            class=""text-label"">
                                                    اطلاعات عنوان و توضیحات
                                                </label>
                                            </div>

                                            <div class=""col-6"">
                                                <label style=""font-weight: bold; font-size:14px"" class=""text-label"">
                                                    عنوان:
                                                </label>
                                            </div>
                             ");
            WriteLiteral(@"               <div class=""col-6"">
                                                <p
                                            style=""font-weight: bold; font-size: 14px; margin-right: 8px; margin-top: 5px;"">
                                                     ");
#nullable restore
#line 114 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
                                                Write(item.Title_Pro);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </p>
                                            </div>

                                            <div class=""col-6"">
                                                <label style=""font-weight: bold; font-size:14px"" class=""text-label"">
                                                    توضیحات:
                                                </label>
                                            </div>
                                            <div class=""col-6"">
                                                <p
                                            style=""font-weight: bold; font-size: 14px; margin-right: 8px; margin-top: 5px;"">
                                                     ");
#nullable restore
#line 126 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
                                                Write(item.Discreption_Pro);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </p>
                                            </div>

                                            <hr>
                                            <div class=""col-12"">
                                                <label style=""font-weight: bold; font-size:16px; color: #59b63f;""
                                            class=""text-label"">
                                                    نوع
                                                </label>
                                            </div>

                                            <div class=""col-6"">
                                                <label style=""font-weight: bold; font-size:14px"" class=""text-label"">
                                                    نوع کالا:
                                                </label>
                                            </div>
                                            <div class=""col-6"">
                            ");
            WriteLiteral("                    <p\r\n                                            style=\"font-weight: bold; font-size: 14px; margin-right: 8px; margin-top: 5px;\">\r\n                                                   ");
#nullable restore
#line 146 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
                                              Write(item.Type_pro);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  
                                                </p>
                                            </div>

                                            <div class=""col-6"">
                                                <label style=""font-weight: bold; font-size:14px"" class=""text-label"">
                                                    نوع معامله :
                                                </label>
                                            </div>
                                            <div class=""col-6"">
                                                <p
                                            style=""font-weight: bold; font-size: 14px; margin-right: 8px; margin-top: 5px;"">
                                                   ");
#nullable restore
#line 158 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
                                              Write(item.Type_Transaction);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
                                                </p>
                                            </div>

                                             <div class=""col-6"">
                                                <label style=""font-weight: bold; font-size:14px"" class=""text-label"">
                                                    تعداد موجودی :
                                                </label>
                                            </div>
                                            <div class=""col-6"">
                                                <p
                                            style=""font-weight: bold; font-size: 14px; margin-right: 8px; margin-top: 5px;"">
                                                    ");
#nullable restore
#line 170 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
                                               Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" عدد
                                                </p>
                                            </div>
                                            <hr>
                                            <div class=""col-12"">
                                                <label style=""font-weight: bold; font-size:16px; color: #59b63f;""
                                            class=""text-label"">
                                                    قیمت گذاری
                                                </label>
                                            </div>
                                            <div class=""col-6"">
                                                <label style=""font-weight: bold; font-size:14px"" class=""text-label"">
                                                    قیمت کالا:
                                                </label>
                                            </div>
                                            <div class=""col-6"">
                    ");
            WriteLiteral("                            <p id=\"mp1\"\r\n                                            style=\"font-weight: bold; font-size: 14px; margin-right: 8px; margin-top: 5px;\">\r\n                                                    ");
#nullable restore
#line 188 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
                                               Write(item.Main_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" تومان
                                                </p>
                                            </div>
                                            <div class=""col-6"">
                                                <label style=""font-weight: bold; font-size:14px"" class=""text-label"">
                                                    قیمت با تخفیف کالا:
                                                </label>
                                            </div>
                                            <div class=""col-6"">
                                                <p id=""mp""
                                            style=""font-weight: bold; font-size: 14px; margin-right: 8px; margin-top: 5px;"">
                                                 ");
#nullable restore
#line 199 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
                                            Write(item.Discount_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" تومان
                                                </p>
                                            </div>
                                            <script>
                                                document.getElementById(""mp"").innerText=document.getElementById(""mp"").innerText.toString().replace(/\B(?=(\d{3})+(?!\d))/g, "","");
                                                document.getElementById(""mp1"").innerText=document.getElementById(""mp1"").innerText.toString().replace(/\B(?=(\d{3})+(?!\d))/g, "","");
                                            </script>
                                            <hr>
                                            <div class=""col-12"">
                                                <label style=""font-weight: bold; font-size:16px; color: #59b63f;""
                                            class=""text-label"">
                                                    عکس های کالا
                                                </label>
                     ");
            WriteLiteral(@"                       </div>
                                            <div class=""col-6"">
                                                <label style=""font-weight: bold; font-size:14px"" class=""text-label"">
                                                    عکس اصلی:
                                                </label>
                                            </div>
                                            <div class=""row"">
                                                <div class=""col-6"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6c4f2afe85de87bc10be759b0ac1d5fd555067a222129", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 13971, "~/fileupload/", 13971, 13, true);
#nullable restore
#line 220 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
AddHtmlAttributeValue("", 13984, item.Image, 13984, 11, false);

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
                                                <div class=""col-6 text-danger"">
                                                
                                                        (برای مشاهده کامل عکس  روی عکس مورد نظر کلیک کنید)
                                                </div>
                                            </div>
                                            
                                        </div>
");
            WriteLiteral("                                    <div class=\"row\">\r\n");
#nullable restore
#line 231 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
                                     if (ViewBag.FImage != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                               <div class=""col-12 mb-1"">
                                                    <label style=""font-weight: bold; font-size:14px"" class=""text-label"">
                                                        عکس های فرعی:
                                                       
                                                    </label>
                                                </div>
");
#nullable restore
#line 239 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
                                                 

                                            foreach (var item1 in ViewBag.FImage)
                                            {
                                                
                                            

                                              

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"col-4 mb-1\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6c4f2afe85de87bc10be759b0ac1d5fd555067a225750", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 15672, "~/fileupload/", 15672, 13, true);
#nullable restore
#line 248 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
AddHtmlAttributeValue("", 15685, item1.ImagePath, 15685, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </div>\r\n");
#nullable restore
#line 250 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
                                                   }
                                                  

                                       
                                        } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                          </div>\r\n                                          <hr>\r\n");
            WriteLiteral("                                <div class=\"row\">\r\n                                    <div class=\"col-6 mb-1\">\r\n                                        <a  onclick=\"return confirm(\'آیا از حذف آیتم مطمئن هستید؟\');\"");
            BeginWriteAttribute("href", "  href=\"", 17352, "\"", 17387, 2);
            WriteAttributeValue("", 17360, "/YourAccount/Del?b=", 17360, 19, true);
#nullable restore
#line 276 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
WriteAttributeValue("", 17379, item.Id, 17379, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-sm btn-danger btn-block hover1 text-light""
                                            style=""font-weight: bold; font-size:16px;  border-color: green;""> حذف </a>
                                    </div>
                                    <div class=""col-6 mb-1"">
                                        <a  href=""/YourAccount/Profile"" style=""font-weight: bold; font-size:16px;  border-color: green;""
                                            class=""btn btn-sm btn-info btn-block hover1 text-light""> بازگشت </a>
                                    </div>
                                </div>
");
#nullable restore
#line 284 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
                                
                           
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 286 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount2\Detail.cshtml"
                                  ;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                    \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n</div>");
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
