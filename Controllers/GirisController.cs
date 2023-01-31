using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TraversalTrimProject.Models.Siniflar;

namespace TraversalTrimProject.Controllers
{
    public class GirisController : Controller
    {
        // GET: Giris
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin a)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.KullaniciAdi == a.KullaniciAdi && x.Sifre == a.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KullaniciAdi, false);
                Session["Kullanici"] = bilgiler.KullaniciAdi.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

    }
}