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
using ViewModel.AdminViewModel.Order;
using DataLayer.AdminEntities.Order;
using ViewModel.AdminViewModel.Comment;
using DataLayer.AdminEntities.Comment;

namespace New_Project.Controllers
{
    public class MasegeController : BaseController
    {
        public static string massage;
        public MasegeController(Context_db _db, IWebHostEnvironment env) : base(_db, env)
        {

        }
        

        public IActionResult Index(int id,string? C)
        {
            
            Vm_Advertising A=new Vm_Advertising()
            {
               Id=id
                

            };


            return View(A);
        }

                public IActionResult Add(Vm_Advertising sms)
        {
            var masege=db.tbl_Advertisings.Where(a=>a.Id==sms.Id).SingleOrDefault();
            Tb_Comment A=new Tb_Comment()
            {
                Send_Id=User.Identity.GetId(),
                Resever_Id=masege.Id_creator,
                product_id=sms.Id,
                Comment=sms.Discreption_Pro,
                DateComment=DateTime.Now,
                Language=sms.Title_Pro
                

            };
            db.Tbl_Comments.Add(A);
            db.SaveChanges();


            return RedirectToAction("Index");
        }
          public IActionResult Resever(int id)
        {
            
           ViewBag.sms=db.Tbl_Comments.Where(a =>a.Resever_Id==User.Identity.GetId()).OrderByDescending(a=>a.Id).ToList();



            return View();
        }
         public IActionResult dell(int id)
        {
            
          var A=db.Tbl_Comments.Where(a =>a.Id==id).SingleOrDefault();
          db.Tbl_Comments.Remove(A);
          db.SaveChanges();
           


            return RedirectToAction("Resever");
        }
           public IActionResult Read(int id)
        {
            
        var A=db.Tbl_Comments.Where(a =>a.Id==id).SingleOrDefault();
            ViewBag.id=Convert.ToInt32(A.Send_Id);
          ViewBag.Language=db.Tbl_Comments.Where(a =>a.Id==id).SingleOrDefault().Language;
          ViewBag.Comment=db.Tbl_Comments.Where(a =>a.Id==id).SingleOrDefault().Comment;
           ViewBag.DateTime=db.Tbl_Comments.Where(a =>a.Id==id).SingleOrDefault().DateComment;
           
          var A1=db.Tbl_Users.Where(a =>a.Id.ToString()==A.Send_Id).SingleOrDefault();
          ViewBag.name=A1.NameFamily;
          ViewBag.Phone=A1.Phone;
          A.State=true;
          db.Tbl_Comments.Update(A);
          db.SaveChanges();
            return View();
        }


    }
}