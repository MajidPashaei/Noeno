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
using ViewModel.AdminViewModel.Comment;
using Extensions;

namespace New_Project.Areas.Admin.Controllers
{
  
    public class  CommentController: BaseController
    {
        public CommentController(Context_db _db,IWebHostEnvironment  env) :base(_db,env)
        {
        }
       
        public IActionResult Index()
        {
            if (suc != null)
            {
                ViewBag.suc=suc;
                suc=null;
            }
            /////////////////////////////////////////////////////////////////////////////////////////comment
            var qcomit=db.Tbl_Comments.Where(a=>a.State==false).ToList();
            
            List<Vm_Comment> com=new  List<Vm_Comment>();
            foreach (var item in qcomit)
            {
                var name=db.Tbl_User.Where(a=>a.Id==Convert.ToInt32(item.User_Id) ).SingleOrDefault();
                Vm_Comment comm=new Vm_Comment()
            {
                Id=item.Id,
                username=name.UserNameUs,
                dateshamsi=item.DateComment.ToPersianDateString(),
                Comment=item.Comment,
                image=name.ProfileImageUs,
                Language=item.Language,
                product_id=item.product_id,
                blog_id=item.blog_id

            };
            com.Add(comm);
            }
            ViewBag.comments=com.OrderByDescending(a=>a.Id).ToList();
            /////////////////////////////////////////////////////////////////////////////////////////////////////// 
            return View();
        }
        public IActionResult Acceptede()
        {
            if (suc != null)
            {
                ViewBag.suc=suc;
                suc=null;
            }
            /////////////////////////////////////////////////////////////////////////////////////////comment
            var qcomit=db.Tbl_Comments.Where(a=>a.State==true).ToList();
            
            List<Vm_Comment> com=new  List<Vm_Comment>();
            foreach (var item in qcomit)
            {
                var name=db.Tbl_User.Where(a=>a.Id==Convert.ToInt32(item.User_Id) ).SingleOrDefault();
                Vm_Comment comm=new Vm_Comment()
            {
                Id=item.Id,
                username=name.UserNameUs,
                dateshamsi=item.DateComment.ToPersianDateString(),
                Comment=item.Comment,
                image=name.ProfileImageUs,
                Language=item.Language,
                product_id=item.product_id,
                blog_id=item.blog_id

            };
            com.Add(comm);
            }
            ViewBag.comments=com.OrderByDescending(a=>a.Id).ToList();
            /////////////////////////////////////////////////////////////////////////////////////////////////////// 
            return View();
        }
          public IActionResult Notaccepted()
        {
            return View();
        }

            public IActionResult del(int id)
        {
            var qcomment=db.Tbl_Comments.Where(a=>a.Id==id).SingleOrDefault();
            db.Tbl_Comments.Remove(qcomment);
            db.SaveChanges();
            suc="?????????? ???? ???????????? ?????? ????";

            return RedirectToAction("index");
        }


            public IActionResult verify(int id)
        {
            var qcomment=db.Tbl_Comments.Where(a=>a.Id==id).SingleOrDefault();
            qcomment.State=true;
            db.Tbl_Comments.Update(qcomment);
            db.SaveChanges();
            suc="?????????? ???? ???????????? ?????????? ????";

            return RedirectToAction("index");
        }


    public IActionResult delaccept(int id)
        {
            var qcomment=db.Tbl_Comments.Where(a=>a.Id==id).SingleOrDefault();
            db.Tbl_Comments.Remove(qcomment);
            db.SaveChanges();
            suc="?????????? ???? ???????????? ?????? ????";

            return RedirectToAction("Acceptede");
        }


        
      
        
      
        
        

    }
}