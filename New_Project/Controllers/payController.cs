using System.Data;
using System.Data.Common;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using DataLayer.Context;
using Dto.Payment;
using New_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using ZarinPal.Class;
using DataLayer.AdminEntities.wallet;
using Microsoft.AspNetCore.Http;
using ViewModel.Entities.User;

namespace New_Project.Controllers
{


    public class PayController : Controller
    {
        private readonly Payment _payment;
        private readonly Authority _authority;
        private readonly Transactions _transactions;
        public static string msg;
        private readonly Context_db db;
        public static int sumshop;

        public PayController(Context_db _db)
        {
            var expose = new Expose();
            _payment = expose.CreatePayment();
            _authority = expose.CreateAuthority();
            _transactions = expose.CreateTransactions();
            db = _db;
        }
        public IActionResult Index(int id)
        {
            if (msg != null)
            {
                ViewBag.msg = msg;
                msg = null;
            }
            var quser = db.Tbl_Users.Where(a => a.Id.ToString() == (User.Identity.GetId())).SingleOrDefault();
            Tbl_pay A = new Tbl_pay()
            {
                iduser = Convert.ToInt32(User.Identity.GetId()),
                Pay = id,
                Paytime = DateTime.UtcNow,
                NameFamily = quser.NameFamily,
                Phone = quser.Phone

            };
            db.tbl_Pays.Add(A);
            db.SaveChanges();


            return RedirectToAction("Request");


        }
        //////////////////////////////////////////////////////////////////فرایند خرید

