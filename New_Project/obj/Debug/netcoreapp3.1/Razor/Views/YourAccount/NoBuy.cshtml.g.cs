#pragma checksum "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount\NoBuy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0787ffc8358b9776e2b24b8129cf8c5e21adf872"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YourAccount_NoBuy), @"mvc.1.0.view", @"/Views/YourAccount/NoBuy.cshtml")]
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
#line 3 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount\NoBuy.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0787ffc8358b9776e2b24b8129cf8c5e21adf872", @"/Views/YourAccount/NoBuy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Views/_ViewImports.cshtml")]
    public class Views_YourAccount_NoBuy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel.Entities.User.Vm_User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Start main-content -->\r\n");
            WriteLiteral("<main class=\"main-content dt-sl mt-2 mb-2\">\r\n    <div class=\"container main-container\">\r\n        <div class=\"row\">\r\n\r\n            <!-- Start Sidebar -->\r\n            ");
#nullable restore
#line 10 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount\NoBuy.cshtml"
       Write(await Html.PartialAsync("_Partial_profile"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!-- End Sidebar -->\r\n\r\n            <!-- Start Content -->\r\n            <div class=\"col-xl-9 col-lg-8 col-md-8 col-sm-12\">\r\n                <div class=\"row\">\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"


                    <!-- Start main-content -->
                    <main class=""main-content dt-sl mt-1 mb-1 mr-2 ml-2"">
                        <div class=""container main-container"">

                            <div class=""row"">
                                <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 mb-2 px-0"">
                                    <nav class=""tab-cart-page"">
                                        
                                            <div class=""row"" style=""text-align: center;display: flex; justify-content: center;"">
                                                <p class=""alert alert-warning form-control"" >لیست تراکنش ها</p>
                                            </div>
                                        
");
            WriteLiteral(@"                                    </nav>
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
                                                                                <th></th>");
            WriteLiteral(@"
                                                                            <th>ردیف</th>
                                                                                <th>  نام محصول </th>
                                                                                <th> بازرسی+قیمت محصول </th>
                                                                                <th>   قیمت محصول</th>
                                                                                <th> هزینه بازرسی</th>
                                                                            </tr>
                                                                        </thead>
                                                                        <tbody>
");
#nullable restore
#line 142 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount\NoBuy.cshtml"
                                                                             if (ViewBag.NoBuy!=null)
                                                                            {
                                                                                int i=1;
                                                                                
                                                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount\NoBuy.cshtml"
                                                                                 foreach (var item in  ViewBag.NoBuy)
                                                                                {
                                                                                    
                                                                            
                                                                                
                                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                           <tr>
                                                                                <td></td>
                                                                                <td>");
#nullable restore
#line 154 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount\NoBuy.cshtml"
                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                <td>");
#nullable restore
#line 155 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount\NoBuy.cshtml"
                                                                               Write(item.product_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                <td> ");
#nullable restore
#line 156 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount\NoBuy.cshtml"
                                                                                Write(item.Total_sum);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                                                                <td>");
#nullable restore
#line 157 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount\NoBuy.cshtml"
                                                                               Write(item.product_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                <td> ");
#nullable restore
#line 158 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount\NoBuy.cshtml"
                                                                                Write(item.PriceB);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n                                                                            </tr>\r\n");
#nullable restore
#line 161 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount\NoBuy.cshtml"
                                                                            i++;
                                                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 162 "c:\Users\ms\Desktop\Noeno\New_Project\Views\YourAccount\NoBuy.cshtml"
                                                                             
                                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                        </tbody>
                                                                    </table>
                                                                </div>
                                                            </div>
                                                        </div>
                                        </div>
");
            WriteLiteral(@"                                    </div>
                                </div>
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
	     <script>
            function sendpay()
            {
             
             if(document.getElementById('pay25').value != """")
             {
                window.location.href=""/pay/index/""+document.getElementById('pay25').value;
             }
             
            }
          </script>");
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
