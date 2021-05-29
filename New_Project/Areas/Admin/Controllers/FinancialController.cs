using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using New_Project.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace New_Project.Areas.Admin.Controllers {
       public class FinancialController : BaseController {
           public FinancialController(Context_db _db,IWebHostEnvironment  env) :base(_db,env)
        {
        }
        public IActionResult Index () {
            return View ();
        }
        public IActionResult list () {
            return View ();
        }

    }
}