using System.Data;
using System.Reflection.PortableExecutable;
using System.Data.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using New_Project.Models;
using ViewModel.AdminViewModel.Kala;
using ViewModel.Entities.User;
using DataLayer.Entities.User;
using Extensions;
using DataLayer.AdminEntities.Product;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using ViewModels.AdminViewModel.Wallet;
using ViewModel.AdminViewModel.Order;
using DataLayer.AdminEntities.Order;
using ViewModel.AdminViewModel.AdminPay;

namespace New_Project.Controllers
{
    [Authorize]
    public class YourAccountController : Controller
    {
        public static string massage, eror, NewFileName, NewFileName2, msg;
        public static int IdP;
        public static string FileExtension1,NewFileName1;
        private readonly Context_db db;
        private readonly IWebHostEnvironment env;
        public YourAccountController(Context_db _db, IWebHostEnvironment _env)
        {
            db = _db;
            env = _env;
        }
        public IActionResult profile()
        {

            var qcheck = db.Tbl_Users.Where(a => a.Id.ToString() == User.Identity.GetId()).SingleOrDefault();

            HttpContext.Session.SetString("name", qcheck.NameFamily);
            if (qcheck.Image != null)
            {
                HttpContext.Session.SetString("img", qcheck.Image);
            }

            HttpContext.Session.SetString("phone", qcheck.Phone);
            
            HttpContext.Session.SetString("Random_Link",User.Identity.GetId());
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////"در انتظار تایید"


            List<Vm_Kala> or = new List<Vm_Kala>();
            var qKala = db.tbl_Advertisings.Where(a => a.Id_creator == User.Identity.GetId() && a.State == "در انتظار تایید").OrderByDescending(a => a.Id).ToList();

            if (qKala != null)
            {
                foreach (var item in qKala)
                {
                    var UserNamee = db.Tbl_Users.Where(a => a.Id.ToString() == item.Id_creator).SingleOrDefault();
                    var Namee = UserNamee.NameFamily;
                    Vm_Kala q = new Vm_Kala()
                    {

                        Product_Id = item.Id,
                        Title_Pro = item.Title_Pro,
                        Time = item.Time.ToPersianDateString(),
                        Image = item.Image,
                        Name = Namee,
                    };
                    or.Add(q);

                }
                ViewBag.Entezar = or;
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////"تایید شده  "


            List<Vm_Kala> Ok = new List<Vm_Kala>();
            var Kala = db.tbl_Advertisings.Where(a => a.Id_creator == User.Identity.GetId() && a.State == "تایید شده").OrderByDescending(a => a.Id).ToList();

            if (Kala != null)
            {
                foreach (var item in Kala)
                {
                    var UserNamee = db.Tbl_Users.Where(a => a.Id.ToString() == item.Id_creator).SingleOrDefault();
                    var Namee = UserNamee.NameFamily;
                    Vm_Kala q = new Vm_Kala()
                    {

                        Product_Id = item.Id,
                        Title_Pro = item.Title_Pro,
                        Time = item.Time.ToPersianDateString(),
                        Image = item.Image,
                        Name = Namee,
                    };
                    Ok.Add(q);

                }
                ViewBag.Ok = Ok;
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////"عدم شده  "

            List<Vm_Kala> No = new List<Vm_Kala>();
            var NKala = db.tbl_Advertisings.Where(a => a.Id_creator == User.Identity.GetId() && a.State == "عدم تایید").OrderByDescending(a => a.Id).ToList();

            if (NKala != null)
            {
                foreach (var item in NKala)
                {
                    var UserNamee = db.Tbl_Users.Where(a => a.Id.ToString() == item.Id_creator).SingleOrDefault();
                    var Namee = UserNamee.NameFamily;
                    Vm_Kala q = new Vm_Kala()
                    {

                        Product_Id = item.Id,
                        Title_Pro = item.Title_Pro,
                        Time = item.Time.ToPersianDateString(),
                        Image = item.Image,
                        Name = Namee,
                    };
                    No.Add(q);

                }
                ViewBag.No = No;
            }
            menu.cat = db.tbl_category.Where(a => a.Language == "fa").ToList();



            return View();
        }
        public IActionResult Detail(int b)
        {

            var t = db.tbl_Advertisings.Where(a => a.Id == b).SingleOrDefault();
            var u = db.Tbl_Users.Where(a => a.Id.ToString() == t.Id_creator).SingleOrDefault();
            ViewBag.FImage = db.tb_GalleryProducts.Where(a => a.IdProduct == b).ToList();
            var CK = db.tbl_category.Where(a => a.Id.ToString() == t.Category).SingleOrDefault();
            var ChildCat = CK.NameCat;
            var C = db.tbl_category.Where(a => a.Id == CK.FatherIdCat).SingleOrDefault();
            var Cat = C.NameCat;
            var FC = db.tbl_category.Where(a => a.Id == C.FatherIdCat).SingleOrDefault();
            if (FC!=null)
            {
               ViewBag.FatherCat = FC.NameCat;
            }
            


            List<Vm_Detail> sd = new List<Vm_Detail>();

            Vm_Detail q = new Vm_Detail()
            {
                Id = t.Id,
                Id_creator = Convert.ToString(t.Id),
                Image = t.Image,
                Image1=t.Image1,
                Image2=t.Image2,
                Image3=t.Image3,
                Title_Pro = t.Title_Pro,
                Discreption_Pro = t.Discreption_Pro,
                Type_pro = t.Type_pro,
                Type_Transaction = t.Type_Transaction,
                Main_Price = t.Main_Price,
                Discount_Price = t.Discount_Price,
                Time = t.Time.ToPersianDateString(),
                NameCrator = u.NameFamily,
                PhoneCreator = u.Phone,
                Total = t.Number,
                Special = t.Special,
                FatherCat = ViewBag.FatherCat,
                Cat = Cat,
                ChildCat = ChildCat,


            };
            sd.Add(q);

            ViewBag.listp = sd;

            return View();

        }
                public IActionResult DetailOk(int b)
        {

            var t = db.tbl_Advertisings.Where(a => a.Id == b).SingleOrDefault();
            var u = db.Tbl_Users.Where(a => a.Id.ToString() == t.Id_creator).SingleOrDefault();
            ViewBag.FImage = db.tb_GalleryProducts.Where(a => a.IdProduct == b).ToList();
            var CK = db.tbl_category.Where(a => a.Id.ToString() == t.Category).SingleOrDefault();
            var ChildCat = CK.NameCat;
            var C = db.tbl_category.Where(a => a.Id == CK.FatherIdCat).SingleOrDefault();
            var Cat = C.NameCat;
            var FC = db.tbl_category.Where(a => a.Id == C.FatherIdCat).SingleOrDefault();
            var FatherCat =CK.Language;
            List<Vm_Detail> sd = new List<Vm_Detail>();

            Vm_Detail q = new Vm_Detail()
            {
                Id = t.Id,
                Id_creator = Convert.ToString(t.Id),
                Image = t.Image,
                Image1=t.Image1,
                Image2=t.Image2,
                Image3=t.Image3,
                Title_Pro = t.Title_Pro,
                Discreption_Pro = t.Discreption_Pro,
                Type_pro = t.Type_pro,
                Type_Transaction = t.Type_Transaction,
                Main_Price = t.Main_Price,
                Discount_Price = t.Discount_Price,
                Time = t.Time.ToPersianDateString(),
                NameCrator = u.NameFamily,
                PhoneCreator = u.Phone,
                Total = t.Number,
                Special = t.Special,
                FatherCat = FatherCat,
                Cat = Cat,
                ChildCat = ChildCat,

            };
            sd.Add(q);

            ViewBag.listp = sd;

            return View();

        }
        public IActionResult DetailNO(int b)
        {

            var t = db.tbl_Advertisings.Where(a => a.Id == b).SingleOrDefault();
            var u = db.Tbl_Users.Where(a => a.Id.ToString() == t.Id_creator).SingleOrDefault();
            ViewBag.FImage = db.tb_GalleryProducts.Where(a => a.IdProduct == b).ToList();
            var CK = db.tbl_category.Where(a => a.Id.ToString() == t.Category).SingleOrDefault();
            var ChildCat = CK.NameCat;
            var C = db.tbl_category.Where(a => a.Id == CK.FatherIdCat).SingleOrDefault();
            var Cat = C.NameCat;
            var FC = db.tbl_category.Where(a => a.Id == C.FatherIdCat).SingleOrDefault();
            var FatherCat = CK.Language;
            List<Vm_Detail> sd = new List<Vm_Detail>();

            Vm_Detail q = new Vm_Detail()
            {
                Id = t.Id,
                Id_creator = Convert.ToString(t.Id),
                Image = t.Image,
                Image1=t.Image1,
                Image2=t.Image2,
                Image3=t.Image3,
                Title_Pro = t.Title_Pro,
                Discreption_Pro = t.Discreption_Pro,
                Type_pro = t.Type_pro,
                Type_Transaction = t.Type_Transaction,
                Main_Price = t.Main_Price,
                Discount_Price = t.Discount_Price,
                Time = t.Time.ToPersianDateString(),
                NameCrator = u.NameFamily,
                PhoneCreator = u.Phone,
                Total = t.Number,
                Special = t.Special,
                FatherCat = FatherCat,
                Cat = Cat,
                ChildCat = ChildCat,

            };
            sd.Add(q);

            ViewBag.listp = sd;

            return View();

        }
        public IActionResult del(int b)
        {
            var qorder = db.tbl_Advertisings.Where(a => a.Id == b).SingleOrDefault();
            db.tbl_Advertisings.Remove(qorder);
            db.SaveChanges();
            eror = "آگهی با موفقیت حذف شد";
            return RedirectToAction("profile");
        }
        public async Task<IActionResult> Edit(int b)
            {
            var Tb_Advert = db.tbl_Advertisings.Where(a => a.Id == b).SingleOrDefault();
            Vm_Advertising Advert = new Vm_Advertising()
            {
                Id=b,
                Category = Tb_Advert.Category,
                Title_Pro = Tb_Advert.Title_Pro,
                Discreption_Pro = Tb_Advert.Discreption_Pro,
                Type_pro = Tb_Advert.Type_pro,
                Type_Transaction = Tb_Advert.Type_Transaction,
                /////////////////////////////////////////////////////////
                Main_Price_Auction = Tb_Advert.Main_Price_Auction,
                Auction_Time = Tb_Advert.Auction_Time,
                Auction_Start_Time = Tb_Advert.Auction_Start_Time,
                ////////////////////////////////////////////////////////
                Main_Price = Tb_Advert.Main_Price,
                Discount_Price = Tb_Advert.Discount_Price,
                Online_Exchange = Tb_Advert.Online_Exchange,
                Take_Discount = Tb_Advert.Take_Discount,
                Image = Tb_Advert.Image,
                Image1 = Tb_Advert.Image1,
                Image2 = Tb_Advert.Image2,
                Image3 = Tb_Advert.Image3,
                Number = Tb_Advert.Number,
            };
            ViewBag.FImage = db.tb_GalleryProducts.Where(a => a.IdProduct == b).ToList();
            return View(Advert);
        }
        public IActionResult ReturnShow(int b)
        {
            ViewBag.q = db.tbl_Advertisings.Where(a => a.Id == b).ToList();
            return View();
        }
        public IActionResult Orders()
        {
               ViewBag.list= db.Tbl_Factors.Where(a => a.Id_Order == Convert.ToInt32(User.Identity.GetId()) && a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();

            return View();
        }
        public IActionResult TahvilNOShow(int c)
        {
            ViewBag.list= db.Tbl_Factors.Where(a => a.Id == c).ToList();
            return View();
        }
        public IActionResult OrdersReturn()
        {
            ViewBag.s=db.Tbl_Factors.Where(a=>a.Id_Order.ToString() == User.Identity.GetId() && (a.StatusM=="قصد مرجوعی خریدار" || a.StatusM=="مرجوع شده" || a.StatusM=="عدم تایید قصد مرجوعی" || a.StatusM=="مرجوع ارسال شده")).ToList();
            return View();
        }
        public IActionResult TahvilOrder(int c)
        {
            var s= db.Tbl_Factors.Where(a => a.Id == c).SingleOrDefault();
            s.StatusM="دریافت توسط خریدار";
            s.StatusA="Ok";
            db.Tbl_Factors.Update(s);
            db.SaveChanges();
             return RedirectToAction("Orders");
        }
        public IActionResult TahvilNO(int c)
        {
            IdP=c;
             return View("OrderDetails");
        }
         public async Task<IActionResult> OrderDetails(Vm_Factor Vf)
        {


            string FileExtension1 = Path.GetExtension (Vf.ImageReturn.FileName);
            NewFileName1 = String.Concat (Guid.NewGuid ().ToString (), FileExtension1);
            var path = $"{env.WebRootPath}\\fileupload\\{NewFileName1}";
            using (var stream = new FileStream (path, FileMode.Create)) {
                await Vf.ImageReturn.CopyToAsync (stream);
            }



            var s= db.Tbl_Factors.Where(a => a.Id == IdP).SingleOrDefault();
            s.Why_Return_Request=Vf.Why_Return_Request;
            s.StatusM="قصد مرجوعی خریدار";
            s.ImageReturn=NewFileName1;
            s.StatusA="R";
            db.Tbl_Factors.Update(s);
            db.SaveChanges();
            return RedirectToAction("Orders");
        }
        [AllowAnonymous, Route("/Invite/{id}")]
        public IActionResult Invite(string? id)
        {
            // var s= db.Tbl_Users.Where(a => a.Random_Link.ToString() == id).SingleOrDefault();
            // var Rl=s.Id;
            ViewBag.I =db.Tbl_Users.Where(a => a.Random_Link.ToString() == id).ToList();
           
            return View();
        }
/// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public IActionResult Sales()
        {

            ViewBag.list= db.Tbl_Factors.Where(a => a.Id_creator == Convert.ToInt32(User.Identity.GetId()) && a.Pay == "Ok").OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        public IActionResult OkSales(int c)
        {
            var s= db.Tbl_Factors.Where(a => a.Id == c).SingleOrDefault();
            s.StatusM="در انتظار ارسال فروشنده";
            db.Tbl_Factors.Update(s);
            db.SaveChanges();

            return RedirectToAction("Sales");
        }
        public IActionResult NoSales(int c)
        {
            var s= db.Tbl_Factors.Where(a => a.Id == c).SingleOrDefault();
            s.StatusM="عدم تایید فروشنده";
            s.StatusA="No";
            db.Tbl_Factors.Update(s);
            db.SaveChanges();

             return RedirectToAction("Sales");
        }
        public IActionResult WyNoShow(int c)
        {
            ViewBag.list= db.Tbl_Factors.Where(a =>a.Id==c).ToList();
            return View();
        }
        public IActionResult Tahvil(int c)
        {
            var s= db.Tbl_Factors.Where(a => a.Id == c).SingleOrDefault();
            s.StatusM="تحویل داده شده به نوِنو";
            db.Tbl_Factors.Update(s);
            db.SaveChanges();
             return RedirectToAction("Sales");
        }
        public IActionResult TahvilSales(int c)
        {
            var s= db.Tbl_Factors.Where(a => a.Id == c).SingleOrDefault();
            s.StatusM="مرجوع شده";

            if (s.Type_Transaction=="بازرسی")
            {
                s.StatusA="NoB";
            }
            if (s.Type_Transaction=="مستقیم")
            {
                s.StatusA="No";
            }
           
            db.Tbl_Factors.Update(s);
            db.SaveChanges();
            return RedirectToAction("Sales");
        }
        public IActionResult Send(Vm_Factor vf)
        {
            var s= db.Tbl_Factors.Where(a => a.Id == vf.Id).SingleOrDefault();
            s.Send_Sales_Code=vf.Send_Sales_Code;
            if (vf.PriceB !=0)
            {
                s.StatusM="ارسال شده به نوِنو";
            }
            else
            {
                 s.StatusM="ارسال شده به خریدار";
            }
            db.Tbl_Factors.Update(s);
            db.SaveChanges();

             return RedirectToAction("Sales");
        }
        public IActionResult SendOrder (Vm_Factor vf)
        {
            var s= db.Tbl_Factors.Where(a => a.Id == vf.Id).SingleOrDefault();
            s.Send_Order_Code=vf.Send_Order_Code;
            s.StatusM="مرجوع ارسال شده";
            db.Tbl_Factors.Update(s);
            db.SaveChanges();

             return RedirectToAction("Orders");
        }
        public IActionResult ShowInvite()
        {
            var s=db.Tbl_Users.Where(a=>a.Code == User.Identity.GetId()).ToList();
            ViewBag.s=s.Count();
            var b=s.Where(a=>a.RPass=="Ok").Count();
            ViewBag.o=b;
            ViewBag.t=b*10000;

            return View();
        }
        public IActionResult InviteDetail()
        {
             ViewBag.s=db.Tbl_Users.Where(a=>a.Code == User.Identity.GetId() && a.RPass=="Ok").ToList();
            
            return View();
        }
        public IActionResult Favorites()
        {
            var s=db.Tbl_MyFavorites.Where(a=>a.IdUser.ToString()==User.Identity.GetId()).ToList();
            List<Vm_Favorite> p = new List<Vm_Favorite>();

                foreach (var item in s)
                {
                    var f=db.tbl_Advertisings.Where(a=>a.Id==item.IdKala).SingleOrDefault();
                    Vm_Favorite Vf= new Vm_Favorite()
                    {
                        Id=f.Id,
                        Title_Pro=f.Title_Pro,
                        Main_Price=f.Main_Price,
                        Discount_Price=f.Discount_Price,
                        Image=f.Image,
                    };

                    p.Add(Vf);

                }

            ViewBag.f=p;

            return View();
        }
        public IActionResult DelFavorite(int id)
        {
            var qorder = db.Tbl_MyFavorites.Where(a => a.IdKala == id && a.IdUser.ToString()==User.Identity.GetId()).SingleOrDefault();
            db.Tbl_MyFavorites.Remove(qorder);
            db.SaveChanges();
            return RedirectToAction("Favorites");
        }
        public IActionResult Comments()
        {
            return View();
        }
        public IActionResult Addresses()
        {
            return View();
        }
        public IActionResult UserHistory()
        {
            return View();
        }
        public IActionResult Wallet()
        {
            return View();
        }
        
        
        public IActionResult AccountMe()
        {
              


            List<Vm_Pay> A = new List<Vm_Pay>();

            var a = db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId()) && a.status == true).OrderByDescending(a => a.Id).ToList();


            foreach (var item in a)
            {

                Vm_Pay B = new Vm_Pay()
                {
                    Id = item.Id,
                    Phone = item.Phone,
                    Pay = item.Pay,
                    Harvest = item.Harvest,
                    Paytime = item.Paytime.ToPersianDateString(),

                    status = item.status,
                    iduser = item.iduser,
                    NameFamily = item.NameFamily,




                };
                A.Add(B);
            }


              HttpContext.Session.SetString("pay", Diposit().ToString());
            ViewBag.list2 = A.OrderByDescending(a => a.Id);
            int B1 = db.Tbl_Factors.Where(a => a.Id_Order == Convert.ToInt32(User.Identity.GetId()) && a.StatusA == "No").Sum(a => a.product_Price);
            // int B2 = db.Tbl_Factors.Where(a => a.Id_creator == Convert.ToInt32(User.Identity.GetId()) && a.StatusA == "Ok").Sum(a => a.product_Price);
            // int pay = db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId())&&a.status == true).Sum(a => a.Pay);
            // int horvest = db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId())&&a.StatusP=="OK").Sum(a => a.Harvest);
            // ViewBag.Oll=(B1+B2+pay)-horvest;


            /////////////////////////////////////////////////////////////////////////////////////////////قفل شده
            var goflshode=db.Tbl_Factors.Where(a=>a.Id_creator==Convert.ToInt32(User.Identity.GetId()) && a.StatusA=="R").Sum(a => a.product_Price);
            ViewBag.gofl=goflshode;


            //////////////////////////////////////////////////////////////////////////////////////////قابل معامله
            var variziha=db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId()) && a.status == true).Sum(a => a.Pay);
            var oksell=db.Tbl_Factors.Where(a => a.Id_creator == Convert.ToInt32(User.Identity.GetId()) && a.StatusA == "Ok").Sum(a => a.product_Price);

            ///لیست دعوت شدگان
            var s=db.Tbl_Users.Where(a=>a.Code==User.Identity.GetId() && a.RPass=="Ok").Count();
            var davatiha=s*10000;

            ///واریزی های مدیر
            int adminpays1=db.AdminPays.Where(a=>a.IdUser==User.Identity.GetId()).Sum(a =>a.Price);
            int adminpays2=db.AdminPays.Where(a=>a.IdUser==User.Identity.GetId()&& a.TypePay=="قابل برداشت").Sum(a =>a.Price);

            ///خرید های ناموفق
            var No=db.Tbl_Factors.Where(a => a.Id_Order == Convert.ToInt32(User.Identity.GetId()) && a.StatusA == "No").Sum(a => a.Total_sum);
            var NoB=db.Tbl_Factors.Where(a => a.Id_Order == Convert.ToInt32(User.Identity.GetId()) && a.StatusA == "NoB").Sum(a => a.PriceB);





            var buyok =db.Tbl_Factors.Where(a => a.Id_Order == Convert.ToInt32(User.Identity.GetId())&&a.Pay=="Ok" && (a.StatusA=="Ok" || a.StatusA=="R")).Sum(s=>s.Total_sum);
            var komision=db.Tbl_Factors.Where(a => a.Id_creator == Convert.ToInt32(User.Identity.GetId()) && a.StatusA == "Ok").Sum(a => a.PriceK);
            var horvest= db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId())&&a.StatusP=="OK").Sum(a => a.Harvest);


