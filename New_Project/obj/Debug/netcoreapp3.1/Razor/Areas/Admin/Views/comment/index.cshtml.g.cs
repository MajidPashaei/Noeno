<<<<<<< HEAD
#pragma checksum "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc6810e736694f7398ec70b3f32d66cdedee6818"
=======
#pragma checksum "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc6810e736694f7398ec70b3f32d66cdedee6818"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_comment_index), @"mvc.1.0.view", @"/Areas/Admin/Views/comment/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6810e736694f7398ec70b3f32d66cdedee6818", @"/Areas/Admin/Views/comment/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_comment_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <!-- BEGIN: Content-->\r\n<section id=\"data-list-view\" class=\"data-list-view-header\">\r\n");
#nullable restore
<<<<<<< HEAD
#line 5 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
=======
#line 5 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
   if (ViewBag.suc != null)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <span class=\"alert alert-success\">");
#nullable restore
<<<<<<< HEAD
#line 7 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
=======
#line 7 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
                                   Write(ViewBag.suc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
<<<<<<< HEAD
#line 8 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
=======
#line 8 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
  }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  
  <!-- DataTable starts -->
  <div class=""table-responsive"">
    <table class=""table data-list-view"">
      <thead>
        <tr>
          <th></th>
          <th>ردیف</th>
          <th>  نام کاربر </th>
           <th>  زبان</th>
            <th>  تاریخ ثبت نظر</th>
          <th> عملیات</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
<<<<<<< HEAD
#line 24 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
=======
#line 24 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
 if (ViewBag.comments != null)
{
  int i=0;
    

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 27 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
=======
#line 27 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
     foreach (var item in ViewBag.comments)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n          <td>\r\n          \r\n          </td>\r\n\r\n          <td class=\"product-category\">");
#nullable restore
<<<<<<< HEAD
#line 35 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
=======
#line 35 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         \r\n          <td class=\"product-name\">");
#nullable restore
<<<<<<< HEAD
#line 37 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
=======
#line 37 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
                              Write(item.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("   <input style=\"display: none;\"  id=\"comment\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 870, "\"", 891, 1);
#nullable restore
<<<<<<< HEAD
#line 37 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
=======
#line 37 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
WriteAttributeValue("", 878, item.Comment, 878, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n\r\n                        <td class=\"product-category\">");
#nullable restore
<<<<<<< HEAD
#line 39 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
=======
#line 39 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
                                                Write(item.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td class=\"product-category\">");
#nullable restore
<<<<<<< HEAD
#line 40 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
=======
#line 40 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
                                                Write(item.dateshamsi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </td>
           <td class=""product-action"">
             <div class="" mb-1"">
                <div class=""btn-group""  aria-label=""Basic example"">
                  <a  class=""btn btn-primary btn-sm"" onclick=""a();"" style=""color: white;"">مشاهده نظر</a>
");
#nullable restore
<<<<<<< HEAD
#line 45 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
=======
#line 45 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
                   if (item.product_id != 0)
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <a");
            BeginWriteAttribute("href", " href=\"", 1395, "\"", 1435, 2);
            WriteAttributeValue("", 1402, "/product/details/", 1402, 17, true);
#nullable restore
<<<<<<< HEAD
#line 47 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
=======
#line 47 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
WriteAttributeValue("", 1419, item.product_id, 1419, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\" style=\"color: white;\">مشاهده آیتم</a>\r\n");
#nullable restore
<<<<<<< HEAD
#line 48 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
=======
#line 48 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
                  }else
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <a");
            BeginWriteAttribute("href", " href=\"", 1578, "\"", 1612, 2);
            WriteAttributeValue("", 1585, "/blog/details/", 1585, 14, true);
#nullable restore
<<<<<<< HEAD
#line 50 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
=======
#line 50 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
WriteAttributeValue("", 1599, item.blog_id, 1599, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\" style=\"color: white;\">مشاهده آیتم</a>\r\n");
#nullable restore
<<<<<<< HEAD
#line 51 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
=======
#line 51 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                   \r\n                  <a");
            BeginWriteAttribute("href", " href=\"", 1746, "\"", 1780, 2);
            WriteAttributeValue("", 1753, "/admin/comment/del/", 1753, 19, true);
#nullable restore
<<<<<<< HEAD
#line 53 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
=======
#line 53 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
WriteAttributeValue("", 1772, item.Id, 1772, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\" onclick=\"return confirm(\'آیا از حذف رکورد مورد نظر مطمئن هستید\')\">حذف</a>\r\n                  <a");
            BeginWriteAttribute("href", "  href=\"", 1907, "\"", 1945, 2);
            WriteAttributeValue("", 1915, "/admin/comment/verify/", 1915, 22, true);
#nullable restore
<<<<<<< HEAD
#line 54 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
=======
#line 54 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
WriteAttributeValue("", 1937, item.Id, 1937, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success  btn-sm\" onclick=\"return confirm(\'آیا از تایید رکورد مورد نظر مطمئن هستید\')\">تایید</a>\r\n                 \r\n                </div>\r\n              </div>\r\n          </td>\r\n        </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 60 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
=======
#line 60 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
        i++;
}

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 61 "c:\Users\ms\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
=======
#line 61 "C:\Users\MS\Desktop\Noeno\New_Project\Areas\Admin\Views\comment\index.cshtml"
>>>>>>> 094e4d0bdcd27dcc9d52686059f31379799321aa
 
   
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
     
<script>
  function a()
  {
    debugger
    var msg=document.getElementById(""comment"").value;
   alert(msg);
  }
</script>




      </tbody>
    </table>
  </div>
  <!-- DataTable ends -->

  <!-- add new sidebar starts -->
 
  <!-- add new sidebar ends -->
</section>
<!-- Data list view end -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
