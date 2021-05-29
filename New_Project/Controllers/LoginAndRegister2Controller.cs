using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Entities.User;
using Kavenegar;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using New_Project.Models;
using ViewModel.Entities;
using ViewModel.Entities.User;
using Microsoft.AspNetCore.Http;
using System.Data;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;


namespace New_Project.Controllers {
    public class LoginAndRegister2Controller : Controller {
        public static string massage;
        // public static string mobile;
        public static string msg;

        private readonly Context_db _db;
        private readonly IWebHostEnvironment env;

        public LoginAndRegister2Controller (Context_db db, IWebHostEnvironment _env) {
            _db = db;
            env = _env;
        }

        public IActionResult Login () {

            return View ();
        }
        public IActionResult Register () {

            if (msg != null)

            {

                ViewBag.msg = msg;
                msg = null;
            }

            return View ();

        }
        public IActionResult ForgetPass () {

            return View ();
        }

        public IActionResult LoginCode (Vm_User us) {

            if (msg != null)

            {

                ViewBag.msg = msg;
                msg = null;
            }

            if (HttpContext.Session.GetString("mobile") != null) {
                ViewBag.mobile = HttpContext.Session.GetString("mobile");

            }

            var q = _db.Tbl_Users.Where (a => a.Phone == HttpContext.Session.GetString("mobile")).SingleOrDefault ();

            return View ();
        }
        public IActionResult LoginPass () {
            if (msg != null)

            {

                ViewBag.msg = msg;
                msg = null;
            }

            return View ();
        }

