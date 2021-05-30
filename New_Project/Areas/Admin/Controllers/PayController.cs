using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using Extensions;
using New_Project.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModel.AdminViewModel.Kala;
using DataLayer.Context;
using DataLayer.Entities;
using ViewModel;
using ViewModel.AdminViewModel;
using ViewModels.AdminViewModel.Wallet;

namespace New_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PayController : BaseController
    {
        public PayController(Context_db _db, IWebHostEnvironment env) : base(_db, env) { }
        public static int IdP;
        public IActionResult Index(int id)
        {
          

              var R1 = db.tbl_Pays.Where(a => a.Id == id).SingleOrDefault();
            if (R1 != null)
            {
                R1.StatusP = "No";
                db.tbl_Pays.Update(R1);
                db.SaveChanges();
            }
              ViewBag.pay = db.tbl_Pays.Where(a => a.StatusP == "T" && a.Id_Factro == 0).ToList();
            return View();
        }
        public IActionResult Ok(int id )
        {
            var R = db.tbl_Pays.Where(a => a.Id == id).SingleOrDefault();
            if (R != null)
            {
                R.StatusP = "R";
                db.tbl_Pays.Update(R);
                db.SaveChanges();
            }
           

            ViewBag.R = db.tbl_Pays.Where(a => a.StatusP == "R" && a.Id_Factro == 0).ToList();

            return View();
        }
        public IActionResult No(int id)
        {
            var R = db.tbl_Pays.Where(a => a.Id == id).SingleOrDefault();
            if (R != null)
            {
                R.StatusP = "Ok";
                db.tbl_Pays.Update(R);
                db.SaveChanges();
            }
            ViewBag.Ok = db.tbl_Pays.Where(a => a.StatusP == "OK" && a.Id_Factro == 0).ToList();
            return View();
        }

    }
}


