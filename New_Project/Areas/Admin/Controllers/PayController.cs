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


namespace New_Project.Areas.Admin.Controllers {
    [Area ("Admin")]
    public class PayController : BaseController {
        public PayController (Context_db _db, IWebHostEnvironment env) : base (_db, env) { }
        public static int IdP;
        public IActionResult Index () {
            return View();
        }
        public IActionResult Ok () {
           
            return View();
        }
         public IActionResult No () {
           
            return View();
        }

    }
}


     