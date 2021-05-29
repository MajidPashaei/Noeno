using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using New_Project.Models;
using DataLayer.Context;
using DataLayer.AdminEntities.Price;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Hosting;

using ViewModel.AdminViewModel.Price;


namespace New_Project.Areas.Admin.Controllers
{
      public class  PriceController: BaseController
    {
       public PriceController(Context_db _db,IWebHostEnvironment  env) :base(_db,env)
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
             var qlist=db.Tbl_Price.ToList();
           
             ViewBag.lselect=qlist;
           ////////////////////////////////////////////////////////////////////////////list view bag complete
            var qlistt=db.Tbl_Price.ToList();
           var tq=new List<Vm_Price>();
           foreach (var item in qlistt)
           {
               
                var d=new Vm_Price()
                {   Id=item.Id,
                    Cat_Type=item.Cat_Type,
                    Max=item.Max,
                    Min=item.Min,
                    Price=item.Price,
                };
               tq.Add(d);
               
              
               
           }




             ViewBag.list=tq.OrderByDescending(a=>a.Id).ToList();

            //////////////////////////////////////////
           
          
            return View();
            
        }


        public IActionResult add (Vm_Price pr)
            {
               Tb_Price tbcat=new Tb_Price()
               {
                   Cat_Type=pr.Cat_Type,
                   Min=pr.Min,
                   Max=pr.Max,
                   Price=pr.Price,


               };
               db.Tbl_Price.Add(tbcat);
               db.SaveChanges();
               suc="اطلاعات با موفقیت ثبت شد";

          return RedirectToAction("Index");
        }



         public IActionResult del(int id)
        {
            
            var qcat=db.Tbl_Price.Where(a=>a.Id==id).SingleOrDefault();
             db.Tbl_Price.Remove(qcat);
             db.SaveChanges();
             err="رکورد با موفقیت حذف شد";
            
             return RedirectToAction("index");
        }
    }
}