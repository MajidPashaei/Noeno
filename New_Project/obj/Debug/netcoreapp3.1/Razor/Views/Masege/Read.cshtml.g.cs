#pragma checksum "c:\Users\ms\Desktop\Noeno\New_Project\Views\Masege\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f9f8e1c12d61b0e0cc498cc0e049081ca79bfbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Masege_Read), @"mvc.1.0.view", @"/Views/Masege/Read.cshtml")]
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
#line 1 "c:\Users\ms\Desktop\Noeno\New_Project\Views\_ViewImports.cshtml"
using New_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\ms\Desktop\Noeno\New_Project\Views\_ViewImports.cshtml"
using New_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\ms\Desktop\Noeno\New_Project\Views\Masege\Read.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9f8e1c12d61b0e0cc498cc0e049081ca79bfbd", @"/Views/Masege/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Views/_ViewImports.cshtml")]
    public class Views_Masege_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel.Entities.User.Vm_User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Start main-content -->\r\n");
            WriteLiteral("<main class=\"main-content dt-sl mt-2 mb-2\">\r\n    <div class=\"container main-container\">\r\n        <div class=\"row\">\r\n\r\n            <!-- Start Sidebar -->\r\n            ");
#nullable restore
#line 10 "c:\Users\ms\Desktop\Noeno\New_Project\Views\Masege\Read.cshtml"
       Write(await Html.PartialAsync("_Partial_profile"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <!-- End Sidebar -->

            <!-- Start Content -->
            <div class=""col-xl-9 col-lg-8 col-md-8 col-sm-12"">
                <div class=""row"">
                
 
             



                    <!-- Start main-content -->
                    <main class=""main-content dt-sl mt-1 mb-1 mr-2 ml-2"">
                        <div class=""container main-container"">

                            <div class=""row"">
                                <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 mb-2 px-0"">
                                    <nav class=""tab-cart-page"">
                                        
                                            <div class=""row"" style=""text-align: center;display: flex; justify-content: center;"">
                                                <p class=""alert alert-warning form-control"" > پیام </p>
                                            </div>
                                        
                                    
 ");
            WriteLiteral(@"                                   </nav>
                                </div>
                                <div class=""col-12"">
                                    <div class=""tab-content"" id=""nav-tabContent"">
                                        <div  class=""tab-pane fade show active"" id=""nav-home"" role=""tabpanel"" aria-labelledby=""nav-home-tab"" >
                                        
                                                        <div class=""col-12 mt-2"">
                                                            <div class=""dt-sl"">
                                                                <div class=""table-responsive"">
                                                                    <table class=""table table-order"">
                                                                        <thead>
                                                                            <tr>
                                                                                <th></th>
 ");
            WriteLiteral(@"                                                                          
                                                                                <th>عنوان پیام</th>
                                                                                <th> نام و نام خانوادگی فرستده</th>
                                                                                <th>شماره فرستده</th>                                                                    
                                                                                <th>تاریخ/ساعت</th>
                                                                                 <th>عملیات</th>
                                                                                
                                                                               
                                                                            </tr>
                                                                        </thead>
                                ");
            WriteLiteral(@"                                        <tbody>
                                                                          
                                                                            
                                                                                
                                                                        
                                                                            <tr>
                                                                                <td></td>
                                                                                
                                                                                <td>");
#nullable restore
#line 66 "c:\Users\ms\Desktop\Noeno\New_Project\Views\Masege\Read.cshtml"
                                                                               Write(ViewBag.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                <td>");
#nullable restore
#line 67 "c:\Users\ms\Desktop\Noeno\New_Project\Views\Masege\Read.cshtml"
                                                                               Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                <td>");
#nullable restore
#line 68 "c:\Users\ms\Desktop\Noeno\New_Project\Views\Masege\Read.cshtml"
                                                                               Write(ViewBag.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                <td>");
#nullable restore
#line 69 "c:\Users\ms\Desktop\Noeno\New_Project\Views\Masege\Read.cshtml"
                                                                               Write(ViewBag.DateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                                                               
                                                                                   
                                                                                

                                                                                 
                                                                                 
                                                                                          <td><a class=""btn btn-success""");
            BeginWriteAttribute("href", "  href=\"", 5011, "\"", 5044, 2);
            WriteAttributeValue("", 5019, "/masege/index/", 5019, 14, true);
#nullable restore
#line 76 "c:\Users\ms\Desktop\Noeno\New_Project\Views\Masege\Read.cshtml"
WriteAttributeValue("", 5033, ViewBag.id, 5033, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">پاسخ</a></td>
                                                                                
                                                                                
                                                                                 
                                                                                
                                                                               

                                                                            </tr>
                                                                            <tr></tr>
                                                                         
                                                                    
                                                                        </tbody>
                                                                    </table>
                                                                </div>
                                                 ");
            WriteLiteral(@"           </div>
                                                        </div>
                                                        
                                        </div>
                     
                                    </div>
                                    <p style=""text-align: center;margin-top: 4cm;""> ");
#nullable restore
#line 96 "c:\Users\ms\Desktop\Noeno\New_Project\Views\Masege\Read.cshtml"
                                                                               Write(ViewBag.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                               
                            </div>

                        </div>
                    </main>
                    
                    <!-- End main-content -->
                </div>
            </div>
            <!-- End Content -->




        </div>

    </div>
</main>
<!-- End main-content -->
	  ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel.Entities.User.Vm_User> Html { get; private set; }
    }
}
#pragma warning restore 1591
