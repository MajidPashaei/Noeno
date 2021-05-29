using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using New_Project.Models;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;
using  ViewModel.Entities.User;

namespace New_Project.Areas.Admin.Controllers
{
    
    public class  UsersController: BaseController
    {
        
            public UsersController(Context_db _db,IWebHostEnvironment  env) :base(_db,env)
        {
        }
        public IActionResult Index()
        {
            if (err != null)
            {
                ViewBag.er = err;
                err = null;
            }
            var u= db.Tbl_Users.OrderByDescending(a=>a.Id).ToList();
             List<Vm_User>  sd = new  List<Vm_User> ();
             foreach (var item in u)
             {
                var td=DateTime.Today-item.TimeLogIn;
                    var vc =td.Days;
                    Vm_User q = new Vm_User () {
                        Id=item.Id,
                        Phone=item.Phone,
                        NameFamily=item.NameFamily,
                        city=item.city,
                        Image=item.Image,
                        TimeLogIn=vc.ToString(),
                        State=item.State,
                        RPass=item.Random_Link.ToString(),

                        };
                        sd.Add(q); 
             }   
                ViewBag.list = sd;
            

            return View();
        }
         public IActionResult del(int s)
        {
            var qorder = db.Tbl_Users.Where (a => a.Id==s).SingleOrDefault ();
            db.Tbl_Users.Remove(qorder);
            db.SaveChanges();
            err = "حذف با موفقیت انجام شد";
            return RedirectToAction("index");
            
        }

        public IActionResult detail (int s) {
            var u =db.Tbl_Users.Where (a => a.Id == s).SingleOrDefault();
            var t=db.tbl_Advertisings.Where(a=>a.Id_creator == u.Id.ToString() ).ToList ();
            ViewBag.Kala=t;
            return View ();
        }

    }
}