using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DataLayer.AdminEntities.Order;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using New_Project.Models;
using ViewModel.AdminViewModel.Order;

namespace New_Project.Areas.Admin.Controllers {

    public class DetailsController : BaseController {
        public DetailsController (Context_db _db, IWebHostEnvironment env) : base (_db, env) { }
        public IActionResult Index () {

            return View ();
        }
        public IActionResult awards () {

            return View ();
        }

        public IActionResult purchases (int id) {

        ViewBag.list=db.Tbl_Factors.Where(a=>a.Id_Order==id).ToList();

            return View ();
        }

        public IActionResult sales () {

            return View ();
        }

        public IActionResult Transactions () {

            return View ();
        }

    }
}