using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Windows;

namespace Jquery_ornekler.Controllers
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

        public ActionResult DosyaYukleme()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DosyaYukleme(IEnumerable<HttpPostedFileBase> dosyalar)
        {
            foreach (var dosya in dosyalar)
            {
                if (dosya != null)
                {
                    string dosya_yolu = Path.GetFileName(dosya.FileName);
                    var yuklenecek_yer = Path.Combine(Server.MapPath("~/Dosyalar"), dosya_yolu);
                    dosya.SaveAs(yuklenecek_yer);
                }    
            }
            return View();
        }
    }
}