            var moamelesum=(variziha+oksell+davatiha+adminpays1)-(buyok+komision+horvest+NoB);

            ViewBag.moamele=moamelesum;
            ViewBag.bardasht=(variziha+oksell+adminpays2)-(buyok+komision+horvest+NoB);
            ViewBag.all=goflshode+moamelesum;
            

            return View();
        }
        public int Diposit()
        {
            int pay = db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId())&&a.status==true).Sum(a => a.Pay);
            int horvest = db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId())).Sum(a => a.Harvest);
            return pay - horvest;
        }
       [AllowAnonymous, Route("/{id}")]
        public IActionResult ProfileUser(string? id)
        {
            var s=db.Tbl_Users.Where(x=>x.Random_Link.ToString()== id ).SingleOrDefault().Id;
            ViewBag.I = db.Tbl_Users.Where(a => a.Random_Link.ToString() == id).ToList();
            ViewBag.b=db.tbl_Advertisings.Where(a=>a.Id_creator== s.ToString() && a.State == "تایید شده").Count();
            ViewBag.q=db.tbl_Advertisings.Where(a=>a.Id_creator== s.ToString() && a.State == "تایید شده").OrderByDescending(a => a.Id).Take(10).ToList();


            return View();
        }
        public async Task<IActionResult> AdditionalInfo()
        {

            var qcheck = db.Tbl_Users.Where(a => a.Id.ToString() == User.Identity.GetId()).SingleOrDefault();
            if (qcheck.Image != null)
            {
                HttpContext.Session.SetString("img", qcheck.Image);
            }


            if (msg != null)

            {

                ViewBag.msg = msg;
                msg = null;
            }


            if (qcheck != null)
            {
                Vm_User VmUs = new Vm_User()
                {
                    Id = qcheck.Id,
                    Phone = qcheck.Phone,
                    NameFamily = qcheck.NameFamily,
                    CodeNational = qcheck.CodeNational,
                    Email = qcheck.Email,
                    Image = qcheck.Image,
                    city = qcheck.city,
                    CardNumber = qcheck.CardNumber,
                    Address = qcheck.Address,
                    Post = qcheck.Post,
                    State=qcheck.State,

                     
                };
                return View(VmUs);

            }
            else
            {
                return View();

            }

        }
        public async Task<IActionResult> Update(Vm_User VmUser)
        {

            var qcheck = db.Tbl_Users.Where(a => a.Id == VmUser.Id).SingleOrDefault();

            qcheck.NameFamily = VmUser.NameFamily;
            qcheck.CodeNational = VmUser.CodeNational;
            qcheck.Email = VmUser.Email;
            qcheck.city = VmUser.city;
            qcheck.CardNumber = VmUser.CardNumber;
            qcheck.Address = VmUser.Address;
            qcheck.Post = VmUser.Post;  
            qcheck.State = VmUser.State;
            




            // qcheck.Image = NewFileName;

            if (VmUser.Img != null)
            {
                string FileExtension1 = Path.GetExtension(VmUser.Img.FileName);
                NewFileName = String.Concat(Guid.NewGuid().ToString(), FileExtension1);
                var path = $"{env.WebRootPath}\\FileUpload\\{NewFileName}";
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await VmUser.Img.CopyToAsync(stream);
                }
                qcheck.Image = NewFileName;
            }

            db.Tbl_Users.Update(qcheck);
            db.SaveChanges();

            msg = " بروزرسانی با موفقیت انجام شد  ";

            return RedirectToAction("profile");
        }
        public IActionResult AdditionalInfoShow()
        {
            var qcheck = db.Tbl_Users.Where(a => a.Id.ToString() == User.Identity.GetId()).SingleOrDefault();
            return View(qcheck);
        }
        public IActionResult Pay()
        {
           ViewBag.pay =db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId()) && a.status == true).OrderByDescending(a => a.Id).ToList();
            return View();
        }
             public IActionResult harvest()
        {
             ViewBag.harvest =db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId())&&a.Pay==0 &&a.Harvest!=0 && a.StatusP=="Ok").OrderByDescending(a => a.Id).ToList();
            return View();
        }
        public IActionResult HarvestRequest()
        {
            ViewBag.harvest =db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId())&&a.Pay==0 &&a.Harvest!=0).OrderByDescending(a => a.Id).ToList();
            return View();
        }
        public IActionResult success()
        {
             ViewBag.success =db.Tbl_Factors.Where(a => a.Id_creator == Convert.ToInt32(User.Identity.GetId())&&a.Pay=="Ok" &&a.StatusA=="Ok").OrderByDescending(a => a.Id).ToList();
            return View();
        }
           public IActionResult Nosuccess()
        {
             ViewBag.success =db.Tbl_Factors.Where(a => a.Id_creator == Convert.ToInt32(User.Identity.GetId())&&a.Pay=="Ok" && (a.StatusA=="No" || a.StatusA=="NoB")).OrderByDescending(a => a.Id).ToList();
            return View();
        }
           public IActionResult wait()
        {
             ViewBag.success =db.Tbl_Factors.Where(a => a.Id_creator == Convert.ToInt32(User.Identity.GetId())&&a.Pay=="Ok" &&a.StatusA=="R").OrderByDescending(a => a.Id).ToList();
            return View();
        }
           public IActionResult Buy()
        {
             ViewBag.success =db.Tbl_Factors.Where(a => a.Id_Order == Convert.ToInt32(User.Identity.GetId())&&a.Pay=="Ok" && (a.StatusA=="Ok" || a.StatusA=="R") ).OrderByDescending(a => a.Id).ToList();
            return View();
        }
          public IActionResult adminpays()
        {
            ///لیست دعوت شدگان
            var s=db.Tbl_Users.Where(a=>a.Code==User.Identity.GetId() && a.RPass=="Ok").ToList();
            ///جوایز مدیر
            var b=db.AdminPays.Where(a=>a.IdUser==User.Identity.GetId()).ToList();
            ///اضافه کردن دعوت شدگان به لیست
            List<Vm_adminPay2> pay2=new List<Vm_adminPay2>();
            foreach (var item in s)
            {
                Vm_adminPay2 p=new Vm_adminPay2()
                {
                    id=item.Id,
                    pay=10000,
                    detail="بابت دعوت "+" "+item.NameFamily,
                    typedeposit="قابل معامله",
                    typepay="user"


                };
                pay2.Add(p);
                
            }

            //اضافه کردن واریزی های مدیر 
            foreach (var item in b)
            {
                Vm_adminPay2 p=new Vm_adminPay2()
                {
                    id=item.Id,
                    pay=Convert.ToInt32(item.Price),
                    detail=item.Detail,
                    typedeposit=item.TypePay,
                    typepay="admin"


                };
                pay2.Add(p);
                
            }
            ///ارسال به ویو
            ViewBag.o=pay2;

            return View();
        }
           public IActionResult NoBuy()
        {
             ViewBag.success =db.Tbl_Factors.Where(a => a.Id_Order == Convert.ToInt32(User.Identity.GetId())&&a.Pay=="Ok" &&(a.StatusA=="NO" || a.StatusA=="NoB")).OrderByDescending(a => a.Id).ToList();
            return View();
        }
        public IActionResult all()
        {
            var pay = db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId()) && a.status == true).OrderByDescending(a => a.Id).ToList();
            var harvest=db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId())&&a.Pay==0 &&a.Harvest!=0 && a.StatusP=="Ok").OrderByDescending(a => a.Id).ToList();
            var success=db.Tbl_Factors.Where(a => a.Id_creator == Convert.ToInt32(User.Identity.GetId())&&a.Pay=="Ok" &&a.StatusA=="Ok").OrderByDescending(a => a.Id).ToList();
            var nosuccess=db.Tbl_Factors.Where(a => a.Id_creator == Convert.ToInt32(User.Identity.GetId())&&a.Pay=="Ok" && (a.StatusA=="No" || a.StatusA=="NoB")).OrderByDescending(a => a.Id).ToList();
            var wait=db.Tbl_Factors.Where(a => a.Id_creator == Convert.ToInt32(User.Identity.GetId())&&a.Pay=="Ok" &&a.StatusA=="R").OrderByDescending(a => a.Id).ToList();
            var buy=db.Tbl_Factors.Where(a => a.Id_Order == Convert.ToInt32(User.Identity.GetId())&&a.Pay=="Ok" && (a.StatusA=="Ok" || a.StatusA=="R") ).OrderByDescending(a => a.Id).ToList();
            var nobuy=db.Tbl_Factors.Where(a => a.Id_Order == Convert.ToInt32(User.Identity.GetId())&&a.Pay=="Ok" &&(a.StatusA=="NO" || a.StatusA=="NoB")).OrderByDescending(a => a.Id).ToList();
            ///لیست دعوت شدگان
            var s=db.Tbl_Users.Where(a=>a.Code==User.Identity.GetId() && a.RPass=="Ok").ToList();
            ///جوایز مدیر
            var b=db.AdminPays.Where(a=>a.IdUser==User.Identity.GetId()).ToList();
            ///اضافه کردن دعوت شدگان به لیست
            List<Vm_adminPay2> pay2=new List<Vm_adminPay2>();
            foreach (var item in s)
            {
                Vm_adminPay2 p=new Vm_adminPay2()
                {
                    id=item.Id,
                    pay=10000,
                    detail="بابت دعوت "+" "+item.NameFamily,
                    typedeposit="قابل معامله",
                    typepay="user",
                    time="",


                };
                pay2.Add(p);
                
            }

            //اضافه کردن واریزی های مدیر 
            foreach (var item in b)
            {
                Vm_adminPay2 p=new Vm_adminPay2()
                {
                    id=item.Id,
                    pay=Convert.ToInt32(item.Price),
                    detail=item.Detail,
                    typedeposit=item.TypePay,
                    typepay="admin",
                    time=item.Time.ToPersianDateString(),


                };
                pay2.Add(p);
                
            }
            ///ارسال به متغیر
            var adminpay=pay2;
           
            ////////////////////////////////////////////////////////////////////////////////////////
           
            List<Vm_Details> Details=new List<Vm_Details>();
              foreach (var item in pay)
            {
                Vm_Details Vm_pay=new Vm_Details()
                {
                      Date =item.Paytime.ToPersianDateString(),
                      Price =item.Pay,
                      Type ="واریز",
                      Status ="موفقیت آمیز",
                      Bazrasi =0,
                      Komision =0,
                      MyProperty =0,
                      one ="",


                };
                Details.Add(Vm_pay);
                
            }
              foreach (var item in harvest)
            {
                Vm_Details Vm_harvest=new Vm_Details()
                {
                      Date =item.havesttime.ToPersianDateString(),
                      Price =item.Harvest,
                      Type ="برداشت",
                      Status ="موفقیت آمیز",
                      Bazrasi =0,
                      Komision =0,
                      MyProperty =0,
                      one ="",


                };
                Details.Add(Vm_harvest);
                
            }
              foreach (var item in success)
            {
                Vm_Details Vm_success=new Vm_Details()
                {
                      Date =item.Date_Order.ToPersianDateString(),
                      Price =item.Total_sum,
                      Type ="فروش موفق",
                      Status ="موفقیت آمیز",
                      Bazrasi =item.PriceB,
                      Komision =item.PriceK,
                      MyProperty =0,
                      one ="",


                };
                Details.Add(Vm_success);
                
            }
            foreach (var item in nosuccess)
            {
                Vm_Details Vm_nosuccess=new Vm_Details()
                {
                      Date =item.Date_Order.ToPersianDateString(),
                      Price =item.Total_sum,
                      Type ="فروش ناموفق",
                      Status ="عدم موفقیت",
                      Bazrasi =item.PriceB,
                      Komision =item.PriceK,
                      MyProperty =0,
                      one ="",


                };
                Details.Add(Vm_nosuccess);
                
            }
            foreach (var item in wait)
            {
                Vm_Details Vm_wait=new Vm_Details()
                {
                      Date =item.Date_Order.ToPersianDateString(),
                      Price =item.Total_sum,
                      Type ="فروش درحال انجام",
                      Status ="درحال انجام",
                      Bazrasi =item.PriceB,
                      Komision =item.PriceK,
                      MyProperty =0,
                      one ="",



                };
                Details.Add(Vm_wait);
                
            }
            foreach (var item in buy)
            {
                Vm_Details Vm_buy=new Vm_Details()
                {
                      Date =item.Date_Order.ToPersianDateString(),
                      Price =item.Total_sum,
                      Type ="خرید موفق",
                      Status ="موفقیت آمیز",
                      Bazrasi =item.PriceB,
                      Komision =item.PriceK,
                      MyProperty =0,
                      one ="",



                };
                Details.Add(Vm_buy);
                
            }
            foreach (var item in nobuy)
            {
                Vm_Details Vm_nobuy=new Vm_Details()
                {
                      Date =item.Date_Order.ToPersianDateString(),
                      Price =item.Total_sum,
                      Type ="خرید ناموفق",
                      Status ="عدم موفقیت ",
                      Bazrasi =item.PriceB,
                      Komision =item.PriceK,
                      MyProperty =0,
                      one ="",


                };
                Details.Add(Vm_nobuy);
                
            }
            foreach (var item in adminpay)
            {
                Vm_Details Vm_adminpay=new Vm_Details()
                {
                      Date =item.time,
                      Price =item.pay,
                      Type =item.detail,
                      Status =item.typedeposit,
                      Bazrasi =0,
                      Komision =0,
                      MyProperty =0,
                      one ="",
                };
                Details.Add(Vm_adminpay);
                
            }
           
                ViewBag.det=Details.OrderByDescending(a=>a.Date);
            /// ////////////////////////////////////////////////////////////////////////////////////////


            return View();
        }
    }
}