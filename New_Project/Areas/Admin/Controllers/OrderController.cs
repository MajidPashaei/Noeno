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
using ViewModel.AdminViewModel.Order;
using System.IO;

namespace New_Project.Areas.Admin.Controllers {
    [Area ("Admin")]
    public class OrderController : BaseController {
        public OrderController (Context_db _db, IWebHostEnvironment env) : base (_db, env) { }
        public static int IdP;
        public static string NewFileName;

        
        public IActionResult zero()
        {
             ViewBag.list= db.Tbl_Factors.Where(a =>a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        public IActionResult changes(Vm_Factor vf)
        {
            var s= db.Tbl_Factors.Where(a => a.Id == vf.Id).SingleOrDefault();
            s.StatusM=vf.StatusM;
                if(vf.StatusM=="در انتظار تایید فروشنده"){s.StatusA="R";}
                if(vf.StatusM=="در انتظار ارسال فروشنده"){s.StatusA="R";}
                if(vf.StatusM=="عدم تایید فروشنده"){s.StatusA="No";}
                if(vf.StatusM=="ارسال شده به خریدار"){s.StatusA="R";}
                if(vf.StatusM=="ارسال شده به نوِنو"){s.StatusA="R";}
                if(vf.StatusM=="تحویل داده شده به نوِنو"){s.StatusA="R";}
                if(vf.StatusM=="لغو شده توسط مدیر"){s.StatusA="No";}
                if(vf.StatusM=="دریافت شده توسط نوِنو"){s.StatusA="R";}
                if(vf.StatusM=="تایید شده سیستم بازرسی"){s.StatusA="R";}
                if(vf.StatusM=="عدم تایید سیستم بازرسی"){s.StatusA="NoB";}
                if(vf.StatusM=="ارسال نوِنو به خریدار"){s.StatusA="R";}
                if(vf.StatusM=="دریافت توسط خریدار"){s.StatusA="Ok";}
                if(vf.StatusM=="مرجوع شده"){s.StatusA="No";}
                if(vf.StatusM=="قصد مرجوعی خریدار"){s.StatusA="R";}
                if(vf.StatusM=="عدم تایید قصد مرجوعی"){s.StatusA="Ok";}
                if(vf.StatusM=="در انتظار ارسال خریدار"){s.StatusA="R";}
                if(vf.StatusM=="مرجوع ارسال شده"){s.StatusA="R";}
            db.Tbl_Factors.Update(s);
            db.SaveChanges();
           
            return RedirectToAction("zero");
        }
        
        public IActionResult One()
        {
             ViewBag.list= db.Tbl_Factors.Where(a => a.StatusM=="در انتظار تایید فروشنده" && a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        public IActionResult Two()
        {
             ViewBag.list= db.Tbl_Factors.Where(a => a.StatusM=="در انتظار ارسال فروشنده" && a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        public IActionResult Three()
        {
            ViewBag.list= db.Tbl_Factors.Where(a => a.StatusM=="عدم تایید فروشنده" && a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        public IActionResult Four()
        {
             ViewBag.list= db.Tbl_Factors.Where(a => a.StatusM=="ارسال شده به خریدار" && a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        public IActionResult Five()
        {
             ViewBag.list= db.Tbl_Factors.Where(a => a.StatusM=="ارسال شده به نوِنو" && a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        public IActionResult tahvilPost(int c)
        {
            var s= db.Tbl_Factors.Where(a => a.Id == c).SingleOrDefault();
            s.StatusM="دریافت شده توسط نوِنو";
            db.Tbl_Factors.Update(s);
            db.SaveChanges();
            return RedirectToAction("Five");
        }
        public IActionResult Six()
        {
             ViewBag.list= db.Tbl_Factors.Where(a => a.StatusM=="تحویل داده شده به نوِنو" && a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        public IActionResult tahvil(int c)
        {
            var s= db.Tbl_Factors.Where(a => a.Id == c).SingleOrDefault();
            s.StatusM="دریافت شده توسط نوِنو";
            db.Tbl_Factors.Update(s);
            db.SaveChanges();
            return RedirectToAction("Six");
        }
        public IActionResult Seven()
        {
             ViewBag.list= db.Tbl_Factors.Where(a => a.StatusM=="لغو شده توسط مدیر" && a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        public IActionResult Eight()
        {
             ViewBag.list= db.Tbl_Factors.Where(a => a.StatusM=="دریافت شده توسط نوِنو" && a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        public IActionResult OkBazrasi(int c)
        {
            var s= db.Tbl_Factors.Where(a => a.Id == c).SingleOrDefault();
            s.StatusM="تایید شده سیستم بازرسی";
            db.Tbl_Factors.Update(s);
            db.SaveChanges();
            return RedirectToAction("Eight");
        }
        public IActionResult NoBazrasi(int c)
        {
            IdP=c;
            return View("WyNo");
        }
        public async Task<IActionResult> WyNo(Vm_Factor Vf)
        {

            var s= db.Tbl_Factors.Where(a => a.Id == IdP).SingleOrDefault();


            string FileExtension = Path.GetExtension (Vf.ImageNoB.FileName);
            NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension);
            var path = $"{_env.WebRootPath}\\fileupload\\{NewFileName}";
            using (var stream = new FileStream (path, FileMode.Create)) {

                await Vf.ImageNoB.CopyToAsync (stream);

            }



            s.Why_Return_Admin_Bazrasi=Vf.Why_Return_Admin_Bazrasi;
            s.ImgNoB=NewFileName;

            s.StatusM="عدم تایید سیستم بازرسی";
            s.StatusA="NoB";
            db.Tbl_Factors.Update(s);
            db.SaveChanges();
            return RedirectToAction("Eight");
        }
        public IActionResult WyNoShow(int c)
        {
            ViewBag.list= db.Tbl_Factors.Where(a =>a.Id==c).ToList();
            return View();
        }
        public IActionResult Nine()
        {
             ViewBag.list= db.Tbl_Factors.Where(a => a.StatusM=="تایید شده سیستم بازرسی" && a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        public IActionResult SendAdmin(Vm_Factor vf)
        {
            
            var s= db.Tbl_Factors.Where(a => a.Id == vf.Id).SingleOrDefault();
            s.Send_Admin_Code=vf.Send_Admin_Code;
            s.StatusM="ارسال نوِنو به خریدار";
            db.Tbl_Factors.Update(s);
            db.SaveChanges();
            return RedirectToAction("Nine");
        }
        public IActionResult Ten()
        {
             ViewBag.list= db.Tbl_Factors.Where(a => a.StatusM=="عدم تایید سیستم بازرسی" && a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        public IActionResult OneTen()
        {
             ViewBag.list= db.Tbl_Factors.Where(a => a.StatusM=="ارسال نوِنو به خریدار" && a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        public IActionResult TwoTen()
        {
             ViewBag.list= db.Tbl_Factors.Where(a => a.StatusM=="دریافت توسط خریدار" && a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        public IActionResult ThreeTen()
        {
            ViewBag.list= db.Tbl_Factors.Where(a => a.StatusM=="مرجوع شده" && a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        public IActionResult FourTen()
        {
            ViewBag.list= db.Tbl_Factors.Where(a => a.StatusM=="قصد مرجوعی خریدار" && a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            
            return View();
        }
        public IActionResult FiveTen()
        {
            ViewBag.list= db.Tbl_Factors.Where(a => a.StatusM=="عدم تایید قصد مرجوعی" && a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        public IActionResult TahvilNO(int c)
        {
            ViewBag.list= db.Tbl_Factors.Where(a => a.Id == c).ToList();
            return View();
        }
        public IActionResult TahvilNoOK(int c)
        {
            var s= db.Tbl_Factors.Where(a => a.Id == c).SingleOrDefault();
            s.StatusM="در انتظار ارسال خریدار";
            db.Tbl_Factors.Update(s);
            db.SaveChanges();
            return RedirectToAction("FourTen");
        }public IActionResult TahvilNoNo(int c)
        {
            var s= db.Tbl_Factors.Where(a => a.Id == c).SingleOrDefault();
            s.StatusM="عدم تایید قصد مرجوعی";
            s.StatusA="Ok";
            db.Tbl_Factors.Update(s);
            db.SaveChanges();
            return RedirectToAction("FourTen");
        }
        public IActionResult SixTen()
        {
            ViewBag.list= db.Tbl_Factors.Where(a => a.StatusM=="در انتظار ارسال خریدار" && a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        public IActionResult SevenTen()
        {
            ViewBag.list= db.Tbl_Factors.Where(a => a.StatusM=="مرجوع ارسال شده" && a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        public IActionResult All()
        {
            ViewBag.list= db.Tbl_Factors.Where(a =>a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            return View();
        }
    }
}