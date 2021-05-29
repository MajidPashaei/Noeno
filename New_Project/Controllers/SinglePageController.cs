using System.Reflection.Metadata;
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
using ViewModel.Entities;
using ViewModel.AdminViewModel.Kala;
using New_Project.Models;
using Extensions;
using ViewModel.Entities.User;



namespace New_Project.Controllers {
    public class SinglePageController : Controller {
        public static string massage;
        private readonly Context_db db;
        private readonly IWebHostEnvironment env;

        public SinglePageController (Context_db _db, IWebHostEnvironment _env) {
            db = _db;
            env = _env;
        }

         public IActionResult index (int id) {

            var t=db.tbl_Advertisings.Where(a=>a.Id == id ).SingleOrDefault ();
            var u =db.Tbl_Users.Where (a => a.Id.ToString() == t.Id_creator).SingleOrDefault();
            ViewBag.UImage=u;
            ViewBag.img1=t.Image1;
            ViewBag.img2=t.Image2;
            ViewBag.img3=t.Image3;
            ViewBag.img4=t.Image3;
            var CK=db.tbl_category.Where(a=>a.Id.ToString() == t.Category).SingleOrDefault();
            var ChildCat=CK.NameCat;
            var C=db.tbl_category.Where(a=>a.Id == CK.FatherIdCat).SingleOrDefault();
            var Cat=C.NameCat;
            var FC=db.tbl_category.Where(a=>a.Id == C.FatherIdCat).SingleOrDefault();
            var FatherCat=CK.Language;
            var td=DateTime.Today-t.Time;
            var vc =td.Days;
            ViewBag.Number=db.tbl_Advertisings.Where(a =>a.Id==id).SingleOrDefault().Number;
            List<Vm_Detail>  sd = new  List<Vm_Detail> ();

                    Vm_Detail q = new Vm_Detail () {
                                Id=t.Id,
                                Id_creator=Convert.ToString(u.Random_Link),
                                Image=t.Image,
                                Title_Pro=t.Title_Pro,
                                Discreption_Pro=t.Discreption_Pro,
                                Type_pro=t.Type_pro,
                                Type_Transaction=t.Type_Transaction,
                                Main_Price=t.Main_Price,
                                Discount_Price=t.Discount_Price,
                                Time =vc.ToString(),
                                NameCrator=u.NameFamily,
                                PhoneCreator=u.Phone,
                                city=u.city,
                                Total=t.Number,
                                Special=t.Special,
                                FatherCat=FatherCat,
                                Cat=Cat,
                                ChildCat=ChildCat,
                                

                        };
                        sd.Add(q);
                
                ViewBag.Details = sd;
            return View ();
        }

        
        public IActionResult AddFavorite(int id)
        {
            var s=db.Tbl_MyFavorites.Where(a=>a.IdKala==id && a.IdUser.ToString()==User.Identity.GetId()).FirstOrDefault();
            if (s != null)
            {
               return RedirectToAction("index", new{id=id}); 
            }
                    Tbl_MyFavorite Ad = new Tbl_MyFavorite ()
                {
                    IdKala=id,
                    IdUser=Convert.ToInt32(User.Identity.GetId()),
                
                };

                db.Tbl_MyFavorites.Add (Ad);
                db.SaveChanges ();
                return RedirectToAction("index", new{id=id});
        }
        
     
        

    }
}