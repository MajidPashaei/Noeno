#pragma checksum "C:\Users\MS\Desktop\Noeno\New_Project\Views\Foot\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db7ea31ce7defac1e4cc2440aedc6c891914a9a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Foot_Contact), @"mvc.1.0.view", @"/Views/Foot/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db7ea31ce7defac1e4cc2440aedc6c891914a9a7", @"/Views/Foot/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Views/_ViewImports.cshtml")]
    public class Views_Foot_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            WriteLiteral(@"<style>
    a {
        color: orange;
    }

    a:hover {
        color: orange;
    }

    .header {
        color: black;
        margin-top: 20px;
        font-weight: bold;
        margin-right: 10px;
        margin-left: 10px;
    }

    .header2 {
        color: orange;
        margin-top: 20px;
        margin-bottom: 20px;
        font-weight: bold;
        margin-right: 10px;
        margin-left: 10px;
        font-size: large;
    }

    p {
        margin-right: 20px;
        margin-left: 20px;
    }

    h4,
    h5 {
        font-weight: bold;
    }
</style>
<div class=""container"">
    <div class=""mr-2 ml-2"">
        <div class=""mt-3"">
            <h5 class=""mb-5 mr-3"" style=""color: orange;"">&nbsp; </h5>
        </div>
        <div class=""mt-3 text-center"">
            <h4 class=""mb-5 header mr-3"">تماس با نوِنو</h4>
        </div>
        <div class=""mt-5"">
            <p>
                لطفا پیش از انجام هرگونه تماس با نونو، بخش‌های<a");
            BeginWriteAttribute("href", " href=\"", 1010, "\"", 1017, 0);
            EndWriteAttribute();
            WriteLiteral("> قوانین و شرایط استفاده از نونو</a>،<a");
            BeginWriteAttribute("href", " href=\"", 1057, "\"", 1064, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    راهنمای معامله در نوِنو</a>و<a");
            BeginWriteAttribute("href", " href=\"", 1118, "\"", 1125, 0);
            EndWriteAttribute();
            WriteLiteral(@"> سوالات متداول </a>را مطالعه کنید. در صورتی که نیاز به
                راهنمایی بیشتری دارید از فرم زیر استفاده کنید.
            </p>
        </div>
        <div class=""card-body row d-flex justify-content-center"">
            <div class=""col-xl-6"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db7ea31ce7defac1e4cc2440aedc6c891914a9a74991", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""exampleFormControlInput1"">نام و نام‌خانوادگی (ضروری)</label>
                        <input required type=""email"" class=""form-control"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleFormControlInput1"">ایمیل (ضروری)</label>
                        <input required type=""email"" class=""form-control"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleFormControlInput1"">شماره تماس (ضروری)</label>
                        <input required type=""email"" class=""form-control"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleFormControlInput1"">موضوع</label>
                        <input required type=""email"" class=""form-control"">
                    </div>
                    <div class=""form-group"">
                        <l");
                WriteLiteral(@"abel for=""exampleFormControlTextarea1"">پیغام شما</label>
                        <textarea class=""form-control"" rows=""3""></textarea>
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleFormControlFile1"">انتخاب فایل</label>
                        <input required type=""file"" class=""form-control-file"" id=""exampleFormControlFile1"">
                    </div>
                    <div class=""d-flex justify-content-center"">
                        <button class=""btn btn-warning btn-lg"">ارسال</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
        <hr>
        <div>
            <h4>اطلاعات دفتر نوِنو</h4>
            <h5> آدرس:</h5>
            <p> شیراز – زرقان – خیابان قیام- کوچه ۲ – واحد ۲- پلاک ۱۵۷</p>

            <h5>کد پستی:</h5>
            <p> ۷۳۴۱۶-۳۹۱۳۱</p>

            <h5>شماره تماس:</h5>
            <p>۰۷۱-۳۲۶۲-۷۲۰۴</p>

            <h5>شماره موبایل (در مواقع ضروری):</h5>
            <p>۰۹۱۰۷۷۸۶۹۵۳</p>

            <h5>ساعات کاری نونو:</h5>
            <p>پاسخگویی تلفنی: ۹ الی ۲۰</p>
            <p>پشتیبانی: هفت روز هفته / ۲۴ ساعت شبانه روز</p>

            <h5>ارتباط با نونو از طریق ایمیل:</h5>
            <p><a href=""https://info@noeno.ir"">info@noeno.ir</a> </p>
        </div>
    </div>
    <hr>
    <div>
        <div class=""mt-3 "">
            <h4 class=""mb-5 header mr-3"">نمایندگی‌های نونو</h4>
        </div>
        <div");
            BeginWriteAttribute("class", " class=\"", 3934, "\"", 3942, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"shadow-lg p-3 mb-5 bg-white rounded\">\r\n                <div id=\"accordion\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 4071, "\"", 4079, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 4111, "\"", 4119, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <a class=""header2"" data-toggle=""collapse"" href=""#collapse1"">
                                شیراز
                            </a>
                        </div>
                        <div id=""collapse1"" class=""collapse show"" data-parent=""#accordion"">
                            <h5> آدرس:</h5>
                            <p> شیراز – زرقان – خیابان قیام- کوچه ۲ – واحد ۲- پلاک ۱۵۷ </p>
                            <h5>تلفن:</h5>
                            <p>۰۷۱-۳۲۶۲-۷۲۰۴</p>
                            <h5>مسئول:</h5>
                            <p> آقای هوشنگ تدریسی، شماره همراه ۰۹۳۵۹۵۲۱۵۷۳</p>
                        </div>
                    </div>
                    <div");
            BeginWriteAttribute("class", " class=\"", 4852, "\"", 4860, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 4892, "\"", 4900, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <a class=""header2"" data-toggle=""collapse"" href=""#collapse2"">
                                تهران و کرج
                            </a>
                        </div>
                        <div id=""collapse2"" class=""collapse "" data-parent=""#accordion"">
                            <h5> آدرس:</h5>
                            <p>کرج، جاده ملارد، گلستان یکم، نسترن۲۵،پلاک۱۳، واحد۱۷</p>
                            <h5>تلفن:</h5>
                            <p>۰۲۶-۳۶۶۶-۸۵۷۴</p>
                            <h5>مسئول:</h5>
                            <p>آقای پیمان نمدی، شماره همراه  ۰۹۳۵۳۲۷۹۹۶۵</p>
                        </div>
                    </div>
                    <div");
            BeginWriteAttribute("class", " class=\"", 5628, "\"", 5636, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 5668, "\"", 5676, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <a class=""header2"" data-toggle=""collapse"" href=""#collapse3"">
                               اصفهان
                            </a>
                        </div>
                        <div id=""collapse3"" class=""collapse "" data-parent=""#accordion"">
                            <h5> آدرس:</h5>
                            <p>اصفهان، بلوار کشاورز، انتهای بلوار شفق، جنب بیمه البرز</p>
                            <h5>تلفن:</h5>
                            <p>۰۳۱-۳۷۷۹-۱۹۸۹</p>
                            <h5>مسئول:</h5>
                            <p>آقای مجتبی فیاض، شماره همراه  ۰۹۳۷۶۶۴۱۱۱۲</p>
                        </div>
                    </div>
                    <div");
            BeginWriteAttribute("class", " class=\"", 6401, "\"", 6409, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 6441, "\"", 6449, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <a class=""header2"" data-toggle=""collapse"" href=""#collapse4"">
                              بوشهر
                            </a>
                        </div>
                        <div id=""collapse4"" class=""collapse "" data-parent=""#accordion"">
                            <h5> آدرس:</h5>
                            <p>بوشهر، عالیشهر، فاز۲، خیابان انقلاب، مجتمع قائم</p>
                            <h5>تلفن:</h5>
                            <p>.</p>
                            <h5>مسئول:</h5>
                            <p>آقای اشکان احمدی، شماره همراه  ۰۹۹۰۱۳۹۱۷۸۰</p>
                        </div>
                    </div>
                    <div");
            BeginWriteAttribute("class", " class=\"", 7154, "\"", 7162, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 7194, "\"", 7202, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <a class=""header2"" data-toggle=""collapse"" href=""#collapse5"">
                             بوشهر- دشتی
                            </a>
                        </div>
                        <div id=""collapse5"" class=""collapse "" data-parent=""#accordion"">
                            <h5> آدرس:</h5>
                            <p>خورموج، خیابان شهید صیفی، کوچه۳</p>
                            <h5>تلفن:</h5>
                            <p>۰۷۷-۳۵۳۳-۰۸۵۴</p>
                            <h5>مسئول:</h5>
                            <p>آقای ابراهیم محمودی، شماره همراه  ۰۹۱۷۷۷۶۸۲۰۶</p>
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
