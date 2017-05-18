using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hijr.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Models.HijrViewModel hijrviewmodel = new Models.HijrViewModel();
            //using (HijrDataLayer.HIJREntities ent = new HijrDataLayer.HIJREntities())
            //{

            //    var k = from a in ent.RefKursusPerdanas
            //            select a;

            //    foreach(var b in k)
            //    {
            //        Models.Kursus x = new Models.Kursus();
            //        x.
            //    }
            //}

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
    }
}