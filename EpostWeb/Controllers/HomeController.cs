using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace EpostWeb.Controllers
{
    public class HomeController : Controller
    {
        HttpCookie cookie = new HttpCookie("Language");
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Category()
        {
            return View();
        }
        public ActionResult Detail()
        {
            return View();
        }
        public ActionResult ShoppingCart()
        {
            return View();
        }
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult Signin()
        {
            return View();
        }
        public ActionResult WishList()
        {
            return View();
        }
        public ActionResult ProductComparison()
        {
            return View();
        }
        public ActionResult FAQ()
        {
            return View();
        }
        public ActionResult NotFound()
        {
            return View();
        }
        public ActionResult MyAccount()
        {
            return View();
        }
        public ActionResult MyAddress()
        {
            return View();
        }
        public ActionResult MyPaymentMethod()
        {
            return View();
        }

        public ActionResult Change(string LanguageAbbrevation)
        {
            if (LanguageAbbrevation != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(LanguageAbbrevation);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(LanguageAbbrevation);
            }

            cookie.Value = LanguageAbbrevation;
            Response.Cookies.Add(cookie);

            string url = this.Request.UrlReferrer.AbsolutePath;

            return Redirect(url);
        }
    }
}