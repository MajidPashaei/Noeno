#pragma checksum "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\ShowInvite.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "100ae6de694cddd6b848c170a99076d434cef280"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YourAccount_ShowInvite), @"mvc.1.0.view", @"/Views/YourAccount/ShowInvite.cshtml")]
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
#line 1 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\_ViewImports.cshtml"
using New_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\_ViewImports.cshtml"
using New_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\ShowInvite.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"100ae6de694cddd6b848c170a99076d434cef280", @"/Views/YourAccount/ShowInvite.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaced973f86b19111e44db56712c7022ff3815", @"/Views/_ViewImports.cshtml")]
    public class Views_YourAccount_ShowInvite : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>

                                                    .tooltip {
                                                            position: relative;
                                                            display: inline-block;
                                                            }

                                                            .tooltip .tooltiptext {
                                                            visibility: hidden;
                                                            width: 140px;
                                                            background-color: #555;
                                                            color: #fff;
                                                            text-align: center;
                                                            border-radius: 6px;
                                                            padding: 5px;
                                                            position: absolute;");
            WriteLiteral(@"
                                                            z-index: 1;
                                                            bottom: 150%;
                                                            left: 50%;
                                                            margin-left: -75px;
                                                            opacity: 0;
                                                            transition: opacity 0.3s;
                                                            }

                                                            .tooltip .tooltiptext::after {
                                                            content: """";
                                                            position: absolute;
                                                            top: 100%;
                                                            left: 50%;
                                                            margin-left: -5px;
                          ");
            WriteLiteral(@"                                  border-width: 5px;
                                                            border-style: solid;
                                                            border-color: #555 transparent transparent transparent;
                                                            }

                                                            .tooltip:hover .tooltiptext {
                                                            visibility: visible;
                                                            opacity: 1;
                                                            }



                                                </style>
            <div class=""row"">

                <div style=""border-radius: 9px; background-image: url(../assets/img/theme/14.jpg);margin-top: 25px; background-size: cover;"" class=""mr-auto ml-auto card mb-3 shadow"">
                   
");
            WriteLiteral(@"                                <div class="" mt-2 "" style=""text-align: center;"">
                                    <div class=""row"" >
                                        <h5 class=""mr-5 ml-5 pr-5 pl-5 text-info"">دعوت دوستان به نو نو</h5>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-12 text-center  mt-2"">
                                            <span class=""d-block profile-username  text-info mb-2""  style=""font-size: 12px;""> لینک دعوت من :
                                                <span class=""text-info"">
                                                            <!-- The text field -->
");
#nullable restore
#line 63 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\ShowInvite.cshtml"
                                                              
                                                                var s = HttpContextAccessor.HttpContext.Session.GetString("RLink");
                                                                    if (s !=null)
                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        <!-- The text field -->\r\n                                                                        <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 4467, "\"", 4497, 2);
            WriteAttributeValue("", 4475, "www.noeno.ir/invite/", 4475, 20, true);
#nullable restore
#line 68 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\ShowInvite.cshtml"
WriteAttributeValue("", 4495, s, 4495, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""myInput"">
                                                                        <!-- The button used to copy the text -->
                                                                        <button class=""btn-info"" onclick=""myFunction()""> کپی </button>
");
#nullable restore
#line 71 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\ShowInvite.cshtml"

                                                                    }
                                                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </span> 
                                            </span>
                                        </div>
                                               
                                    </div>
                                </div>
                                <div class=""profile-point mt-1 mb-2"">
                                    <div class=""row"" style=""display: flex; justify-content: center;"">
                                        <h6 class="" ml-2  label-profile-point"">کد معرف من:</h6>
                                            <h6 class="" ml-2  label-profile-point text-info""> ");
#nullable restore
#line 83 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\ShowInvite.cshtml"
                                                                                         Write(User.Identity.GetId());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                    </div>
                                </div>
                                <div class=""profile-point mt-1 mb-2"">
                                    <div class=""row"" style=""display: flex; justify-content: center;"">
                                        <h6 class="" ml-2  label-profile-point"" style=""font-size: 14px;"">تعداد دعوت شدگان:</h6>
                                        <h6 class="" ml-2  label-profile-point text-info""> ");
#nullable restore
#line 89 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\ShowInvite.cshtml"
                                                                                     Write(ViewBag.s);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" نفر </h6>
                                      
                                    </div>
                                    <div class=""row"" style=""display: flex; justify-content: center;"">
                                        <h6 class="" ml-2  label-profile-point"" style=""font-size: 14px;"">تعداد دعوت شدگان تبدیل شده به مشتری:</h6>
                                        <h6 class="" ml-2  label-profile-point text-info""> ");
#nullable restore
#line 94 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\ShowInvite.cshtml"
                                                                                     Write(ViewBag.o);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" نفر </h6>
                                      
                                    </div>
                                    <div class=""row"" style=""display: flex; justify-content: center;"">
                                        <h6 class="" ml-2  label-profile-point"" style=""font-size: 14px;"">جایزه حاصل شده از دعوت ها :</h6>
                                        <h6 class="" ml-2  label-profile-point text-info"" id=""mp""> ");
#nullable restore
#line 99 "c:\Users\MS\Desktop\Noeno00-03-06\Noeno\New_Project\Views\YourAccount\ShowInvite.cshtml"
                                                                                             Write(ViewBag.t);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" تومان </h6>
                                        <script>
                                                document.getElementById(""mp"").innerText=document.getElementById(""mp"").innerText.toString().replace(/\B(?=(\d{3})+(?!\d))/g, "","");
                                                
                                        </script>
                                      
                                    </div>
                                </div>
");
            WriteLiteral(@"                                    <div class=""row"">
                                        <div class=""col-12 text-center"">
                                            <a  href=""/YourAccount/InviteDetail"" class=""btn btn-info ml-2 mt-2 mb-2 shadow"" >
                                                       مشاهده جزئیات
                                            </a> 
                                        </div>
                                    </div>
                </div>
            </div>


                                                 <script>
                                                     function myFunction() {
                                                        /* Get the text field */
                                                        var copyText = document.getElementById(""myInput"");

                                                        /* Select the text field */
                                                        copyText.select();
                 ");
            WriteLiteral(@"                                       copyText.setSelectionRange(0, 99999); /* For mobile devices */

                                                        /* Copy the text inside the text field */
                                                        document.execCommand(""copy"");

                                                        /* Alert the copied text */
                                                        alert(""Copied the text: "" + copyText.value);
                                                        }


                                                </script>
                
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
