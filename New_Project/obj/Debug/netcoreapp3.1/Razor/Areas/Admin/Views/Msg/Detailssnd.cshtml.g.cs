#pragma checksum "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf48a08a2b146693027b9ac7b41349f46dbb8913"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Msg_Detailssnd), @"mvc.1.0.view", @"/Areas/Admin/Views/Msg/Detailssnd.cshtml")]
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
#line 1 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
using New_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
using New_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf48a08a2b146693027b9ac7b41349f46dbb8913", @"/Areas/Admin/Views/Msg/Detailssnd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Msg_Detailssnd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel.AdminViewModel.Message.Vm_Message>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("select2 form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("موضوع"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("پیام خود را  بنویسید"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cols", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-file-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/msg/add_msg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app-assets/images/icons/alert.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("61"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--
Template Name: Vuexy - Vuejs, HTML & Laravel Admin Dashboard Template
Author: PixInvent
Website: http://www.pixinvent.com/
Contact: hello@pixinvent.com
Follow: www.twitter.com/pixinvents
Like: www.facebook.com/pixinvents
Purchase: https://www.rtl-theme.com/vuexy-admin-html-template/
Renew Support: https://www.rtl-theme.com/vuexy-admin-html-template/
License: You must have a valid license purchased only from themeforest(the above link) in order to legally use the theme for your project.

-->

    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui"">
    <meta name=""description"" content=""Vuexy admin is super flexible, powerful, clean &amp; modern responsive bootstrap 4 admin template with unlimited possibilities."">
    <meta name=""keywords"" content=""admin template, Vuexy admin template, dashboard template, flat admin");
            WriteLiteral(@" template, responsive admin template, web app"">
    <meta name=""author"" content=""PIXINVENT"">
    
    <link rel=""apple-touch-icon"" href=""../../../app-assets/images/ico/apple-icon-120.png"">
    <link rel=""shortcut icon"" type=""image/x-icon"" href=""..\..\..\app-assets\images\ico\favicon.ico"">
    <link href=""..\..\..\app-assets\images\fonts.googleapis.css"" rel=""stylesheet"">

    <!-- BEGIN: Vendor CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\vendors\css\vendors-rtl.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\vendors\css\editors\quill\katex.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\vendors\css\editors\quill\monokai-sublime.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\vendors\css\editors\quill\quill.snow.css"">
    <!-- END: Vendor CSS-->

    <!-- BEGIN: Theme CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\bootstrap.min.css"">
  ");
            WriteLiteral(@"  <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\bootstrap-extended.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\colors.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\components.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\themes\dark-layout.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\themes\semi-dark-layout.min.css"">

    <!-- BEGIN: Page CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\core\menu\menu-types\horizontal-menu.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\core\colors\palette-gradient.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\pages\app-email.min.css"">
    <!-- END: Page CSS-->

    <!-- BEGIN: Custom CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\");
            WriteLiteral(@"css-rtl\custom-rtl.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""../assets/css/style-rtl.css"">
    <!-- END: Custom CSS-->

  
    <!-- BEGIN: Header-->
   
    <!-- END: Header-->


    <!-- BEGIN: Main Menu-->
    
    <!-- END: Main Menu-->

    <!-- BEGIN: Content-->
");
#nullable restore
#line 63 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
        if (ViewBag.err != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"alert alert-success\">");
#nullable restore
#line 65 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
                                          Write(ViewBag.err);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 66 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"      <div class=""content-area-wrapper"" style=""margin-top: 0 !important ;"">
        <div class=""sidebar-left"">
          <div class=""sidebar""><div class=""sidebar-content email-app-sidebar d-flex"">
         
  <span class=""sidebar-close-icon"">
    <i class=""feather icon-x""></i>
  </span>
  <div class=""email-app-menu"">
    <div class=""form-group form-group-compose text-center compose-btn"">
      <button type=""button"" class=""btn btn-primary btn-block my-2"" data-toggle=""modal"" data-target=""#composeForm""><i class=""feather icon-edit""></i>ساختن</button>
    </div>
    <div class=""sidebar-menu-list"">
      <div class=""list-group list-group-messages font-medium-1"">
        <a href=""/admin/msg/index"" class=""list-group-item list-group-item-action border-0 pt-0 active"">
          <i class=""font-medium-5 feather icon-mail mr-50""></i>  صندوق ورودی<span class=""badge badge-primary badge-pill float-right"">");
#nullable restore
#line 81 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
                                                                                                                                Write(ViewBag.resiver);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </a>\r\n        <a href=\"/admin/msg/send\" class=\"list-group-item list-group-item-action border-0\"><i class=\"font-medium-5 fa fa-paper-plane-o mr-50\"></i>  ارسال شد<span class=\"badge badge-warning badge-pill float-right\">");
#nullable restore
#line 83 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
                                                                                                                                                                                                               Write(ViewBag.sender);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></a>
        <a href=""#"" class=""list-group-item list-group-item-action border-0""><i class=""font-medium-5 feather icon-edit-2 mr-50""></i>  پیش نویس<span class=""badge badge-warning badge-pill float-right"">4</span> </a>
        <a href=""#"" class=""list-group-item list-group-item-action border-0""><i class=""font-medium-5 feather icon-star mr-50""></i> ستاره دار</a>
        <a href=""#"" class=""list-group-item list-group-item-action border-0""><i class=""font-medium-5 feather icon-info mr-50""></i> هرزنامه ها<span class=""badge badge-danger badge-pill float-right"">3</span> </a>
        <a href=""#"" class=""list-group-item list-group-item-action border-0""><i class=""font-medium-5 feather icon-trash mr-50""></i> زباله ها</a>
      </div>
      <hr>
      <h5 class=""my-2 pt-25"">برچسب ها</h5>
      <div class=""list-group list-group-labels font-medium-1"">
        <a href=""#"" class=""list-group-item list-group-item-action border-0 d-flex align-items-center""><span class=""bullet bullet-success mr-1""></span>  شخصی</a>
 ");
            WriteLiteral(@"       <a href=""#"" class=""list-group-item list-group-item-action border-0 d-flex align-items-center""><span class=""bullet bullet-primary mr-1""></span>  شرکت</a>
        <a href=""#"" class=""list-group-item list-group-item-action border-0 d-flex align-items-center""><span class=""bullet bullet-warning mr-1""></span>  مهم</a>
        <a href=""#"" class=""list-group-item list-group-item-action border-0 d-flex align-items-center""><span class=""bullet bullet-danger mr-1""></span>  خصوصی</a>
      </div>
    </div>
  </div>
</div>
<!-- Modal -->
<div class=""modal fade text-left"" id=""composeForm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""emailCompose"" aria-hidden=""true"">
  <div class=""modal-dialog modal-dialog-scrollable"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf48a08a2b146693027b9ac7b41349f46dbb891317189", async() => {
                WriteLiteral(@"
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h3 class=""modal-title text-text-bold-600"" id=""emailCompose"">پیام جدید</h3>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body pt-1"">
        <div class=""form-label-group mt-1"">
         	");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf48a08a2b146693027b9ac7b41349f46dbb891317883", async() => {
                    WriteLiteral("\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 113 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ResiverMess);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 113 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.list;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          <label for=\"emailTo\">به</label>\r\n        </div>\r\n        <div class=\"form-label-group\">\r\n          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf48a08a2b146693027b9ac7b41349f46dbb891320095", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 117 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SubjectMess);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          <label for=\"emailSubject\">موضوع</label>\r\n        </div>\r\n       \r\n        <div id=\"email-container\">\r\n          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf48a08a2b146693027b9ac7b41349f46dbb891322433", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 122 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TextMess);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group mt-2\">\r\n          <div class=\"custom-file\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf48a08a2b146693027b9ac7b41349f46dbb891324729", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
#nullable restore
#line 126 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.file);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <label class=""custom-file-label"" for=""emailAttach"">افزودن فایل</label>
          </div>
        </div>
      </div>
      <div class=""modal-footer"">
        
        <input type=""Reset"" value=""لغو"" class=""btn btn-white"" data-dismiss=""modal"">
        <button type=""submit"" class=""btn btn-primary "">ارسال</button>
      </div>
    </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
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
        </div>
        <div class=""content-right"">
          <div class=""content-wrapper"">
            <div class=""content-header row"">
            </div>
            <div class=""content-body""><div class=""app-content-overlay""></div>

    <!-- Email list Area -->
    
    <!--/ Email list Area -->
    <!-- Detailed Email View -->
");
#nullable restore
#line 153 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
     if (@ViewBag.msg != null)
    {
        foreach (var item in @ViewBag.msg)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"      <div class=""email-app-area"">
        <div >
        <div class=""email-detail-header card"">
          
          
        <div class=""email-scroll-area"">
            <div class=""row aler alert-info"">
                <div class=""col-12"">
                    <div class=""email-label ml-2 my-2 pl-1 "">
                        <span class=""mr-1 bullet bullet-primary bullet-sm""></span><small class=""mail-label"" style=""color:black"">موضوع: ");
#nullable restore
#line 166 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
                                                                                                                                  Write(item.SubjectMess);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </small>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card px-1"">
                        <div class=""card-header email-detail-head ml-75"">
                            <div class=""user-details d-flex justify-content-between align-items-center flex-wrap"">
                                <div >
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf48a08a2b146693027b9ac7b41349f46dbb891330280", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <div class=""mail-items"">
                                    <h4 class=""list-group-item-heading mb-0"">پشتیبانی و بخش فروش  شرکت</h4>
                                    <div class=""email-info-dropup dropdown"">
                                        <span class=""dropdown-toggle font-small-3"" id=""dropdownMenuButton200"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                         sevenstar
                                        </span>
                                        <div class=""dropdown-menu dropdown-menu-right p-50"" aria-labelledby=""dropdownMenuButton200"">
                                            <div class=""px-25 dropdown-item"">از جانب:<strong> abaldersong@utexas.edu </strong></div>
                                            <div class=""px-25 dropdown-item"">به:<strong> johndoe@ow.ly </strong></div>
                                            <div class=""px-25 dropdown");
            WriteLiteral("-item\">تاریخ:<strong> ");
#nullable restore
#line 187 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
                                                                                       Write(item.DateMess);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></div>
                                        </div>
                                      </div>
                                </div>
                            </div>
                            <div class=""mail-meta-item"">
                                <div class=""mail-time mb-1"">تاریخ ارسال:</div>
                                <div class=""mail-date"">");
#nullable restore
#line 194 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
                                                  Write(item.DateMess);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"card-body mail-message-wrapper pt-2 mb-0\">\r\n                            <div class=\"mail-message\">\r\n                            <p>");
#nullable restore
#line 199 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
                          Write(item.TextMess);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                     </div>
                            <div class=""mail-attachements d-flex"">
                                <i class=""feather icon-paperclip font-medium-5 mr-50""></i>
                                <span>پیوست ها</span>
                            </div>
                        </div>
                        <div class=""mail-files py-2"">
                            <div class=""chip chip-primary"">
                              <div class=""chip-body py-50"">
");
#nullable restore
#line 209 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
                                 if (item.pathfile!=null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a target=\"blank\"");
            BeginWriteAttribute("href", " href=\"", 11921, "\"", 11954, 2);
            WriteAttributeValue("", 11928, "/fileupload/", 11928, 12, true);
#nullable restore
#line 211 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
WriteAttributeValue("", 11940, item.pathfile, 11940, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"chip-text\" style=\"color: white;\">دانلود فایل ضمیمه</a>\r\n");
#nullable restore
#line 212 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
                                }else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a href=\"#\" class=\"chip-text\" style=\"color: white;\">ضمیمه ندارد</a>\r\n");
#nullable restore
#line 215 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
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
            </div>
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""d-flex justify-content-between"">
                                
                            </div>
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
#line 238 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Msg\Detailssnd.cshtml"
          
    }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"   
     
    <!--/ Detailed Email View -->


          
        </div>
      </div>
    
    <!-- END: Content-->


    <!-- BEGIN: Customizer-->
    
    <!-- End: Customizer-->

    <!-- Buynow Button-->
  
    <!-- END: Footer-->




    <!-- BEGIN: Page JS-->
    <script src=""..\..\..\app-assets\js\scripts\pages\app-email.min.js""></script>
    <!-- END: Page JS-->

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel.AdminViewModel.Message.Vm_Message> Html { get; private set; }
    }
}
#pragma warning restore 1591