        ////////////////////////////////////////////////////////////////////////////////// compare pass
        public IActionResult comparepass (Vm_User us) {

            var Q = _db.Tbl_Users.Where (a => a.Password == us.Password && a.Phone == HttpContext.Session.GetString("mobile")).SingleOrDefault ();

            if (Q != null) {

                var claims = new List<Claim> () {
                new Claim (ClaimTypes.NameIdentifier, Q.Id.ToString ()),
                new Claim (ClaimTypes.Name, Q.NameFamily)
                };

                var identity = new ClaimsIdentity (claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal (identity);

                var properties = new AuthenticationProperties {
                    IsPersistent = true
                };

                HttpContext.SignInAsync (principal, properties);

                HttpContext.Session.SetString ("name", Q.NameFamily + "" + Q.NameFamily);
                  HttpContext.Session.SetString("RLink",Q.Random_Link.ToString());

                return RedirectToAction ("additionalinfo", "YourAccount2");
            } else {
                msg = "پسورد وارد شده صحیح نمی باشد";

                return RedirectToAction ("LoginPass");

            }

        }
        ////////////////////////////////////////////////////////////////////////////////// end compare pass

        public IActionResult Add (Tbl_User Quser) {

            var q = _db.Tbl_Users.Where (a => a.Phone == HttpContext.Session.GetString("mobile")).SingleOrDefault ();
         

            if (Quser.Password != Quser.RPass)
            {
                 msg="رمز های وارد شده با هم مطابقت ندارند ";
               return RedirectToAction("Register");
            } else{
                 int Rn;
                var R=new Random();
                Rn=R.Next(100000, 999999);
                Boolean checkr;
                 checkr=_db.Tbl_Users.Any(a=>a.Random_Link==Rn);
                while ( checkr==true)
                {
                   
                      Rn=R.Next(1000, 9999);
                     checkr=_db.Tbl_Users.Any(a=>a.Random_Link==Rn);
                };
            q.NameFamily = Quser.NameFamily;
            q.Code = Quser.Code;
            q.Phone = HttpContext.Session.GetString("mobile");
            q.Password = Quser.Password;
            q.city = Quser.city;
            q.State=Quser.State;
            q.TimeLogIn=DateTime.Today;
            q.Random_Link=Rn;
           
               
            _db.Tbl_Users.Update (q);
            _db.SaveChanges ();
              HttpContext.Session.SetString("RLink",Rn.ToString());
            
            }
           
           

            var Q = _db.Tbl_Users.Where (a => a.Phone == HttpContext.Session.GetString("mobile")).SingleOrDefault ();
             var claims = new List<Claim> () {
                new Claim (ClaimTypes.NameIdentifier, Q.Id.ToString ()),
                new Claim (ClaimTypes.Name, Q.NameFamily)
                    };

                    var identity = new ClaimsIdentity (claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal (identity);

                    var properties = new AuthenticationProperties {
                        IsPersistent = true
                    };

                    HttpContext.SignInAsync (principal, properties);

                    HttpContext.Session.SetString ("name", Q.NameFamily );

            return RedirectToAction ("additionalinfo", "YourAccount2");
        }
        public IActionResult CheckCode (Vm_User us) {

            var Q = _db.Tbl_Users.Where (a => a.TokenPhone == us.TokenPhone && a.Phone == HttpContext.Session.GetString("mobile")).SingleOrDefault ();

            if (Q != null) {

                if (_db.Tbl_Users.Any (a => a.Phone == HttpContext.Session.GetString("mobile") && a.NameFamily != null)) {

                var claims = new List<Claim> () {
                new Claim (ClaimTypes.NameIdentifier, Q.Id.ToString ()),
                new Claim (ClaimTypes.Name, Q.NameFamily)
                    };

                    var identity = new ClaimsIdentity (claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal (identity);

                    var properties = new AuthenticationProperties {
                        IsPersistent = true
                    };

                    HttpContext.SignInAsync (principal, properties);

                    HttpContext.Session.SetString ("name", Q.NameFamily + "" + Q.NameFamily);

                    //   var qb = _db.Tbl_Users.Where (a =>  a.NameFamily != "" && a.Phone == mobile).SingleOrDefault ();
                    //   if (qb != null)
                    //   {
                    //        return RedirectToAction ("LoginCode", "LoginAndRegister");
                    //   }

                    return RedirectToAction ("Loginpass", "LoginAndRegister2");
                } else {

                    return RedirectToAction ("Register");
                }

            } else

            {

                msg = "کد وارد شده صحیح نمی باشد";

                return RedirectToAction ("LoginCode");

            }

        }

        public IActionResult sendtoken (Vm_User us) {
            Random rnd = new Random ();
            string number = rnd.Next (1000, 9999).ToString ();
            HttpContext.Session.SetString("mobile",us.Phone);
           
            var qcheck = _db.Tbl_Users.Where (a => a.Phone == us.Phone).SingleOrDefault();


           
             if (qcheck == null) {
                Tbl_User user = new Tbl_User () {
                Phone = us.Phone,
                TokenPhone = number,
                NameFamily = us.NameFamily,

                };
                _db.Tbl_Users.Add (user);
                _db.SaveChanges ();
                

                var api = new KavenegarApi ("3871353043697339486A70384F544A4A574C74612B51432F4C7A4B305076645457396F5267456F7A5A34383D");
                api.VerifyLookup (us.Phone, number, "noeno");
                return RedirectToAction ("LoginCode","loginandregister2");
             }     
            

              else if(qcheck.Phone != us.Phone && qcheck.NameFamily== null) {
                qcheck.TokenPhone = number;
                _db.Tbl_Users.Update (qcheck);
                _db.SaveChanges ();

                var api = new KavenegarApi ("3871353043697339486A70384F544A4A574C74612B51432F4C7A4B305076645457396F5267456F7A5A34383D");
                api.VerifyLookup (us.Phone, number, "noeno");
                return RedirectToAction ("LoginCode", "loginandregister2");

            }else
            {
                return RedirectToAction ("loginpass", "loginandregister2");
            }

        }

              public IActionResult ReLogin () {


                         return View ();
                                              }

                 public IActionResult ReLoginCode () {


                         return View ();
                                              }

           public IActionResult Resendtoken (string a) {
            Random rnd = new Random ();
            string number = rnd.Next (1000, 9999).ToString ();
            // mobile = us.Phone;
            var qcheck = _db.Tbl_Users.Where (c => c.Phone == a).SingleOrDefault();


           
    
            
              
                qcheck.TokenPhone = number;
                _db.Tbl_Users.Update (qcheck);
                _db.SaveChanges ();

                var api = new KavenegarApi ("3871353043697339486A70384F544A4A574C74612B51432F4C7A4B305076645457396F5267456F7A5A34383D");
                api.VerifyLookup (a, number, "noeno");
                return RedirectToAction ("ReLoginCode","loginandregister2");
 

        }

           public IActionResult ReRegister () {

            if (msg != null)

            {

                ViewBag.msg = msg;
                msg = null;
            }

            return View ();

        }

            public IActionResult ReCheckCode (Vm_User us) {

            var Q = _db.Tbl_Users.Where (a => a.TokenPhone == us.TokenPhone && a.Phone == HttpContext.Session.GetString("mobile")).SingleOrDefault ();

            if (Q != null) {

                if (_db.Tbl_Users.Any (a => a.Phone == HttpContext.Session.GetString("mobile") && a.NameFamily != null)) {

                var claims = new List<Claim> () {
                new Claim (ClaimTypes.NameIdentifier, Q.Id.ToString ()),
                new Claim (ClaimTypes.Name, Q.NameFamily)
                    };

                    var identity = new ClaimsIdentity (claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal (identity);

                    var properties = new AuthenticationProperties {
                        IsPersistent = true
                    };

                    HttpContext.SignInAsync (principal, properties);

                    HttpContext.Session.SetString ("name", Q.NameFamily + "" + Q.NameFamily);

                    //   var qb = _db.Tbl_Users.Where (a =>  a.NameFamily != "" && a.Phone == mobile).SingleOrDefault ();
                    //   if (qb != null)
                    //   {
                    //        return RedirectToAction ("LoginCode", "LoginAndRegister");
                    //   }

                    return RedirectToAction ("ReRegister", "LoginAndRegister2");
                } 
            } else

            {

                msg = "کد وارد شده صحیح نمی باشد";

                return RedirectToAction ("ReLoginCode","loginandregister2");

            }
            return RedirectToAction ("ReLoginCode","loginandregister2");

        }

                public IActionResult ReAdd (Tbl_User Quser) {

            var q = _db.Tbl_Users.Where (a => a.Phone == HttpContext.Session.GetString("mobile")).SingleOrDefault ();
             if (Quser.Password != Quser.RPass)
            {
                 msg="رمز های وارد شده با هم مطابقت ندارند ";
               return RedirectToAction("ReRegister","loginandregister2");
            } else{
          
            q.Password = Quser.Password;
           

            _db.Tbl_Users.Update (q);
            _db.SaveChanges ();
            }
            // msg = " ثبت نام با موفقیت انجام شد لطفا اطلاعات کاربری خود را تکمیل فرمایید";

            var Q = _db.Tbl_Users.Where (a => a.Phone == HttpContext.Session.GetString("mobile")).SingleOrDefault ();
             var claims = new List<Claim> () {
                new Claim (ClaimTypes.NameIdentifier, Q.Id.ToString ()),
                new Claim (ClaimTypes.Name, Q.NameFamily)
                    };

                    var identity = new ClaimsIdentity (claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal (identity);

                    var properties = new AuthenticationProperties {
                        IsPersistent = true
                    };
                    HttpContext.SignInAsync (principal, properties);

                    HttpContext.Session.SetString ("name", Q.NameFamily );

            return RedirectToAction ("additionalinfo", "YourAccount2");
        }
            

    }

}