using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DataLayer.AdminEntities.Order;
using DataLayer.AdminEntities.wallet;
using DataLayer.Context;
using DataLayer.Entities;
using Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using New_Project.Models;
using ViewModel.AdminViewModel.Order;
using ViewModel.Entities;
using ViewModel.Entities.User;
using ViewModels.AdminViewModel.Wallet;


namespace New_Project.Controllers
{


    public class CartController : BaseController
    {
        public static int sum;
         public static string msg;
        public CartController(Context_db _db, IWebHostEnvironment env) : base(_db, env)
        {

        }


        public IActionResult index()
        {
             var A1= db.Tbl_Factors.Where(a =>a.Id_Order.ToString()==User.Identity.GetId()&&a.Pay!="Ok").ToList().Count();
             HttpContext.Session.SetString ("count", A1.ToString() );
            int sum=0;
            int sum2=0;
            int sum3=0;
            var A=db.Tbl_Factors.Where(a =>a.Id_Order==Convert.ToInt32(User.Identity.GetId()) &&a.Pay==null).ToList();
            ViewBag.A=db.Tbl_Factors.Where(a =>a.Id_Order==Convert.ToInt32(User.Identity.GetId()) &&a.Pay==null).ToList();
            ViewBag.A1=db.Tbl_Factors.Where(a =>a.Id_Order==Convert.ToInt32(User.Identity.GetId()) &&a.Pay==null).Count();
              
            foreach (var item in  A)
            {
            var price=db.Tbl_Factors.Where(a =>a.Id_Order==Convert.ToInt32(User.Identity.GetId()) &&a.Pay==null&&a.Id==item.Id).SingleOrDefault();
                
              sum=sum+Convert.ToInt32(price.product_Price);
              sum2=sum2+Convert.ToInt32(price.PriceB);
              sum3=sum+sum2;
                
            }
            ViewBag.A2=sum;
            ViewBag.A3=sum2;
            ViewBag.A4=sum3;
             HttpContext.Session.SetString("sumall",sum3.ToString());
            
            
            return View();
        }


        public IActionResult minez(int id)
        {
            string b = HttpContext.Session.GetString("shop");
            var regex = new Regex(Regex.Escape(id.ToString()));
            HttpContext.Session.SetString("shop", regex.Replace(b, "", 1));


            return RedirectToAction("index", "cart");
        }
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult del(int id)
        {


            // string b = HttpContext.Session.GetString("shop");
            // HttpContext.Session.SetString("shop", b.Replace(id.ToString(), ""));

          var B=db.Tbl_Factors.Where(a =>a.Id_Order==Convert.ToInt32(User.Identity.GetId())&&a.Id==id).SingleOrDefault();
          db.Tbl_Factors.Remove(B);
          db.SaveChanges();






            return RedirectToAction("index", "cart");
        }
        public IActionResult del2(int id)
        {


            string b1 = HttpContext.Session.GetString("shop1");


            HttpContext.Session.SetString("shop1", b1.Replace(id.ToString(), ""));






            return RedirectToAction("index", "cart");
        }

        public IActionResult card2()
        {
            if (msg!=null)
            {
                ViewBag.msg=msg;
                msg=null;
                
            }
            List<Vm_Pay> A = new List<Vm_Pay>();

            var a = db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId()) && a.status == true).OrderByDescending(a => a.Id).ToList();


            foreach (var item in a)
            {

                Vm_Pay B = new Vm_Pay()
                {
                    Id = item.Id,
                    Phone = item.Phone,
                    Pay = item.Pay,
                    Harvest = item.Harvest,
                    Paytime = item.Paytime.ToPersianDateString(),
                    status = item.status,
                    iduser = item.iduser,
                    NameFamily = item.NameFamily,





                };
                A.Add(B);
            }


            HttpContext.Session.SetString("pay", Diposit().ToString());
            ViewBag.list2 = A.OrderByDescending(a => a.Id);

