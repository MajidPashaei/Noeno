#pragma checksum "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\AdminPays\Ok.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e81c0654f71f4617612c945df02dfe972249a56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminPays_Ok), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminPays/Ok.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e81c0654f71f4617612c945df02dfe972249a56", @"/Areas/Admin/Views/AdminPays/Ok.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminPays_Ok : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section id=""data-list-view"" class=""data-list-view-header"">
  <div class=""table-responsive"">
    <table class=""table data-list-view"">
      <thead>
        <tr>
          <th></th>
          <th>ردیف</th>
          <th> کد ثبت </th>
           <th> کد کاربر </th>
          <th>  عنوان  </th>
           <th> زمان ثبت </th>
           
           <th> کاربر  </th>
            <th> مبلغ درخواستی  </th>
          <th> عملیات</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 19 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\AdminPays\Ok.cshtml"
         if (ViewBag.R!=null)
        {
          int i=1;
          

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\AdminPays\Ok.cshtml"
           foreach (var item in ViewBag.R)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <tr>\r\n          <td></td>\r\n          <td class=\"product-category\">");
#nullable restore
#line 26 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\AdminPays\Ok.cshtml"
                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td class=\"product-name\">");
#nullable restore
#line 27 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\AdminPays\Ok.cshtml"
                              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td class=\"product-name\">");
#nullable restore
#line 28 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\AdminPays\Ok.cshtml"
                               Write(item.iduser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"product-category\">  درخواست برداشت از کیف پول </td>\r\n\r\n            <td class=\"product-category\">");
#nullable restore
#line 31 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\AdminPays\Ok.cshtml"
                                    Write(item.havesttime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n           \r\n               <td class=\"product-category\">");
#nullable restore
#line 33 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\AdminPays\Ok.cshtml"
                                       Write(item.NameFamily);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"product-category\">");
#nullable restore
#line 34 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\AdminPays\Ok.cshtml"
                                        Write(item.Harvest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td class=\"product-action\">\r\n             <div class=\"col-lg-3 col-md-3 mb-1\">\r\n                <div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">\r\n                  <a");
            BeginWriteAttribute("href", " href=\"", 1283, "\"", 1312, 2);
            WriteAttributeValue("", 1290, "/admin/Pay/No/", 1290, 14, true);
#nullable restore
#line 38 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\AdminPays\Ok.cshtml"
WriteAttributeValue("", 1304, item.Id, 1304, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success btn-sm\" > پرداخت  </a>\r\n                 \r\n                  \r\n                </div>\r\n              </div>\r\n          </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\AdminPays\Ok.cshtml"
          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\AdminPays\Ok.cshtml"
           
          i++;
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n      </tbody>\r\n    </table>\r\n  </div>\r\n</section>\r\n\r\n");
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
