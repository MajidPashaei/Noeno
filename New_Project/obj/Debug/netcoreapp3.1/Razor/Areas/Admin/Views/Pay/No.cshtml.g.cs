<<<<<<< HEAD
#pragma checksum "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "758f194a90f393ce2f9d6ff4fc725f1203583c77"
=======
#pragma checksum "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "758f194a90f393ce2f9d6ff4fc725f1203583c77"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Pay_No), @"mvc.1.0.view", @"/Areas/Admin/Views/Pay/No.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"758f194a90f393ce2f9d6ff4fc725f1203583c77", @"/Areas/Admin/Views/Pay/No.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Pay_No : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
<<<<<<< HEAD
#line 19 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
=======
#line 19 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
         if (ViewBag.Ok!=null)
        {
          int i=1;
          

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 22 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
=======
#line 22 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
           foreach (var item in ViewBag.Ok)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <tr>\r\n          <td></td>\r\n          <td class=\"product-category\">");
#nullable restore
<<<<<<< HEAD
#line 26 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
=======
#line 26 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td class=\"product-name\">");
#nullable restore
<<<<<<< HEAD
#line 27 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
=======
#line 27 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td class=\"product-name\">");
#nullable restore
<<<<<<< HEAD
#line 28 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
=======
#line 28 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                               Write(item.iduser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"product-category\">  درخواست برداشت از کیف پول </td>\r\n\r\n            <td class=\"product-category\">");
#nullable restore
<<<<<<< HEAD
#line 31 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
=======
#line 31 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                    Write(item.havesttime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n           \r\n               <td class=\"product-category\">");
#nullable restore
<<<<<<< HEAD
#line 33 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
=======
#line 33 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                       Write(item.NameFamily);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"product-category\">");
#nullable restore
<<<<<<< HEAD
#line 34 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
=======
#line 34 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
                                        Write(item.Harvest);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
           <td class=""product-action"">
             <div class=""col-lg-3 col-md-3 mb-1"">
                <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                  <a href=""#"" class=""btn btn-success btn-sm"" > پرداخت شد </a>
                 
                  
                </div>
              </div>
          </td>
        </tr>
");
#nullable restore
<<<<<<< HEAD
#line 45 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
=======
#line 45 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
          }

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 45 "c:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
=======
#line 45 "C:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\No.cshtml"
>>>>>>> 027e2a0fe64ba443da3c53cf64b5e1d41e71bc26
           
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
