using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using New_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;

namespace New_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    // [Authorize]
    // [RolAuthorize]
    public class BaseController : Controller
    {
        public readonly Context_db db;
         public readonly IWebHostEnvironment  _env;
        public static string ln="fa",eror,suc,err = null, NewFileName,prname,NewFileName1,err1,NewFileName3;
        
        
        public BaseController( Context_db _db,IWebHostEnvironment  env)
        {
            
             db = _db;
             _env=env;

        }
       

    }
}