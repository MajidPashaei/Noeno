#pragma checksum "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Baner\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e6db069e5e58b451cf0ebdff95ab5fa9f8180d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Baner_List), @"mvc.1.0.view", @"/Areas/Admin/Views/Baner/List.cshtml")]
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
#line 1 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
using New_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
using New_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e6db069e5e58b451cf0ebdff95ab5fa9f8180d4", @"/Areas/Admin/Views/Baner/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Baner_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!-- BEGIN: Content-->\r\n<section id=\"data-list-view\" class=\"data-list-view-header\">\r\n");
#nullable restore
#line 3 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Baner\List.cshtml"
     if (ViewBag.er != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"alert alert-success\">");
#nullable restore
#line 5 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Baner\List.cshtml"
                          Write(ViewBag.er);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 6 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Baner\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  <!-- DataTable starts -->
  <div class=""table-responsive"">
    <table class=""table data-list-view"">
      <thead>
        <tr>
          <th></th>
          <th>ردیف</th>
       
          <th> محصول </th>
          <th> عکس </th>
          <th> شماره بنر</th>
          <th> عملیات</th>
        </tr>
      </thead>
    
");
#nullable restore
#line 22 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Baner\List.cshtml"
 if (ViewBag.list != null)
{
  int i=1;
     foreach (var item in ViewBag.list)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td></td>\r\n          <td class=\"product-category\">");
#nullable restore
#line 29 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Baner\List.cshtml"
                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          \r\n          <td class=\"product-category\">");
#nullable restore
#line 31 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Baner\List.cshtml"
                                  Write(item.nameproduct);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n          . <td class=\"product-category\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1e6db069e5e58b451cf0ebdff95ab5fa9f8180d46017", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 832, "~/fileupload/", 832, 13, true);
#nullable restore
#line 32 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Baner\List.cshtml"
AddHtmlAttributeValue("", 845, item.ImageMainSlid, 845, 19, false);

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
#line 34 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Baner\List.cshtml"
                                  Write(item.CategoryProductIdSlid);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n          <td class=\"product-action\">\r\n            <div class=\"col-lg-3 col-md-3 mb-1\">\r\n              <div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">\r\n                                 <a");
            BeginWriteAttribute("href", " href=\"", 1173, "\"", 1205, 2);
            WriteAttributeValue("", 1180, "/admin/baner/del/", 1180, 17, true);
#nullable restore
#line 38 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Baner\List.cshtml"
WriteAttributeValue("", 1197, item.Id, 1197, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-danger btn-sm\" onclick=\"return confirm(\'آیا از حذف رکورد مورد نظر مطمن هستید؟\')\">حذف</a>\r\n\r\n                </div>\r\n            </div>\r\n          </td>\r\n        </tr>\r\n");
#nullable restore
#line 44 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Baner\List.cshtml"
 i++;
     }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n      \r\n      </tbody>\r\n    </table>\r\n  </div>\r\n  <!-- DataTable ends -->\r\n\r\n  <!-- add new sidebar starts -->\r\n\r\n  <!-- add new sidebar ends -->\r\n</section>\r\n<!-- Data list view end -->");
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
