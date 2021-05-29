using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.AdminEntities.Baner;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using New_Project.Models;
using ViewModel.AdminViewModel.Baner;

namespace New_Project.Areas.Admin.Controllers {

    public class BanerController : BaseController {
        public BanerController (Context_db _db, IWebHostEnvironment env) : base (_db, env) { }
        public IActionResult Index () {
            if (err != null) {
                ViewBag.er = err;
                err = null;
            }

            if (err1 != null) {
                ViewBag.er1 = err1;
                err1 = null;
            }
            //////////////////////////////////////////////////selector
            var qlist = db.Tbl_Product.ToList ();
            ViewBag.list = new SelectList (qlist, "Id", "TitleProductPro");
            ///////////////////////////////////////////////////////////list
            return View ();
        }
        public IActionResult list () {
            if (err != null) {
                ViewBag.er = err;
                err = null;
            }

            ////////////////////////////////list
            var d = db.Tbl_Baner.ToList ();
            if (d != null) {
                List<Vm_Baner> s = new List<Vm_Baner> ();
                foreach (var item in d) {
                    var q = db.Tbl_Product.Where (a => a.Id == item.CategoryProductIdSlid).SingleOrDefault ();
                    if (q == null) {
                        prname = "محصولی ثبت نشده";
                    } else {
                        prname = q.TitleProductPro;
                    }
                    Vm_Baner f = new Vm_Baner () {
                        Id = item.Id,
                        ImageMainSlid = item.ImageMainSlid,
                        link = item.link,
                        nameproduct = prname,
                        CategoryProductIdSlid = item.CategoryProductIdSlid
                    };
                    s.Add (f);

                }
                ViewBag.list = s.OrderByDescending (a => a.Id).ToList ();
            } else {
                ViewBag.list = null;
            }

            return View ();
        }

        public async Task<IActionResult> add (Vm_Baner ex) {
            ///////////////upload file
            var A = db.Tbl_Baner.Where (a => a.CategoryProductIdSlid == ex.CategoryProductIdSlid).SingleOrDefault ();

            string FileExtension1 = Path.GetExtension (ex.img.FileName);
            NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension1);
            var path = $"{_env.WebRootPath}\\fileupload\\{NewFileName}";
            using (var stream = new FileStream (path, FileMode.Create)) {

                await ex.img.CopyToAsync (stream);

            }
            //////////////////////////end upload file

            if (A == null) {

                Tb_Baner tb = new Tb_Baner () {

                ImageMainSlid = NewFileName,
                CategoryProductIdSlid = ex.CategoryProductIdSlid,
                link = ex.link

                };

                db.Tbl_Baner.Add (tb);
                db.SaveChanges ();
                err = "بنر  با موفقیت ثبت شد";
                return RedirectToAction ("index");

            }
            err1 = "این شماره بنر قبلا ثبت شده است ";
            return RedirectToAction ("index");

        }

        public IActionResult del (int id) {
            var qdel = db.Tbl_Baner.Where (add => add.Id == id).SingleOrDefault ();
            db.Tbl_Baner.Remove (qdel);
            db.SaveChanges ();
            err = "حذف رکورد مورد نظر با موفقیت انجام شد";
            return RedirectToAction ("list");
        }

    }
}