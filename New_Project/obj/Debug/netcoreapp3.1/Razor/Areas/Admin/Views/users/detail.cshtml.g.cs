<<<<<<< HEAD
#pragma checksum "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8b5b83e24ed163e6d250f5f95de193a8507bafe"
=======
#pragma checksum "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8b5b83e24ed163e6d250f5f95de193a8507bafe"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
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
<<<<<<< HEAD
#line 1 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
using New_Project;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\_ViewImports.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
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
<<<<<<< HEAD
#line 3 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
=======
#line 3 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
   if (ViewBag.er != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-success\">");
#nullable restore
<<<<<<< HEAD
#line 5 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
=======
#line 5 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                              Write(ViewBag.er);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
<<<<<<< HEAD
#line 6 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
=======
#line 6 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
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
          <th> کد کالاها   </th>
          <th>  عنوان  </th>
           <th>  دسته  </th>
           <th>  وضعیت </th>
          <th>  تعداد  </th>
           <th>   قیمت  </th>
           <th>  عکس کاربر </th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
<<<<<<< HEAD
#line 24 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
=======
#line 24 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
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
<<<<<<< HEAD
#line 31 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
=======
#line 31 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"product-name\">");
#nullable restore
<<<<<<< HEAD
#line 32 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
=======
#line 32 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"product-category\">");
#nullable restore
<<<<<<< HEAD
#line 33 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
=======
#line 33 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                    Write(item.Title_Pro);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td class=\"product-category\">");
#nullable restore
<<<<<<< HEAD
#line 34 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
=======
#line 34 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                    Write(item.Special);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td class=\"product-name\">");
#nullable restore
<<<<<<< HEAD
#line 35 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
=======
#line 35 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                Write(item.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"product-category\">");
#nullable restore
<<<<<<< HEAD
#line 36 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
=======
#line 36 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                    Write(item.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td class=\"product-category\">");
#nullable restore
<<<<<<< HEAD
#line 37 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
=======
#line 37 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                    Write(item.Main_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td class=\"product-category\">\r\n               <img");
            BeginWriteAttribute("src", " src=\"", 1222, "\"", 1251, 2);
            WriteAttributeValue("", 1228, "/fileupload/", 1228, 12, true);
#nullable restore
<<<<<<< HEAD
#line 39 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
=======
#line 39 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
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
<<<<<<< HEAD
#line 42 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
=======
#line 42 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\users\detail.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
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
