using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using New_Project.Models;
using DataLayer.Context;
using DataLayer.AdminEntities.Category;
using ViewModel.AdminViewModel.Category;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Hosting;

namespace New_Project.Areas.Admin.Controllers
{
      public class  CategoryController: BaseController
    {
       public CategoryController(Context_db _db,IWebHostEnvironment  env) :base(_db,env)
        {
        }
        public IActionResult Index()
        {
            if (err != null)
            {
                ViewBag.er=err;
                err=null;
            }
            //////////////////////////////////////////////////////////////////////////////////select list
             var qlist=db.tbl_category.Where(a =>a.Language=="کالای دیجیتال"&&a.FatherIdCat==-1).ToList();
           
             ViewBag.lselect= new SelectList(qlist, "Id", "NameCat");
           ////////////////////////////////////////////////////////////////////////////list view bag complete
           ///    //////////////////////////////////////////////////////////////////////////////////select list
             var qlist1=db.tbl_category.Where(a =>a.Language=="آرایشی و بهداشتی"&&a.FatherIdCat==-1).ToList();
           
             ViewBag.lselect1= new SelectList(qlist1, "Id", "NameCat");
           ////////////////////////////////////////////////////////////////////////////list view bag complete
           ///    //////////////////////////////////////////////////////////////////////////////////select list
             var qlist2=db.tbl_category.Where(a =>a.Language=="خودرو و ابزاراداری"&&a.FatherIdCat==-1).ToList();
           
             ViewBag.lselect2= new SelectList(qlist2, "Id", "NameCat");
           ////////////////////////////////////////////////////////////////////////////list view bag complete
           ///    //////////////////////////////////////////////////////////////////////////////////select list
             var qlist3=db.tbl_category.Where(a =>a.Language=="مدوپوشاک"&&a.FatherIdCat==-1).ToList();
           
             ViewBag.lselec3= new SelectList(qlist3, "Id", "NameCat");
           ////////////////////////////////////////////////////////////////////////////list view bag complete
           ///    //////////////////////////////////////////////////////////////////////////////////select list
             var qlist4=db.tbl_category.Where(a =>a.Language=="خانه و اشپزخانه"&&a.FatherIdCat==-1).ToList();
           
             ViewBag.lselect4= new SelectList(qlist4, "Id", "NameCat");
           ////////////////////////////////////////////////////////////////////////////list view bag complete
           ///    //////////////////////////////////////////////////////////////////////////////////select list
             var qlist5=db.tbl_category.Where(a =>a.Language=="لوزم و تحریرو هنر"&&a.FatherIdCat==-1).ToList();
           
             ViewBag.lselect5= new SelectList(qlist5, "Id", "NameCat");
           ////////////////////////////////////////////////////////////////////////////list view bag complete
           ///    //////////////////////////////////////////////////////////////////////////////////select list
             var qlist6=db.tbl_category.Where(a =>a.Language=="کودک و نوزاد"&&a.FatherIdCat==-1).ToList();
           
             ViewBag.lselect6= new SelectList(qlist6, "Id", "NameCat");
           ////////////////////////////////////////////////////////////////////////////list view bag complete
           ///    //////////////////////////////////////////////////////////////////////////////////select list
             var qlist7=db.tbl_category.Where(a =>a.Language=="ورزش و سفر"&&a.FatherIdCat==-1).ToList();
           
             ViewBag.lselect7= new SelectList(qlist7, "Id", "NameCat");
           ////////////////////////////////////////////////////////////////////////////list view bag complete
            var qlistt=db.tbl_category.ToList();
           var tq=new List<Vm_Category>();
           foreach (var item in qlistt)
           {
            
               if (item.FatherIdCat==-1)
               {
                   NewFileName="دسته اصلی";
               }
               else if (item.FatherIdCat==-2)
               {
                   NewFileName="اخبار و وبلاگ";
               }else if (item.FatherIdCat==-3)
               {
                   NewFileName="صفحه اول";
               }
               else if (item.FatherIdCat==-4)
               {
                   NewFileName="مدوپوشاک";
               }
               else if (item.FatherIdCat==-5)
               {
                   NewFileName="خانه واشپز خانه";
               }
                 else if (item.FatherIdCat==-6)
               {
                   NewFileName="ورزش و سفر";
               }
               else
               {
                    var namefather=qlistt.Where(a=>a.Id== item.FatherIdCat).SingleOrDefault();
                    NewFileName=namefather.NameCat;
               }
              
               
               
                    var d=new Vm_Category()
               {
                   Id=item.Id,
                   NameCat=item.NameCat,
                   FatherIdCat=item.FatherIdCat,
                   fathername=NewFileName
               };
               tq.Add(d);
               
              
               
           }




             ViewBag.list=tq.OrderByDescending(a=>a.Id).ToList();

            //////////////////////////////////////////
           
          
            return View();
            
        }


        public IActionResult add(Vm_Category cat)
        {
        //    var qcat=db.tbl_category.Where(a=>a.NameCat==cat.NameCat && a.FatherIdCat==cat.FatherIdCat).SingleOrDefault();
        //    if (qcat != null)
        //    {
        //        err="این نام قبلا ثبت شده است";
        //    }
        //    else
        //    {
        //        var tbcat=new Tb_Category()
        //        {
        //            Language=cat.Language,
        //            NameCat=cat.NameCat,
        //            FatherIdCat=cat.FatherIdCat
        //        };
        //        db.tbl_category.Add(tbcat);
        //        db.SaveChanges();
        //        suc="اطلاعات با موفقیت ثبت شد";

        //    }
       
            if (cat.FatherIdCat==-1)
            {
                    var tbcat=new Tb_Category()
                {
                 Language=cat.Language,
                 NameCat=cat.NameCat,
                FatherIdCat=-1
                };
                db.tbl_category.Add(tbcat);
              
            }else
            {
                var tbcat=new Tb_Category()
                {
                 Language=cat.Language,
                 NameCat=cat.NameCat,
                FatherIdCat=cat.FatherIdCat
                };
                db.tbl_category.Add(tbcat);
             
                
            }
            
    

            
             db.SaveChanges();
            suc="اطلاعات با موفقیت ثبت شد";
           return RedirectToAction("index","Category",new{area="Admin"});
        }



        public IActionResult del(int id)
        {
            if (db.tbl_category.Any(a=>a.FatherIdCat==id) )
            {
                err="این رکورد شامل زیر مجموعه است ابتدا باید زیر مجموعه های آن را حذف کنید";
                return RedirectToAction("index");
            }
            if (db.Tbl_Product.Any(a =>a.CategoryIdPro==id.ToString()))
            {
                
               err="برای این دسته محصول ثبت شده ابتدا باید محصول رو حذف کنید";
                return RedirectToAction("index");

            }
             if (db.Tbl_Blog.Any(a =>a.IdCtegoryBlo==id))
            {
                
               err="برای این دسته خبر ثبت شده ابتدا باید خبر رو حذف کنید";
                return RedirectToAction("index");

            }
            else
            {
                 var qcat=db.tbl_category.Where(a=>a.Id==id).SingleOrDefault();
             db.tbl_category.Remove(qcat);
             db.SaveChanges();
             suc="رکورد با موفقیت حذف شد";
            }
            
             return RedirectToAction("index");
        }

    }
}