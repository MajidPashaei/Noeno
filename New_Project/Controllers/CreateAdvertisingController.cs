using System.Net.Mime;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Entities;
using DataLayer.Entities.User;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using New_Project.Models;
using ViewModel.Entities.User;
using Microsoft.AspNetCore.Http;
using System.IO;
using DataLayer.AdminEntities.Product;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace New_Project.Controllers {
        // [Authorize]
    
    
     
    public class CreateAdvertisingController : Controller {
        public static string massage, NewFileName,NewFileName2, NewFileName1,NewFileName3;

        private readonly Context_db db;
        private readonly IWebHostEnvironment env;

        public CreateAdvertisingController (Context_db _db, IWebHostEnvironment _env) {
            db = _db;
            env = _env;
        }

        public IActionResult index () {
            if (massage != null) {
                ViewBag.msg = massage;
                massage = null;
            }
            return View ();
        }
        public IActionResult list () {
            return View ();
        }
         public async Task<IActionResult> Update(Vm_Advertising Vm_Advert)
        {
             var A=db.tbl_category.Where (a => a.Id.ToString() == Vm_Advert.Category).SingleOrDefault();
            var s=db.tbl_Advertisings.Where(a=>a.Id == Vm_Advert.Id).SingleOrDefault();
                if (Vm_Advert.Img != null)
                {
                    string FileExtension1 = Path.GetExtension (Vm_Advert.Img.FileName);
                    NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension1);
                    var path = $"{env.WebRootPath}\\fileupload\\{NewFileName}";
                    using (var stream = new FileStream (path, FileMode.Create)) {
                        await Vm_Advert.Img.CopyToAsync (stream);
                    }
                }
                if (Vm_Advert.Img1 != null)
                {
                    string FileExtension2 = Path.GetExtension (Vm_Advert.Img1.FileName);
                    NewFileName2 = String.Concat (Guid.NewGuid ().ToString (), FileExtension2);
                    var path1 = $"{env.WebRootPath}\\fileupload\\{NewFileName2}";
                    using (var stream = new FileStream (path1, FileMode.Create)) {
                        await Vm_Advert.Img1.CopyToAsync (stream);
                    }
                }
                if (Vm_Advert.Img2 != null)
                {
                        string FileExtension3 = Path.GetExtension (Vm_Advert.Img2.FileName);
                        NewFileName3= String.Concat (Guid.NewGuid ().ToString (), FileExtension3);
                        var path2 = $"{env.WebRootPath}\\fileupload\\{NewFileName3}";
                        using (var stream = new FileStream (path2, FileMode.Create)) {
                            await Vm_Advert.Img2.CopyToAsync (stream);
                        }
                }
                if (Vm_Advert.Img3 != null)
                {
                        string FileExtension4 = Path.GetExtension (Vm_Advert.Img3.FileName);
                        NewFileName1= String.Concat (Guid.NewGuid ().ToString (), FileExtension4);
                        var path3 = $"{env.WebRootPath}\\fileupload\\{NewFileName1}";
                        using (var stream = new FileStream (path3, FileMode.Create)) {
                            await Vm_Advert.Img3.CopyToAsync (stream);
                        }
                }
              
            
           
        
            

                 
                s.Father=A.Language;
                s.FatherIdCat=A.FatherIdCat.ToString();
                s.Category = Vm_Advert.Category;
                s.Title_Pro = Vm_Advert.Title_Pro;
                s.Discreption_Pro = Vm_Advert.Discreption_Pro;
                s.Type_pro = Vm_Advert.Type_pro;
                s.Type_Transaction = Vm_Advert.Type_Transaction;
                s.Main_Price_Auction = Vm_Advert.Main_Price_Auction;
                s.Auction_Time = Vm_Advert.Auction_Time;
                s.Auction_Start_Time = Vm_Advert.Auction_Start_Time;
                s.Main_Price = Vm_Advert.Main_Price;
                s.Discount_Price = Vm_Advert.Discount_Price;
                s.Online_Exchange = Vm_Advert.Online_Exchange;
                s.Take_Discount = Vm_Advert.Take_Discount;
                if (NewFileName != null)
                {
                    s.Image = NewFileName;
                }
                if (NewFileName1 != null)
                {
                    s.Image1 = NewFileName1;
                }
                if (NewFileName2 != null)
                {
                    s.Image2 = NewFileName2;
                }
                if (NewFileName3 != null)
                {
                    s.Image3 = NewFileName3;
                }
                s.Id_creator = User.Identity.GetId();
                s.State="در انتظار تایید";
                s.Description= null ;
                s.Time = DateTime.Today;
                s.Special="جدید نو نو";
                s.Number=Vm_Advert.Number;
                db.tbl_Advertisings.Update (s);
                db.SaveChanges ();
                return View("index");
        }
        
        

        public async Task<IActionResult> AddAdvertising (Vm_Advertising Vm_Advert) {
            var Tb_Advert = db.tbl_Advertisings.Where (a => a.Id == Vm_Advert.Id).SingleOrDefault ();
            var A=db.tbl_category.Where (a => a.Id.ToString() == Vm_Advert.Category).SingleOrDefault();

            /////////////////////////////////////////////////////////////////////////////////upload file
            string FileExtension1 = Path.GetExtension (Vm_Advert.Img.FileName);
            NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension1);
            var path = $"{env.WebRootPath}\\fileupload\\{NewFileName}";
            using (var stream = new FileStream (path, FileMode.Create)) {
                await Vm_Advert.Img.CopyToAsync (stream);
            }
            string FileExtension2 = Path.GetExtension (Vm_Advert.Img1.FileName);
            NewFileName2 = String.Concat (Guid.NewGuid ().ToString (), FileExtension2);
            var path1 = $"{env.WebRootPath}\\fileupload\\{NewFileName2}";
            using (var stream = new FileStream (path1, FileMode.Create)) {
                await Vm_Advert.Img1.CopyToAsync (stream);
            }
            string FileExtension3 = Path.GetExtension (Vm_Advert.Img2.FileName);
            NewFileName3= String.Concat (Guid.NewGuid ().ToString (), FileExtension3);
            var path2 = $"{env.WebRootPath}\\fileupload\\{NewFileName3}";
            using (var stream = new FileStream (path2, FileMode.Create)) {
                await Vm_Advert.Img2.CopyToAsync (stream);
            }
            string FileExtension4 = Path.GetExtension (Vm_Advert.Img3.FileName);
            NewFileName1= String.Concat (Guid.NewGuid ().ToString (), FileExtension4);
            var path3 = $"{env.WebRootPath}\\fileupload\\{NewFileName1}";
            using (var stream = new FileStream (path3, FileMode.Create)) {
                await Vm_Advert.Img3.CopyToAsync (stream);
            }
            
            //////////////////////////end upload file 

            Tbl_Advertising Advert = new Tbl_Advertising () {
                Father=A.Language,
                FatherIdCat=A.FatherIdCat.ToString(),
                Category = Vm_Advert.Category,
                Title_Pro = Vm_Advert.Title_Pro,
                Discreption_Pro = Vm_Advert.Discreption_Pro,
                Type_pro = Vm_Advert.Type_pro,
                Type_Transaction = Vm_Advert.Type_Transaction,
                /////////////////////////////////////////////////////////
                Main_Price_Auction = Vm_Advert.Main_Price_Auction,
                Auction_Time = Vm_Advert.Auction_Time,
                Auction_Start_Time = Vm_Advert.Auction_Start_Time,
                ////////////////////////////////////////////////////////
                Main_Price = Vm_Advert.Main_Price,
                Discount_Price = Vm_Advert.Discount_Price,
                Online_Exchange = Vm_Advert.Online_Exchange,
                Take_Discount = Vm_Advert.Take_Discount,
                Image = NewFileName,
                Image1 = NewFileName1,
                Image2 = NewFileName2,
                Image3 = NewFileName3,
                Id_creator = User.Identity.GetId(),
                State="در انتظار تایید",
                Description= null ,
                Time = DateTime.Today,
                Special="جدید نو نو",
                Number=Vm_Advert.Number,
            };

            db.tbl_Advertisings.Add (Advert);
            db.SaveChanges ();
            massage = ":کالای شما با موفقیت ثبت شد";

            return RedirectToAction ("Index", "CreateAdvertising");
        }

    }
}