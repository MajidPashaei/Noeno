using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using New_Project.Models;
using ViewModel.AdminViewModel.Kala;
using ViewModel.Entities.User;
using DataLayer.Entities.User;
using Extensions;
using DataLayer.AdminEntities.Product;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using ViewModels.AdminViewModel.Wallet;
using DataLayer.AdminEntities.Address;

namespace New_Project.Controllers {

   
    public class YourAccount2Controller : Controller {
        public static string massage,eror, NewFileName,NewFileName2, msg;

        private readonly Context_db db;
        private readonly IWebHostEnvironment env;

        public YourAccount2Controller (Context_db _db, IWebHostEnvironment _env) {
            db = _db;
            env = _env;
        }
   
    

        public async Task<IActionResult> AdditionalInfo () {

            var qcheck = db.Tbl_Users.Where (a => a.Id.ToString () == User.Identity.GetId ()).SingleOrDefault ();
              if (qcheck.Image != null) {
                HttpContext.Session.SetString ("img", qcheck.Image);
            }


            if (msg != null)

            {

                ViewBag.msg = msg;
                msg = null;
            }

       
            if (qcheck != null) {
                Vm_User VmUs = new Vm_User () {
                Id = qcheck.Id,
                Phone = qcheck.Phone,
                NameFamily = qcheck.NameFamily,
                CodeNational = qcheck.CodeNational,
                Post = qcheck.Post,
                Image = qcheck.Image,
                city = qcheck.city,
                State=qcheck.State,
                Address = qcheck.Address,
                };
                return View (VmUs);

            } else {
                return View ();

            }

        }
        [HttpPost]
        public async Task<IActionResult> Update(Vm_User VmUser)
        {

            var qcheck = db.Tbl_Factors.Where(a => a.Id_Order == VmUser.Id && a.Pay == null).ToList();

            if (qcheck != null)
            {

                foreach (var item in qcheck)
                {
                    var q = db.Tbl_Factors.Where(a => a.Id == item.Id && a.Pay == null).SingleOrDefault();



                    q.NameBuy = VmUser.NameFamily;

                    q.State = VmUser.State;
                    q.City = VmUser.city;

                    q.FirstAddress = VmUser.Address;
                    q.Post = VmUser.Post;

                    db.Tbl_Factors.Update(q);
                    db.SaveChanges();

                }




            }
             var qcheck1 = db.Tbl_Users.Where (a => a.Id.ToString () == User.Identity.GetId ()).SingleOrDefault ();
              if (qcheck1 != null)
              {

              
                    
                    qcheck1.State = VmUser.State;
                    qcheck1.city = VmUser.city;
                    qcheck1.Post = VmUser.Post;
                    db.Tbl_Users.Update(qcheck1);
                    db.SaveChanges();
                }






            msg = " بروزرسانی با موفقیت انجام شد  ";

            return RedirectToAction("card2","cart");
        }
    
    }
}