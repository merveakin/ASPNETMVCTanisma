using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVCTanisma.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Deneme()
        {
            //ViewBag nedir
            ViewBag.Ad = "Betül";
            //ViewData
            ViewData["Ad"]= "Ali";
            //ViewData ile ViewBag birbirinin aynısıdır
            //Sadece yazımları farklı
            //Ekranda ViewBag Ad içinde Ali'yi göreceğiz
            //Betül'ü göremiyoruz. Çünkü 35. satırda ViewBag,'in taşıdığı Ad değişkeni yeniden set edilmiştir.
            ViewData["Soyad"] = "Akşan";
            //TempData
            TempData["Adiniz"]= "Betül";

            return View();
        }
    }
}