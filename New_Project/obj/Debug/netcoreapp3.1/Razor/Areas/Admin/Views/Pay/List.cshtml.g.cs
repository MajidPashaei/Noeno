#pragma checksum "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75d3dbe7734faaf376cc770cc7aef339114ce0ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Pay_List), @"mvc.1.0.view", @"/Areas/Admin/Views/Pay/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75d3dbe7734faaf376cc770cc7aef339114ce0ed", @"/Areas/Admin/Views/Pay/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Pay_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- BEGIN: Content-->
<section id=""data-list-view"" class=""data-list-view-header"">

  <!-- DataTable starts -->
  <div class=""table-responsive"">
    <table class=""table data-list-view"">
      <thead>
        <tr>
          <th></th>
          <th>ردیف</th>
          <th> کد کاربر </th>
          <th> تاریخ </th>
          <th> مبلغ </th>
          <th> توضیحات</th>
          <th> نوع </th>
        </tr>
      </thead>
    
");
#nullable restore
#line 19 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\List.cshtml"
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
#line 26 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\List.cshtml"
                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td class=\"product-category\"> ");
#nullable restore
#line 27 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\List.cshtml"
                                   Write(item.IdUser);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n          <td class=\"product-category\"> ");
#nullable restore
#line 28 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\List.cshtml"
                                   Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n          <td class=\"product-category\"> ");
#nullable restore
#line 29 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\List.cshtml"
                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n          <td class=\"product-action\"> ");
#nullable restore
#line 30 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\List.cshtml"
                                 Write(item.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n          <td class=\"product-action\"> ");
#nullable restore
#line 31 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\List.cshtml"
                                 Write(item.TypePay);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Areas\Admin\Views\Pay\List.cshtml"
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
