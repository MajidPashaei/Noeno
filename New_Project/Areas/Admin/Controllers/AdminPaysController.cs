using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using New_Project.Models;
using DataLayer.Context;
using ViewModel.AdminViewModel.SocialNetwork;
using DataLayer.AdminEntities.SocialNetwork;
using Microsoft.AspNetCore.Hosting;
using DataLayer.AdminEntities.AdminPay;
using ViewModel.AdminViewModel.AdminPay;

namespace New_Project.Areas.Admin.Controllers
{
   
    public class AdminPaysController : BaseController
    {
        public AdminPaysController(Context_db _db,IWebHostEnvironment  env) :base(_db,env)
        {
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////index logo

        public IActionResult Index()
        {
            

           return View();
        }
        public IActionResult AddPay(Vm_AdminPay VAP)
        {
            var s=db.Tbl_Users.Where(s=>s.Random_Link.ToString()== VAP.IdUser).SingleOrDefault().Id.ToString();
            AdminPay tb = new AdminPay () {
                IdUser=s,
                Price=VAP.Price,
                Detail=VAP.Detail,
                TypePay=VAP.TypePay,
                Time=DateTime.Today,
                };

                db.AdminPays.Add (tb);
                db.SaveChanges ();
            return RedirectToAction ("index");
        }
        



        public IActionResult list () {

                ViewBag.list=db.AdminPays.ToList ();

            return View ();

        }


    }
}