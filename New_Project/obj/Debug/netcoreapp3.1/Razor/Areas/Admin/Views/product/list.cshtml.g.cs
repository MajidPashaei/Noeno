#pragma checksum "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\product\list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e17dda642e14b8f1961b684202850acf7ce9cd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_product_list), @"mvc.1.0.view", @"/Areas/Admin/Views/product/list.cshtml")]
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
#line 1 "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
using New_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
using New_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e17dda642e14b8f1961b684202850acf7ce9cd5", @"/Areas/Admin/Views/product/list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_product_list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 60px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!-- BEGIN: Content-->\r\n<section id=\"data-list-view\" class=\"data-list-view-header\">\r\n  <!-- DataTable starts -->\r\n");
#nullable restore
#line 4 "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\product\list.cshtml"
   if (ViewBag.er != null)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p class=\"alert alert-success\">");
#nullable restore
#line 6 "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\product\list.cshtml"
                            Write(ViewBag.er);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 7 "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\product\list.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  <div class=""table-responsive"">
    <table class=""table data-list-view"">
      <thead>
        <tr>
          <th></th>
          <th>ردیف</th>
          <th> عنوان محصول </th>
          <th> دسته بندی </th>
          <th> تصویر محصول </th>
          <th> قیمت </th>
          <th> درصد تخفیف</th>
          <th> زبان</th>

          <th> عملیات</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 25 "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\product\list.cshtml"
         if ( ViewBag.listp != null)
        {

        int i=1;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\product\list.cshtml"
         foreach (var item in ViewBag.listp)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td></td>\r\n          <td class=\"product-category\"> ");
#nullable restore
#line 34 "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\product\list.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td class=\"product-name\">");
#nullable restore
#line 35 "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\product\list.cshtml"
                              Write(item.TitleProductPro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td class=\"product-category\">");
#nullable restore
#line 36 "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\product\list.cshtml"
                                  Write(item.catname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n          <td class=\"product-category\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e17dda642e14b8f1961b684202850acf7ce9cd56472", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1021, "~/fileupload/", 1021, 13, true);
#nullable restore
#line 38 "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\product\list.cshtml"
AddHtmlAttributeValue("", 1034, item.ImageMainPro, 1034, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </td>\r\n          <td class=\"product-category\">");
#nullable restore
#line 39 "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\product\list.cshtml"
                                  Write(item.PricePro);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n          <td class=\"product-category\">");
#nullable restore
#line 40 "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\product\list.cshtml"
                                  Write(item.OfferPro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n          <td class=\"product-category\">");
#nullable restore
#line 42 "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\product\list.cshtml"
                                  Write(item.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n          <td class=\"product-action\">\r\n            <div class=\"col-lg-3 col-md-3 mb-1\">\r\n              <div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1441, "\"", 1478, 2);
            WriteAttributeValue("", 1448, "/admin/product/update/", 1448, 22, true);
#nullable restore
#line 47 "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\product\list.cshtml"
WriteAttributeValue("", 1470, item.Id, 1470, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\">مشاهده</a>\r\n                <a onclick=\"return confirm(\'آیا از حذف اطلاعات مطمن هستید؟\')\"");
            BeginWriteAttribute("href", " href=\"", 1600, "\"", 1634, 2);
            WriteAttributeValue("", 1607, "/admin/product/del/", 1607, 19, true);
#nullable restore
#line 48 "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\product\list.cshtml"
WriteAttributeValue("", 1626, item.Id, 1626, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                  class=\"btn btn-danger btn-sm\">حذف</a>\r\n                <a class=\"btn btn-success  btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1744, "\"", 1781, 2);
            WriteAttributeValue("", 1751, "/admin/product/update/", 1751, 22, true);
#nullable restore
#line 50 "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\product\list.cshtml"
WriteAttributeValue("", 1773, item.Id, 1773, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">ویرایش</a>\r\n              </div>\r\n            </div>\r\n          </td>\r\n        </tr>\r\n");
#nullable restore
#line 55 "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\product\list.cshtml"
i++;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "e:\project\Noeno\Noeno\New_Project\Areas\Admin\Views\product\list.cshtml"
         

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n      </tbody>\r\n    </table>\r\n  </div>\r\n  <!-- DataTable ends -->\r\n\r\n  <!-- add new sidebar starts -->\r\n\r\n  <!-- add new sidebar ends -->\r\n</section>\r\n<!-- Data list view end -->");
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
