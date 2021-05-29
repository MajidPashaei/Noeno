using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using New_Project.Models;
using ViewModel.Entities;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using DataLayer.AdminEntities.Blog;
using DataLayer.Entities.User;
using ViewModel.Entities.User;

namespace New_Project.Controllers
{
    public class FootController : BaseController
    {
        public FootController(Context_db _db, IWebHostEnvironment env) : base(_db, env)
        {
        }
        public IActionResult Qavanin()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Help()
        {
            return View();
        }
        public IActionResult Faqs()
        {
            return View();
        }
        public IActionResult Tracking()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Inspection()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}