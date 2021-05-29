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
    public class KalaController : BaseController {
        public KalaController (Context_db _db, IWebHostEnvironment env) : base (_db, env) { }
        public static int IdP;
        public IActionResult Index () {
            if (eror != null)
            {
                ViewBag.er=eror;
                eror=null;
            }


            List<Vm_Kala> or = new List<Vm_Kala> ();
            var qKala = db.tbl_Advertisings.Where (a => a.State =="در انتظار تایید" ).OrderByDescending (a => a.Id).ToList ();
           
            if (qKala != null) {
                foreach (var item in qKala) { 
                    var UserNamee =db.Tbl_Users.Where (a => a.Id.ToString() == item.Id_creator).SingleOrDefault();
                    var Namee = UserNamee.NameFamily;
                    Vm_Kala q = new Vm_Kala () {

                        Product_Id =item.Id,
                        Title_Pro =item.Title_Pro,
                        Time =item.Time.ToPersianDateString (),
                        Image =item.Image,
                        Name =Namee,
                    };
                    or.Add (q);

                }
                ViewBag.listp = or;

            }
            
            return View();
        }
        public IActionResult Ok () {
            if (eror != null)
            {
                ViewBag.er=eror;
                eror=null;
            }

            List<Vm_Kala> or = new List<Vm_Kala> ();
            var qKala = db.tbl_Advertisings.Where (a => a.State =="تایید شده" ).OrderByDescending (a => a.Id).ToList ();
           
            if (qKala != null) {
                foreach (var item in qKala) { 
                    var UserNamee =db.Tbl_Users.Where (a => a.Id.ToString() == item.Id_creator).SingleOrDefault();
                    var Namee = UserNamee.NameFamily;
                    Vm_Kala q = new Vm_Kala () {

                        Product_Id =item.Id,
                        Title_Pro =item.Title_Pro,
                        Time =item.Time.ToPersianDateString (),
                        Image =item.Image,
                        Name =Namee,
                    };
                    or.Add (q);

                }
                ViewBag.listp = or;

            }
            return View();
        }
         public IActionResult No () {
            if (eror != null)
            {
                ViewBag.er=eror;
                eror=null;
            }

            List<Vm_Kala> or = new List<Vm_Kala> ();
            var qKala = db.tbl_Advertisings.Where (a => a.State =="عدم تایید" ).OrderByDescending (a => a.Id).ToList ();
           
            if (qKala != null) {
                foreach (var item in qKala) { 
                    var UserNamee =db.Tbl_Users.Where (a => a.Id.ToString() == item.Id_creator).SingleOrDefault();
                    var Namee = UserNamee.NameFamily;
                    Vm_Kala q = new Vm_Kala () {

                        Product_Id =item.Id,
                        Title_Pro =item.Title_Pro,
                        Time =item.Time.ToPersianDateString (),
                        Image =item.Image,
                        Name =Namee,
                    };
                    or.Add (q);

                }
                ViewBag.listp = or;

            }
            return View();
        }
        public IActionResult Detail (int b) {

            var t=db.tbl_Advertisings.Where(a=>a.Id == b ).SingleOrDefault ();
            var u =db.Tbl_Users.Where (a => a.Id.ToString() == t.Id_creator).SingleOrDefault();
            ViewBag.FImage=db.tb_GalleryProducts.Where(a=>a.IdProduct == b).ToList();
            var CK=db.tbl_category.Where(a=>a.Id.ToString() == t.Category).SingleOrDefault();
            var ChildCat=CK.NameCat;
            var C=db.tbl_category.Where(a=>a.Id == CK.FatherIdCat).SingleOrDefault();
            var Cat=C.NameCat;
            var FC=db.tbl_category.Where(a=>a.Id == C.FatherIdCat).SingleOrDefault();
            var FatherCat=CK.Language;

            
            List<Vm_Detail>  sd = new  List<Vm_Detail> ();

                    Vm_Detail q = new Vm_Detail () {
                                Id=t.Id,
                                Id_creator=Convert.ToString(t.Id),
                                Image = t.Image,
                                Image1=t.Image1,
                                Image2=t.Image2,
                                Image3=t.Image3,
                                Title_Pro=t.Title_Pro,
                                Discreption_Pro=t.Discreption_Pro,
                                Type_pro=t.Type_pro,
                                Type_Transaction=t.Type_Transaction,
                                Main_Price=t.Main_Price,
                                Discount_Price=t.Discount_Price,
                                Time =t.Time.ToPersianDateString (),
                                NameCrator=u.NameFamily,
                                PhoneCreator=u.Phone,
                                Total=t.Number,
                                Special=t.Special,
                                FatherCat=FatherCat,
                                Cat=Cat,
                                ChildCat=ChildCat,
                                

                        };
                        sd.Add(q);
                
                ViewBag.listp = sd;

            return View();

            }
        public IActionResult DetailOk (int b) {

           var t=db.tbl_Advertisings.Where(a=>a.Id == b ).SingleOrDefault ();
            var u =db.Tbl_Users.Where (a => a.Id.ToString() == t.Id_creator).SingleOrDefault();
            ViewBag.FImage=db.tb_GalleryProducts.Where(a=>a.IdProduct == b).ToList();
            var CK=db.tbl_category.Where(a=>a.Id.ToString() == t.Category).SingleOrDefault();
            var ChildCat=CK.NameCat;
            var C=db.tbl_category.Where(a=>a.Id == CK.FatherIdCat).SingleOrDefault();
            var Cat=C.NameCat;
            var FC=db.tbl_category.Where(a=>a.Id == C.FatherIdCat).SingleOrDefault();
            var FatherCat=CK.Language;
            List<Vm_Detail>  sd = new  List<Vm_Detail> ();

                    Vm_Detail q = new Vm_Detail () {
                                Id=t.Id,
                                Id_creator=Convert.ToString(t.Id),
                                Image = t.Image,
                                Image1=t.Image1,
                                Image2=t.Image2,
                                Image3=t.Image3,
                                Title_Pro=t.Title_Pro,
                                Discreption_Pro=t.Discreption_Pro,
                                Type_pro=t.Type_pro,
                                Type_Transaction=t.Type_Transaction,
                                Main_Price=t.Main_Price,
                                Discount_Price=t.Discount_Price,
                                Time =t.Time.ToPersianDateString (),
                                NameCrator=u.NameFamily,
                                PhoneCreator=u.Phone,
                                Total=t.Number,
                                Special=t.Special,
                                FatherCat=FatherCat,
                                Cat=Cat,
                                ChildCat=ChildCat,

                        };
                        sd.Add(q);
                
                ViewBag.listp = sd;

            return View();

            }
        public IActionResult DetailNO (int b) {

            var t=db.tbl_Advertisings.Where(a=>a.Id == b ).SingleOrDefault ();
            var u =db.Tbl_Users.Where (a => a.Id.ToString() == t.Id_creator).SingleOrDefault();
            ViewBag.FImage=db.tb_GalleryProducts.Where(a=>a.IdProduct == b).ToList();
            var CK=db.tbl_category.Where(a=>a.Id.ToString() == t.Category).SingleOrDefault();
            var ChildCat=CK.NameCat;
            var C=db.tbl_category.Where(a=>a.Id == CK.FatherIdCat).SingleOrDefault();
            var Cat=C.NameCat;
            var FC=db.tbl_category.Where(a=>a.Id == C.FatherIdCat).SingleOrDefault();
            var FatherCat=CK.Language;
            List<Vm_Detail>  sd = new  List<Vm_Detail> ();

                    Vm_Detail q = new Vm_Detail () {
                                Id=t.Id,
                                Id_creator=Convert.ToString(t.Id),
                                Image = t.Image,
                                Image1=t.Image1,
                                Image2=t.Image2,
                                Image3=t.Image3,
                                Title_Pro=t.Title_Pro,
                                Discreption_Pro=t.Discreption_Pro,
                                Type_pro=t.Type_pro,
                                Type_Transaction=t.Type_Transaction,
                                Main_Price=t.Main_Price,
                                Discount_Price=t.Discount_Price,
                                Time =t.Time.ToPersianDateString (),
                                NameCrator=u.NameFamily,
                                PhoneCreator=u.Phone,
                                Total=t.Number,
                                Special=t.Special,
                                FatherCat=FatherCat,
                                Cat=Cat,
                                ChildCat=ChildCat,

                        };
                        sd.Add(q);
                
                ViewBag.listp = sd;

            return View();

            }
        public IActionResult IdKala(int s)
                {
                    IdP=s;
                    return View("Return");
                }
        public IActionResult Return (Vm_Return Sr)
                {             
                 var SS= db.tbl_Advertisings.Where(a => a.Id == IdP ).SingleOrDefault ();
                    SS.TimeReturn = DateTime.Today;
                    SS.WhyReturn  =Sr.WhyReturn;
                    SS.Description  =Sr.Description;
                     db.tbl_Advertisings.Update(SS);
                     db.SaveChanges ();
                    return RedirectToAction("Reply");
                }
        public IActionResult ReturnShow (int b)
                {
                    ViewBag.q= db.tbl_Advertisings.Where(a => a.Id == b ).ToList ();
                      return View();
                }
        public IActionResult Reply()
        {
          var qorder = db.tbl_Advertisings.Where (a => a.Id==IdP).SingleOrDefault ();
          qorder.State="عدم تایید";
          db.tbl_Advertisings.Update(qorder);
          db.SaveChanges();
          eror="تغییر آگهی به حالت عدم تایید.";
          return RedirectToAction("index");
        }
        public IActionResult Special(Vm_Return Sd)
        {
          var qorde = db.tbl_Advertisings.Where (a => a.Id == Sd.iD).SingleOrDefault ();
          qorde.Special=Sd.Special;
          db.tbl_Advertisings.Update(qorde);
          db.SaveChanges();
          return RedirectToAction("Detail", new{b=Sd.iD});
        }
        public IActionResult SpecialOk(Vm_Return Sd)
        {
          var qorde = db.tbl_Advertisings.Where (a => a.Id == Sd.iD).SingleOrDefault ();
          qorde.Special=Sd.Special;
          db.tbl_Advertisings.Update(qorde);
          db.SaveChanges();
          return RedirectToAction("DetailOk", new{b=Sd.iD});
        }
        public IActionResult del(int s)
        {
          var qorder = db.tbl_Advertisings.Where (a => a.Id==s).SingleOrDefault ();
          db.tbl_Advertisings.Remove(qorder);
          db.SaveChanges();
          eror="آگهی با موفقیت حذف شد";
          return RedirectToAction("index");
        }
        public IActionResult delok(int s)
        {
          var qorder = db.tbl_Advertisings.Where (a => a.Id==s).SingleOrDefault ();
          db.tbl_Advertisings.Remove(qorder);
          db.SaveChanges();
          eror="آگهی با موفقیت حذف شد";
          return RedirectToAction("Ok");
        }
        public IActionResult delno(int s)
        {
          var qorder = db.tbl_Advertisings.Where (a => a.Id==s).SingleOrDefault ();
          db.tbl_Advertisings.Remove(qorder);
          db.SaveChanges();
          eror="آگهی با موفقیت حذف شد";
          return RedirectToAction("No");
        }
         public IActionResult Okk(int c)
        {
          
          var qorder = db.tbl_Advertisings.Where (a => a.Id==c).SingleOrDefault ();
          qorder.State="تایید شده";
          db.tbl_Advertisings.Update(qorder);
          db.SaveChanges();
          eror="تغییر آگهی به حالت تایید.";

          return RedirectToAction("index");
        }

    }
}


     