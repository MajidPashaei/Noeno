using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.AdminEntities.Blog;
using DataLayer.AdminEntities.Comment;
using DataLayer.Context;
using New_Project.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModel.AdminViewModel.Originality;

namespace New_Project.Controllers
{
    public class BaseController : Controller
    {
        ////////////////////////////////////////////////////type db
        public readonly Context_db db;
        public readonly IWebHostEnvironment _env;


        public static string ln = "fa", error, eror, suc, NewFileName;

        public BaseController(Context_db _db, IWebHostEnvironment env)
        {
            _env = env;
            db = _db;

        }

        public void setdata()
        {
            menu.cat = db.tbl_category.Where(a => a.Language == ln).ToList();
            menu.Richat = db.Tbl_Richats.SingleOrDefault()?.ScriptChat;
            menu.enemad = db.Tbl_Richats.SingleOrDefault()?.enemad;

            /////////////////////////////////////////////////////////////////////////////count cart basket
            if (User.Identity.IsAuthenticated)
            {
                var qorder = db.Tbl_Order.Where(a => a.Id_user == Convert.ToInt32(User.Identity.GetId()) && a.State == "record").SingleOrDefault();
                if (qorder != null)
                {
                    var qf = db.Tbl_Factors.Where(a => a.Id_Order == qorder.Id).ToList();
                    if (qorder != null)
                    {
                        int sum = 0;
                        if (qf.Count() != 0)
                        {
                            foreach (var item in qf)
                            {
                                sum = sum + item.Product_Count;
                            }
                            menu.order_count = sum;
                        }
                        else
                        {
                            menu.order_count = 0;
                        }

                    }

                }

            }
            else
            {
                menu.order_count = 0;
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////count msg
            menu.resiver = db.Tbl_Message.Where(a => a.StateMess == false && a.SenderMess == "admin" && a.ResiverMess == User.Identity.GetId()).Count();
            menu.sender = db.Tbl_Message.Where(a => a.StateMess == false && a.SenderMess == User.Identity.GetId()).Count();
            ///////////////////////////////////////////////////////////////////////////logo & titel
            var logo = db.Tbl_Logo.Where(a => a.Language == ln).SingleOrDefault();
            if (logo != null)
            {
                menu.logo = logo.ImageLogo;
                menu.Title = logo.TitleLogo;
                menu.favicon = logo.FavIcon;


            }
            else
            {
                menu.logo = null;
                menu.Title = null;
                menu.favicon = null;

            }
            /////////////////////////////////////////////////////////////////////////////////favicon
            ///////////////////////////////////////////////////////////////////////////logo & titel
            var D = db.tbl_category.Where(a => a.Language == "کالای دیجیتال").ToList();
            menu.D = D;
            var A = db.tbl_category.Where(a => a.Language == "زیبایی و سلامتی").ToList();
            menu.A = A;
            var kh = db.tbl_category.Where(a => a.Language == "ابزارآلات و تجهیزات" ).ToList();
            menu.kh = kh;
            var M = db.tbl_category.Where(a => a.Language == "مد و پوشاک").ToList();
            menu.M = M;
            var Kitchen = db.tbl_category.Where(a => a.Language == "خانه و آشپزخانه" ).ToList();
            menu.Kitchen = Kitchen;
            var L = db.tbl_category.Where(a => a.Language == "فرهنگ و هنر"  ).ToList();
            menu.L = L;
            var N = db.tbl_category.Where(a => a.Language == "سرگرمی،کودک و نوزاد" ).ToList();
            menu.N = N;
            var S = db.tbl_category.Where(a => a.Language == "ورزش و سفر" ).ToList();
            menu.S = S;
            /////////////////////////////////////////////////////////////////////////////////favicon

            ////////////////////////////////////////////////////////////////////////////////social network
            var social = db.Tbl_SocialNetwork.ToList();
            if (social != null)
            {
                menu.social = social;

            }
            else
            {
                menu.social = null;
            }
            /////////////////////////////////////////////////////////////////////////////search product
            var qproduct = db.Tbl_Product.Where(a => a.Language == ln).ToList();
            List<String> lp = new List<string>();
            foreach (var item in qproduct)
            {
                lp.Add(item.TitleProductPro);
            }
            ViewData["FieldsList"] = lp;
            /////////////////////////////////////////////////////////////////////////////search blog
            var qproduct1 = db.Tbl_Blog.ToList();
            List<String> lp1 = new List<string>();
            foreach (var item in qproduct1)
            {
                lp1.Add(item.TitleBLo);
            }
            ViewData["FieldsList1"] = lp1;

        }

    }
}