            return View();
        }

        public int Diposit()
        {
            int pay = db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId()) && a.status == true).Sum(a => a.Pay);
            int horvest = db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId())).Sum(a => a.Harvest);
            return pay - horvest;
        }

        public IActionResult card3()
        {
            var B = db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId())).OrderByDescending(a => a.Id).Take(1).SingleOrDefault().Harvest;
            ViewBag.A = B;
            var d = db.Tbl_Order.Where(a => a.Id_user == Convert.ToInt32(User.Identity.GetId())).OrderByDescending(a => a.Id).Take(1).SingleOrDefault().Pay;

            ViewBag.R = Convert.ToInt32(d) - B;

            // TODO: Your code here
            return View();
        }


        public IActionResult factor()
        {

            // var userid = db.Tbl_Users.Where(a => a.Id.ToString() == (User.Identity.GetId())).SingleOrDefault();
            // if (userid != null)
            // {
            //     var qorder = db.Tbl_Order.Where(a => a.Id_user == userid.Id).ToList();

            //     List<Vm_Order> p = new List<Vm_Order>();

            //     foreach (var item in qorder)
            //     {
            //         var vorder = new Vm_Order()
            //         {
            //             Id = item.Id,
            //             datesave = item.Date_Order.ToPersianDateString(),
            //             Pay = item.Pay,
            //             State = item.State
            //         };

            //         p.Add(vorder);

            //     }

            //     ViewBag.list = p.OrderByDescending(a => a.Id).ToList();
            // }
            var A=db.Tbl_Factors.Where(a =>a.Id_Order==Convert.ToInt32(User.Identity.GetId())).OrderByDescending(a =>a.Id).Take(1).SingleOrDefault().Id_Factro;
             ViewBag.factor=db.Tbl_Factors.Where(i =>i.Id_Factro==A&&i.Pay=="Ok").ToList();



            return View();




        }

        public IActionResult details(int id)
        {


            ViewBag.list = db.Tbl_Factors.Where(a => a.Id_Order == id).ToList();

            return View();



        }

        public IActionResult details2(int id)
        {

            ViewBag.list = db.tbl_Advertisings.Where(a => a.Id == id).SingleOrDefault().Image;
            var A = db.tbl_Advertisings.Where(a => a.Id == id).SingleOrDefault();
            ViewBag.B = db.Tbl_Users.Where(a => a.Id.ToString() == A.Id_creator).SingleOrDefault().NameFamily;
            ViewBag.B2 = db.Tbl_Users.Where(a => a.Id.ToString() == A.Id_creator).SingleOrDefault().Phone;
            ViewBag.B3 = db.Tbl_Adress.Where(a => a.IdUser.ToString() == (User.Identity.GetId())).OrderByDescending(a => a.Id).Take(1).SingleOrDefault().State;
            ViewBag.B4 = db.Tbl_Adress.Where(a => a.IdUser.ToString() == (User.Identity.GetId())).OrderByDescending(a => a.Id).Take(1).SingleOrDefault().City;
            ViewBag.B5 = db.Tbl_Adress.Where(a => a.IdUser.ToString() == (User.Identity.GetId())).OrderByDescending(a => a.Id).Take(1).SingleOrDefault().FirstAddress;




            return View();



        }








        public IActionResult buy()
        {





            if (HttpContext.Session.GetString("shopF") != null)
            {
                String[] listshop = (HttpContext.Session.GetString("shopF")).Split(",");







                if (listshop != null)
                {

                    List<Vm_Advertising> q = new List<Vm_Advertising>();

                    foreach (var item in listshop)
                    {
                        var product = db.tbl_Advertisings.Where(a => a.Id.ToString() == item).SingleOrDefault();

                        if (product != null)
                        {

                            Vm_Advertising M = new Vm_Advertising()
                            {
                                Id = product.Id,
                                Id_creator = product.Id_creator,
                                Title_Pro = product.Title_Pro,
                                Main_Price = product.Main_Price,
                                Discount_Price = product.Discount_Price,
                                Type_Transaction = product.Type_Transaction,
                                Image = product.Image,
                                Number = 1



                            };

                            var v = q.Where(a => a.Id == product.Id).SingleOrDefault();
                            if (v != null)
                            {
                                v.Number++;

                            }
                            else
                            {
                                q.Add(M);
                            }






                        }


                    }

                    //////////add order and factor
                    var userid = db.Tbl_Users.Where(a => a.Id.ToString() == User.Identity.GetId()).SingleOrDefault();

                    // var Order = new Tb_Order()
                    // {
                    //     Date_Order = DateTime.Today,
                    //     Id_user = userid.Id,
                    //     Pay = HttpContext.Session.GetString("sumS2"),
                    //     State = "نقدی"

                    // };
                    // db.Tbl_Order.Add(Order);
                    // db.SaveChanges();
                    // var finalorder = db.Tbl_Order.OrderByDescending(a => a.Id).Take(1).SingleOrDefault();

                    foreach (var item in q)
                    {
                        // int orderid = finalorder.Id;
                        var A = db.Tbl_Price.ToList();
                        foreach (var item1 in A)
                        {

                            if (item.Type_Transaction == "از طریق سیستم بازرسی کالا")
                            {


                                if (Convert.ToInt32(item1.Min) < Convert.ToInt32(item.Discount_Price) && Convert.ToInt32(item.Discount_Price) < Convert.ToInt32(item1.Max))
                                {

                                    var S = (Convert.ToInt32(item.Discount_Price) * Convert.ToInt32(item1.Price) / 100) + Convert.ToInt32(item.Discount_Price);
                                    var S1 = (Convert.ToInt32(item.Discount_Price) * Convert.ToInt32(item1.Price) / 100);
                                    var S2 = db.Tbl_Users.Where(a => a.Id == Convert.ToInt32(item.Id_creator)).SingleOrDefault();
                                    var S3 = db.Tbl_Users.Where(a => a.Id == Convert.ToInt32(User.Identity.GetId())).SingleOrDefault();
                                    var b = new Tb_Factor()
                                    {
                                        Id_creator = Convert.ToInt32(item.Id_creator),
                                        Id_Order = Convert.ToInt32(User.Identity.GetId()),
                                        Product_Id = item.Id,
                                        product_Name = item.Title_Pro,
                                        Product_Count = item.Number,
                                        PriceB = S1,
                                        product_Price = Convert.ToInt32(item.Discount_Price),
                                        Total_sum = Convert.ToInt32(item.Discount_Price) + S1,
                                        Date_Order = DateTime.Today,
                                        Type_Transaction = "از طریق سیستم بازرسی کالا",
                                        TellSel = S2.Phone,
                                        TellBuy = S3.Phone,
                                        NameBuy = S3.NameFamily,
                                        NameSel = S2.NameFamily,
                                        Image = S2.Image,



                                    };

                                    db.Tbl_Factors.Add(b);
                                    db.SaveChanges();
                                    HttpContext.Session.SetString("shopF", "");

                                }
                            }



                        }

                        if (item.Type_Transaction != "از طریق سیستم بازرسی کالا")
                        {
                            var S2 = db.Tbl_Users.Where(a => a.Id == Convert.ToInt32(item.Id_creator)).SingleOrDefault();
                            var S3 = db.Tbl_Users.Where(a => a.Id == Convert.ToInt32(User.Identity.GetId())).SingleOrDefault();

                            var X = new Tb_Factor()
                            {
                                Id_creator = Convert.ToInt32(item.Id_creator),
                                Id_Order = Convert.ToInt32(User.Identity.GetId()),
                                Product_Id = item.Id,
                                product_Name = item.Title_Pro,
                                Product_Count = item.Number,
                                PriceB = 0,
                                product_Price = Convert.ToInt32(item.Discount_Price),
                                Total_sum = Convert.ToInt32(item.Discount_Price),
                                Date_Order = DateTime.Today,
                                Type_Transaction = "از طریق سیستم بازرسی کالا",
                                TellSel = S2.Phone,
                                TellBuy = S3.Phone,
                                NameBuy = S3.NameFamily,
                                NameSel = S2.NameFamily,
                                Image = S2.Image,

                            };


                            db.Tbl_Factors.Add(X);
                            db.SaveChanges();
                            HttpContext.Session.SetString("shopF", "");


                        }










                    }
                    ////////////////////////////////////////////////////////////////////////








                }

            }



            return RedirectToAction("Card2");
        }






              public IActionResult payUser2(Vm_User A)
        {

            var q = db.Tbl_Users.Where(a => a.Id.ToString() == (User.Identity.GetId())).SingleOrDefault();
            var q2 = db.Tbl_Factors.Where(a => a.Id_Order == Convert.ToInt32(User.Identity.GetId()) && a.Pay == null).ToList();
             

              int Rn;
              var R=new Random();
              Rn=R.Next(100000, 999999);
            if (q != null)
            {
                if (Convert.ToInt32(HttpContext.Session.GetString("pay")) >= Convert.ToInt32(HttpContext.Session.GetString("sumall")))
                {
              
                    Tbl_pay B = new Tbl_pay()
                    {
                        Id_Factro=Rn,
                        Phone = q.Phone,
                        Harvest = Convert.ToInt32(HttpContext.Session.GetString("sumall")),
                        havesttime = DateTime.UtcNow,
                        iduser = Convert.ToInt32(User.Identity.GetId()),
                        Paytime = DateTime.UtcNow,



                    };

                    db.tbl_Pays.Add(B);
                    db.SaveChanges();
                    if (q2 != null)
                    {
                        foreach (var item in q2)
                        {
                            var q3 = db.Tbl_Factors.Where(a => a.Id == item.Id && a.Pay == null).SingleOrDefault();
                            var q4=db.tbl_Advertisings.Where(a =>a.Id==item.Product_Id).SingleOrDefault();
                             q4.Number--;
                              q3.Pay="Ok";
                              q3.StatusA="R";
                              q3.StatusM="در انتظار تایید فروشنده";
                              q3.Id_Factro=Rn;
                              q.RPass="Ok";
                              db.Tbl_Factors.Update(q3);
                              db.tbl_Advertisings.Update(q4);
                              db.Tbl_Users.Update(q);
                              db.SaveChanges(); 




                        }
                    }


                    HttpContext.Session.SetString("pay", Diposit().ToString());
                    string b = Diposit().ToString();
                }
                else
                {
                    HttpContext.Session.SetString("pay", Diposit().ToString());
                    msg = "اعتبار شما کافی نیست لطفا کیف پول خو را شارژ کنید";

                    return RedirectToAction("card2");
                }
            }


                    return RedirectToAction("Factor", "cart");
                }



    }
}