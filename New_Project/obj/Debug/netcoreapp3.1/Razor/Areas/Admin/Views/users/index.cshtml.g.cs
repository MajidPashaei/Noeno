#pragma checksum "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2be175f82fc935a01333e7677e8118ba61d40987"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_users_index), @"mvc.1.0.view", @"/Areas/Admin/Views/users/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2be175f82fc935a01333e7677e8118ba61d40987", @"/Areas/Admin/Views/users/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_users_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <!-- BEGIN: Content-->\r\n<section id=\"data-list-view\" class=\"data-list-view-header\">\r\n");
#nullable restore
#line 3 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\index.cshtml"
   if (ViewBag.er != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-success\">");
#nullable restore
#line 5 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\index.cshtml"
                              Write(ViewBag.er);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 6 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\index.cshtml"
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
          <th> نام  کاربر </th>
          <th> شماره تماس  </th>
           <th>  کد کاربر </th>
           <th>  استان </th>
          <th>  شهرستان  </th>
           <th>   مدت عضویت </th>
           <th>  عکس کاربر </th>
          <th> عملیات</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 25 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\index.cshtml"
 if (ViewBag.list != null)
{
  int i=1;
    foreach (var item in ViewBag.list)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr>\r\n            <td></td>\r\n            <td class=\"product-category\">");
#nullable restore
#line 32 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\index.cshtml"
                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"product-name\">");
#nullable restore
#line 33 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\index.cshtml"
                                Write(item.NameFamily);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"product-category\">");
#nullable restore
#line 34 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\index.cshtml"
                                    Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td class=\"product-category\">");
#nullable restore
#line 35 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\index.cshtml"
                                    Write(item.RPass);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td class=\"product-name\">");
#nullable restore
#line 36 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\index.cshtml"
                                Write(item.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"product-category\">");
#nullable restore
#line 37 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\index.cshtml"
                                    Write(item.city);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td class=\"product-category\">");
#nullable restore
#line 38 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\index.cshtml"
                                    Write(item.TimeLogIn);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td class=\"product-category\">\r\n               <img");
            BeginWriteAttribute("src", " src=\"", 1261, "\"", 1290, 2);
            WriteAttributeValue("", 1267, "/fileupload/", 1267, 12, true);
#nullable restore
#line 40 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\index.cshtml"
WriteAttributeValue("", 1279, item.Image, 1279, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 60px;border-radius: 25%;\"");
            BeginWriteAttribute("alt", " alt=\"", 1331, "\"", 1337, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </td>\r\n           <td class=\"product-action\">\r\n             <div class=\"col-lg-3 col-md-3 mb-1\">\r\n                <div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">\r\n                  \r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1574, "\"", 1608, 2);
            WriteAttributeValue("", 1581, "/admin/users/del?s=", 1581, 19, true);
#nullable restore
#line 46 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\index.cshtml"
WriteAttributeValue("", 1600, item.Id, 1600, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\" onclick=\"return confirm(\'آیا از حذف رکورد مورد نظر مطمئن هستید؟\')\">حذف</a>\r\n                     <a");
            BeginWriteAttribute("href", " href=\"", 1739, "\"", 1776, 2);
            WriteAttributeValue("", 1746, "/admin/users/detail?s=", 1746, 22, true);
#nullable restore
#line 47 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\index.cshtml"
WriteAttributeValue("", 1768, item.Id, 1768, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-sm\" >کالاها</a>\r\n                      <a");
            BeginWriteAttribute("href", " href=\"", 1843, "\"", 1881, 2);
            WriteAttributeValue("", 1850, "/admin/details/index?s=", 1850, 23, true);
#nullable restore
#line 48 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\index.cshtml"
WriteAttributeValue("", 1873, item.Id, 1873, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary btn-sm\" >جزئیات</a>\r\n                 \r\n                </div>\r\n              </div>\r\n          </td>\r\n        </tr>\r\n");
#nullable restore
#line 54 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\index.cshtml"
        i++;

    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("      \r\n\r\n       \r\n\r\n\r\n\r\n\r\n      </tbody>\r\n    </table>\r\n  </div>\r\n  <!-- DataTable ends -->\r\n\r\n  <!-- add new sidebar starts -->\r\n \r\n  <!-- add new sidebar ends -->\r\n</section>\r\n<!-- Data list view end -->\r\n");
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