        public async Task<IActionResult> Request()
        {

            var quser = db.Tbl_Users.Where(a => a.Id.ToString() == (User.Identity.GetId())).SingleOrDefault();
            var qpay = db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId())).OrderByDescending(a => a.Id).Take(1).SingleOrDefault();
            sumshop = qpay.Pay;
            var result = await _payment.Request(new DtoRequest()
            {
                Mobile = quser.Phone,
                CallbackUrl = "https://localhost:5001/pay/validate",
                Description = quser.NameFamily,
                Email = "tak1.ghasemi@gmail.com",
                Amount = qpay.Pay,
                MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX"
            }, ZarinPal.Class.Payment.Mode.sandbox);
            return Redirect($"https://sandbox.zarinpal.com/pg/StartPay/{result.Authority}");
        }


        ///////////////////////////////////////////////////اعتبار سنجی

        public async Task<IActionResult> Validate(string authority, string status)
        {
            string pays = status;
            var verification = await _payment.Verification(new DtoVerification
            {
                Amount = sumshop,
                MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                Authority = authority
            }, Payment.Mode.zarinpal);

            if (pays == "OK")
            {



                var q = db.tbl_Pays.OrderByDescending(a => a.Id).Take(1).SingleOrDefault();
                q.status = true;
                db.tbl_Pays.Update(q);
                db.SaveChanges();
                msg = "پرداخت با موفقیت انجام شد";
                if (HttpContext.Session.GetString("payred") == "1")
                {
                    HttpContext.Session.SetString("pay", Diposit().ToString());
                    return RedirectToAction("AccountMe", "YourAccount");
                }


                return RedirectToAction("AccountMe", "YourAccount");

            }
            else

            {
                var q = db.tbl_Pays.OrderByDescending(a => a.Id).Take(1).SingleOrDefault();
                q.status = false;
                db.tbl_Pays.Update(q);
                db.SaveChanges();
                msg = "پرداخت نا موفق بوده است ";
                if (HttpContext.Session.GetString("payred") == "1")
                {
                    return RedirectToAction("AccountMe", "YourAccount");
                }


                return RedirectToAction("AccountMe", "YourAccount");

            }

        }



        public IActionResult pay()
        {

            if (msg != null)
            {

                ViewBag.msg = msg;
                msg = null;
            }

            HttpContext.Session.SetString("pay", Diposit().ToString());

            return RedirectToAction("AccountMe", "YourAccount");
        }



        public int Diposit()
        {
            int pay = db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId()) && a.status == true).Sum(a => a.Pay);
            int horvest = db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId())).Sum(a => a.Harvest);
            return pay - horvest;

        }



        public IActionResult payUser(Vm_User A)
        {

            var q = db.Tbl_Users.Where(a => a.Id.ToString() == (User.Identity.GetId())).SingleOrDefault();
            if (q != null)
            {
                if (Convert.ToInt32(HttpContext.Session.GetString("pay")) >= Convert.ToInt32(A.Price))
                {
                    Tbl_pay B = new Tbl_pay()
                    {
                        Phone = q.Phone,
                        Harvest = Convert.ToInt32(A.Price),
                        havesttime = DateTime.UtcNow,
                        iduser = Convert.ToInt32(User.Identity.GetId()),
                        Paytime = DateTime.UtcNow,
                        NameFamily = q.NameFamily,
                        StatusP="T",


                    };

                    db.tbl_Pays.Add(B);
                    db.SaveChanges();

                    HttpContext.Session.SetString("pay", Diposit().ToString());
                    string b = Diposit().ToString();
                }
                else
                {
                    HttpContext.Session.SetString("pay", Diposit().ToString());
                    msg = "اعتبار شما کافی نیست لطفا کیف پول خود را شارژ کنید";


                }
            }


            return RedirectToAction("AccountMe", "YourAccount");
        }
        ///////////////////////////////////////////////////


        public IActionResult Index2(int id)
        {
            if (msg != null)
            {
                ViewBag.msg = msg;
                msg = null;
            }
            var quser = db.Tbl_Users.Where(a => a.Id.ToString() == (User.Identity.GetId())).SingleOrDefault();
            Tbl_pay A = new Tbl_pay()
            {
                iduser = Convert.ToInt32(User.Identity.GetId()),
                Pay = id,
                Paytime = DateTime.UtcNow,
                NameFamily = quser.NameFamily,
                Phone = quser.Phone

            };
            db.tbl_Pays.Add(A);
            db.SaveChanges();


            return RedirectToAction("Request2");


        }
        //////////////////////////////////////////////////////////////////فرایند خرید

        public async Task<IActionResult> Request2()
        {

            var quser = db.Tbl_Users.Where(a => a.Id.ToString() == (User.Identity.GetId())).SingleOrDefault();
            var qpay = db.tbl_Pays.Where(a => a.iduser == Convert.ToInt32(User.Identity.GetId())).OrderByDescending(a => a.Id).Take(1).SingleOrDefault();
            sumshop = qpay.Pay;
            var result = await _payment.Request(new DtoRequest()
            {
                Mobile = quser.Phone,
                CallbackUrl = "https://localhost:5001/pay/validate2",
                Description = quser.NameFamily,
                Email = "tak1.ghasemi@gmail.com",
                Amount = qpay.Pay,
                MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX"
            }, ZarinPal.Class.Payment.Mode.sandbox);
            return Redirect($"https://sandbox.zarinpal.com/pg/StartPay/{result.Authority}");
        }


        ///////////////////////////////////////////////////اعتبار سنجی

        public async Task<IActionResult> Validate2(string authority, string status)
        {
            string pays = status;
            var verification = await _payment.Verification(new DtoVerification
            {
                Amount = sumshop,
                MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                Authority = authority
            }, Payment.Mode.zarinpal);

            if (pays == "OK")
            {



                var q = db.tbl_Pays.OrderByDescending(a => a.Id).Take(1).SingleOrDefault();
                q.status = true;
                db.tbl_Pays.Update(q);
                db.SaveChanges();
                msg = "پرداخت با موفقیت انجام شد";
                if (HttpContext.Session.GetString("payred") == "1")
                {
                    HttpContext.Session.SetString("pay", Diposit().ToString());
                    return RedirectToAction("card2", "cart");
                }


                return RedirectToAction("card2", "cart");

            }
            else

            {
                var q = db.tbl_Pays.OrderByDescending(a => a.Id).Take(1).SingleOrDefault();
                q.status = false;
                db.tbl_Pays.Update(q);
                db.SaveChanges();
                msg = "پرداخت نا موفق بوده است ";
                if (HttpContext.Session.GetString("payred") == "1")
                {
                    return RedirectToAction("card2", "cart");
                }


                return RedirectToAction("card2", "cart");

            }

        }

























    }
}