using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using New_Project.Models;
using ViewModel.Entities;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using DataLayer.AdminEntities.Blog;
using DataLayer.Entities.User;
using ViewModel.Entities.User;
using ViewModel.AdminViewModel.Order;
using DataLayer.AdminEntities.Order;
using Newtonsoft.Json;

namespace New_Project.Controllers
{
    public class HomeController : BaseController
    {
        public static string massage;
        public HomeController(Context_db _db, IWebHostEnvironment env) : base(_db, env)
        {

        }

        public IActionResult Index()
        {
             menu.find=db.tbl_Advertisings.Select(a=>a.Title_Pro).ToList();
            
            var A= db.Tbl_Factors.Where(a =>a.Id_Order.ToString()==User.Identity.GetId()&&a.Pay!="Ok").ToList().Count();
             HttpContext.Session.SetString ("count", A.ToString() );

             var sms=db.Tbl_Comments.Where(a =>a.Resever_Id==User.Identity.GetId()&&a.State==false).ToList().Count();
              HttpContext.Session.SetString ("sms", sms.ToString() );

            setdata();
            ////////////////////////////////////////////////////////////////////////////////////////////////address
            var address = db.Tbl_Adress.Where(a => a.Language == ln).ToList();
            if (address != null)
            {
                ViewBag.address = address;

            }
            else
            {
                ViewBag.address = null;
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////blog

            var blog = db.Tbl_Blog.Where(a => a.Language == ln).OrderByDescending(a => a.Id).Take(4).ToList();
            if (blog != null)
            {
                ViewBag.blog = blog;
            }

            //////////////////////////////////////////////////////////////////slider
         var qslider = db.Tbl_Slider.Where(a => a.Language != "A").OrderByDescending(a => a.Id).ToList();
            if (qslider != null)
            {
                ViewBag.slider = qslider;
            }
              var qslider1 = db.Tbl_Slider.Where(a => a.Language == "A").OrderByDescending(a => a.Id).ToList();
            if (qslider != null)
            {
                ViewBag.slider1 = qslider1;
            }

            //////////////////////////////////////////////////////////////////baner
            var qbaner3 = db.Tbl_Baner.Where(a => a.CategoryProductIdSlid==1).ToList();
            if (qbaner3 != null)
            {
                ViewBag.baner3 = qbaner3;
            }
            var qbaner2 = db.Tbl_Baner.Where(a => a.CategoryProductIdSlid==2).ToList();
            if (qbaner2 != null)
            {
                ViewBag.baner2 = qbaner2;
            }
            var qbaner1 = db.Tbl_Baner.Where(a => a.CategoryProductIdSlid==3).ToList();
            if (qbaner1 != null)
            {
                ViewBag.baner1 = qbaner1;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////first_page
            var qfirst = db.tbl_category.Where(a => a.FatherIdCat == -3).ToList();

            List<Tb_Blog> blg = new List<Tb_Blog>();
            foreach (var item in qfirst)
            {
                var first = db.Tbl_Blog.Where(a => a.IdCtegoryBlo == item.Id && a.Language == ln).SingleOrDefault();
                if (first != null)
                {
                    blg.Add(first);
                }

            }

            if (blg != null)
            {
                ViewBag.first = blg.OrderByDescending(a => a.Id).Take(2).ToList();
            }

            ///////////////////////////////////////////////////////////////////////////////teaser
            ViewBag.Teaser = db.Tbl_Teaser.Where(a => a.Language == ln).OrderByDescending(a => a.Id).Take(3).ToList();
            ////////////////////////////////////////////////////////////////////////////////product list
            ViewBag.product = db.Tbl_Product.Where(a => a.Language == ln).OrderByDescending(a => a.Id).Take(6).ToList();
            //////////////////////////////////////////////////////////////////////////////////expert list
            ViewBag.expert = db.Tbl_Experts.Where(a => a.Language == ln).OrderByDescending(a => a.Id).ToList();
            
            ViewBag.product2 = db.tbl_Advertisings.Where(a => a.Special == "جدید نو نو" && a.State=="تایید شده").OrderByDescending(a => a.Id).Take(6).ToList();
            ViewBag.product3 = db.tbl_Advertisings.Where(a => a.Special == "منتخب نو نو" && a.State=="تایید شده").OrderByDescending(a => a.Id).Take(6).ToList();
            ViewBag.product4 = db.tbl_Advertisings.Where(a => a.Special == "حراج نو نو" && a.State=="تایید شده").OrderByDescending(a => a.Id).Take(6).ToList();
            ViewBag.product5 = db.tbl_Advertisings.Where(a => a.Special == "خوش قیمت نونو" && a.State=="تایید شده").OrderByDescending(a => a.Id).Take(6).ToList();



            if (massage != null)
            {
                ViewBag.msg = massage;
                massage = null;

            }

            ViewBag.list = db.Tbl_SendNumberCodes.OrderByDescending(a => a.Id).ToList();


            ViewBag.list1 = db.Tbl_SendNumberCodes.OrderByDescending(a => a.Id).ToList();


            return View();
        }

        public IActionResult CAtegory(int id)
        {
            ViewBag.oll=db.tbl_Advertisings.Where(a =>a.Category==id.ToString()).ToList();
            return View();
        }
           public IActionResult CAtegory4(int c)
        {
            if (c==1)
            {
                 ViewBag.oll=db.tbl_Advertisings.Where(a =>a.Special=="جدید نو نو").ToList();
            }
             if (c==2)
            {
                 ViewBag.oll=db.tbl_Advertisings.Where(a =>a.Special=="منتخب نو نو").ToList();
            }
              if (c==3)
            {
                 ViewBag.oll=db.tbl_Advertisings.Where(a =>a.Special=="حراج نو نو").ToList();
            }
               if (c==4)
            {
                 ViewBag.oll=db.tbl_Advertisings.Where(a =>a.Special=="خوش قیمت نونو").ToList();
            }
           
            return View();
        }
        public IActionResult CAtegory2(int id)
        {
          
        
                ViewBag.oll=db.tbl_Advertisings.Where(a =>a.FatherIdCat==id.ToString()).ToList();
               
           
            return View();
        }

         public IActionResult search(string myInput)
        {
          
        
                ViewBag.oll=db.tbl_Advertisings.Where(a=>a.Title_Pro.Contains(myInput)).ToList();
               
           
            return View();
        }

           public IActionResult CAtegory3(int c)
        {
            if (c==1)
            {
               ViewBag.oll=db.tbl_Advertisings.Where(a =>a.Father=="کالای دیجیتال").ToList(); 
            }
               if (c==2)
            {
                ViewBag.oll=db.tbl_Advertisings.Where(a =>a.Father=="زیبایی و سلامتی").ToList();  
            }
               if (c==3)
            {
                 ViewBag.oll=db.tbl_Advertisings.Where(a =>a.Father=="ابزارآلات و تجهیزات").ToList(); 
            }
               if (c==4)
            {
                 ViewBag.oll=db.tbl_Advertisings.Where(a =>a.Father=="مد و پوشاک").ToList(); 
            }
               if (c==5)
            {
                 ViewBag.oll=db.tbl_Advertisings.Where(a =>a.Father=="خانه و آشپزخانه").ToList(); 
            }
               if (c==6)
            {
                 ViewBag.oll=db.tbl_Advertisings.Where(a =>a.Father=="فرهنگ و هنر").ToList(); 
            }
               if (c==7)
            {
                 ViewBag.oll=db.tbl_Advertisings.Where(a =>a.Father=="سرگرمی،کودک و نوزاد").ToList(); 
            }
               if (c==8)
            {
                 ViewBag.oll=db.tbl_Advertisings.Where(a =>a.Father=="ورزش و سفر").ToList(); 
            }
          
        
                
               
           
            return View();
        }


        public IActionResult add(Vm_SendNumberCode VmSend)
        {

            Tbl_SendNumberCode TblSend = new Tbl_SendNumberCode()
            {
                Name = VmSend.Name,
                LessonName = VmSend.LessonName,
                Number = VmSend.Number

            };
            db.Tbl_SendNumberCodes.Add(TblSend);
            db.SaveChanges();
            massage = "اطلاعات شما با موفقیت ثبت شد";

            return RedirectToAction("index");
        }

        public IActionResult exit()
        {
            HttpContext.Session.Remove("img");
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("index", "home");

        }

          public IActionResult AddCart(Vm_Advertising order, int id)
        {

             



            var Count = db.Tbl_Factors.Where(a => a.Product_Id == id&&a.Id_Order.ToString()==User.Identity.GetId()&&a.Pay!="Ok").ToList().Count();
            var Count1 = db.tbl_Advertisings.Where(a => a.Id == order.Id).SingleOrDefault().Number;

         

            if (Count1>Count)
            {
                
            

            var A = db.tbl_Advertisings.Where(a => a.Id == order.Id).SingleOrDefault();
            var A1 = db.Tbl_Users.Where(a => a.Id == Convert.ToInt32(A.Id_creator)).SingleOrDefault();
            var A2 = db.Tbl_Users.Where(a => a.Id == Convert.ToInt32(User.Identity.GetId())).SingleOrDefault();
            var A3 = db.Tbl_Price.Where(a => a.Cat_Type == "بازرسی").ToList();
            var  A4=db.Tbl_Price.Where(a => a.Cat_Type == "کمسیون").ToList();
            foreach (var item in  A4)
            {
                 if (Convert.ToInt32(item.Min) < Convert.ToInt32(A.Discount_Price) && Convert.ToInt32(A.Discount_Price) < Convert.ToInt32(item.Max))
                    {
                        var S2 = (Convert.ToInt32(A.Discount_Price) * Convert.ToInt32(item.Price)) / 100;
                        ViewBag.S2=S2.ToString();
                    }
                
            }

            if (order.Type_Transaction == "از طریق سیستم بازرسی کالا" || A.Type_Transaction == "از طریق سیستم بازرسی کالا")

            {
                foreach (var item in A3)
                {


                    if (Convert.ToInt32(item.Min) < Convert.ToInt32(A.Discount_Price) && Convert.ToInt32(A.Discount_Price) < Convert.ToInt32(item.Max))
                    {
                        var S1 = (Convert.ToInt32(A.Discount_Price) * Convert.ToInt32(item.Price)) / 100;
                        var b = new Tb_Factor()
                        {
                            Id_creator = Convert.ToInt32(A.Id_creator),
                            Id_Order = Convert.ToInt32(User.Identity.GetId()),
                            Product_Id = A.Id,
                            product_Name = A.Title_Pro,
                            product_Price = Convert.ToInt32(A.Discount_Price),
                            Date_Order = DateTime.Today,
                            Type_Transaction = "بازرسی",
                            TellSel = A1.Phone,
                            TellBuy = A2.Phone,
                            NameBuy = A2.NameFamily,
                            NameSel = A1.NameFamily,
                            Image = A.Image,
                            PriceB = S1.ToString(),
                            PriceK=ViewBag.S2,
                            Total_sum = Convert.ToInt32(A.Discount_Price) + S1,




                        };
                        db.Tbl_Factors.Add(b);
                        db.SaveChanges();
                    }

                }


            }
            else
            {
                var b = new Tb_Factor()
                {
                    Id_creator = Convert.ToInt32(A.Id_creator),
                    Id_Order = Convert.ToInt32(User.Identity.GetId()),
                    Product_Id = A.Id,
                    product_Name = A.Title_Pro,
                    product_Price = Convert.ToInt32(A.Discount_Price),
                    Date_Order = DateTime.Today,
                    Type_Transaction = "مستقیم",
                    TellSel = A1.Phone,
                    TellBuy = A2.Phone,
                    NameBuy = A2.NameFamily,
                    NameSel = A1.NameFamily,
                    Image = A.Image,
                    PriceB = "0",
                    PriceK=ViewBag.S2,
                    Total_sum = Convert.ToInt32(A.Discount_Price),




                };
                db.Tbl_Factors.Add(b);
                db.SaveChanges();
            }
            }

                var sd= db.Tbl_Factors.Where(a =>a.Id_Order.ToString()==User.Identity.GetId()&&a.Pay!="Ok").ToList().Count();
             HttpContext.Session.SetString ("count", sd.ToString() );


            return RedirectToAction("index","singlepage", new{id});
        }
        public IActionResult AddCart2(int id)
        {   var A6 = db.Tbl_Factors.Where(a => a.Id == id && a.Id_Order == Convert.ToInt32(User.Identity.GetId()) && a.Pay == null).SingleOrDefault().Product_Id;
             var Count1 = db.tbl_Advertisings.Where(a => a.Id == A6).SingleOrDefault().Number;
             var Count = db.Tbl_Factors.Where(a => a.Product_Id ==A6&&a.Id_Order.ToString()==User.Identity.GetId()&&a.Pay!="Ok").ToList().Count();
              if (Count1>Count)
            {
               
            
            var A4 = db.Tbl_Factors.Where(a => a.Id == id && a.Id_Order == Convert.ToInt32(User.Identity.GetId()) && a.Pay == null).SingleOrDefault();
            var b = new Tb_Factor()
            {
                Id_creator = Convert.ToInt32(A4.Id_creator),
                Id_Order = A4.Id_Order,
                Product_Id = A4.Product_Id,
                product_Name = A4.product_Name,
                product_Price = A4.product_Price,
                Date_Order = DateTime.Today,
                Type_Transaction = A4.Type_Transaction,
                TellSel = A4.TellSel,
                TellBuy = A4.TellBuy,
                NameBuy = A4.NameBuy,
                NameSel = A4.NameSel,
                Image = A4.Image,
                PriceB = A4.PriceB,
                PriceK=A4.PriceK,
                Total_sum = A4.Total_sum, 
              };
               db.Tbl_Factors.Add(b);
               db.SaveChanges();
            }
            return RedirectToAction("index", "Cart");
        }

        ////test serch
        public IActionResult test()
        {
           menu.find=db.tbl_Advertisings.Select(a=>a.Title_Pro).ToList();
             
           
            return View();
        }


         
        
    }
}