#pragma checksum "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8b5b83e24ed163e6d250f5f95de193a8507bafe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_users_detail), @"mvc.1.0.view", @"/Areas/Admin/Views/users/detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8b5b83e24ed163e6d250f5f95de193a8507bafe", @"/Areas/Admin/Views/users/detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_users_detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <!-- BEGIN: Content-->\r\n<section id=\"data-list-view\" class=\"data-list-view-header\">\r\n");
#nullable restore
#line 3 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
   if (ViewBag.er != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-success\">");
#nullable restore
#line 5 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
                              Write(ViewBag.er);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 6 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
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
          <th>????????</th>
          <th> ???? ????????????   </th>
          <th>  ??????????  </th>
           <th>  ????????  </th>
           <th>  ?????????? </th>
          <th>  ??????????  </th>
           <th>   ????????  </th>
           <th>  ?????? ?????????? </th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 24 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
 if (ViewBag.Kala != null)
{
  int i=1;
    foreach (var item in ViewBag.Kala)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr>\r\n            <td></td>\r\n            <td class=\"product-category\">");
#nullable restore
#line 31 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"product-name\">");
#nullable restore
#line 32 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
                                Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"product-category\">");
#nullable restore
#line 33 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
                                    Write(item.Title_Pro);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td class=\"product-category\">");
#nullable restore
#line 34 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
                                    Write(item.Special);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td class=\"product-name\">");
#nullable restore
#line 35 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
                                Write(item.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"product-category\">");
#nullable restore
#line 36 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
                                    Write(item.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td class=\"product-category\">");
#nullable restore
#line 37 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
                                    Write(item.Main_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td class=\"product-category\">\r\n               <img");
            BeginWriteAttribute("src", " src=\"", 1222, "\"", 1251, 2);
            WriteAttributeValue("", 1228, "/fileupload/", 1228, 12, true);
#nullable restore
#line 39 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
WriteAttributeValue("", 1240, item.Image, 1240, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 60px;border-radius: 25%;\"");
            BeginWriteAttribute("alt", " alt=\"", 1292, "\"", 1298, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
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
