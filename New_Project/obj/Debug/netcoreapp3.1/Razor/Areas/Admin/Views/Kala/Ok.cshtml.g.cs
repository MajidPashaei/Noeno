<<<<<<< HEAD
#pragma checksum "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e3a3cf6f1b1fd5710f43fc092dc9b3bc4405207"
=======
#pragma checksum "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e3a3cf6f1b1fd5710f43fc092dc9b3bc4405207"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Kala_Ok), @"mvc.1.0.view", @"/Areas/Admin/Views/Kala/Ok.cshtml")]
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
<<<<<<< HEAD
#line 1 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
using New_Project;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
using New_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3a3cf6f1b1fd5710f43fc092dc9b3bc4405207", @"/Areas/Admin/Views/Kala/Ok.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Kala_Ok : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 80px ;height: 80px;border-radius: 50%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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

    <!-- BEGIN: Content-->
<section id=""data-list-view"" class=""data-list-view-header"">
  <!-- DataTable starts -->
  <div class=""table-responsive"">
    <table class=""table data-list-view"">
      <thead>
        <tr>
          <th></th>
          <th>ردیف</th>
          <th> کد ثبت </th>
          <th>  عنوان  </th>
           <th> زمان ثبت </th>
           <th> عکس کالا </th>
           <th> کاربر  </th>
          <th> عملیات</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
<<<<<<< HEAD
#line 21 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
=======
#line 21 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
  
  if (ViewBag.listp != null)
  {
    int i=1;
    foreach (var item in ViewBag.listp)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td></td>\r\n          <td class=\"product-category\"> ");
#nullable restore
<<<<<<< HEAD
#line 29 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
=======
#line 29 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td class=\"product-name\">");
#nullable restore
<<<<<<< HEAD
#line 30 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
=======
#line 30 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
                              Write(item.Product_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"product-category\">");
#nullable restore
<<<<<<< HEAD
#line 31 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
=======
#line 31 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
                                    Write(item.Title_Pro);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n            <td class=\"product-category\">");
#nullable restore
<<<<<<< HEAD
#line 33 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
=======
#line 33 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
                                    Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td class=\"product-category\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8e3a3cf6f1b1fd5710f43fc092dc9b3bc44052075534", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 920, "~/fileupload/", 920, 13, true);
#nullable restore
<<<<<<< HEAD
#line 34 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
=======
#line 34 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
AddHtmlAttributeValue("", 933, item.Image, 933, 11, false);

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
            WriteLiteral("</td>\r\n               <td class=\"product-category\">");
#nullable restore
<<<<<<< HEAD
#line 35 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
=======
#line 35 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td class=\"product-action\">\r\n             <div class=\"col-lg-3 col-md-3 mb-1\">\r\n                <div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">\r\n                  <a");
            BeginWriteAttribute("href", " href=\"", 1260, "\"", 1306, 2);
            WriteAttributeValue("", 1267, "/admin/kala/DetailOk?b=", 1267, 23, true);
#nullable restore
<<<<<<< HEAD
#line 39 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
=======
#line 39 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
WriteAttributeValue("", 1290, item.Product_Id, 1290, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\" >  جزییات </a>\r\n                   <a  onclick=\"return confirm(\'آیا از حذف آیتم مطمئن هستید؟\');\"");
            BeginWriteAttribute("href", "  href=\"", 1435, "\"", 1479, 2);
            WriteAttributeValue("", 1443, "/admin/kala/delok?s=", 1443, 20, true);
#nullable restore
<<<<<<< HEAD
#line 40 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
=======
#line 40 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
WriteAttributeValue("", 1463, item.Product_Id, 1463, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\" \r\n                                            > حذف </a>\r\n                  \r\n                </div>\r\n              </div>\r\n          </td>\r\n        </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 47 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
=======
#line 47 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Kala\Ok.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
       i++;

    }
    
  }


     



#line default
#line hidden
#nullable disable
            WriteLiteral(" </tbody>\r\n    </table>\r\n  </div>\r\n\r\n      \r\n\r\n      </section>\r\n<!-- Data list view end -->\r\n");
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
