using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SE_Asp_Net_Ajax.Models;

namespace SE_Asp_Net_Ajax.Controllers
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

        public JsonResult JsonSearch(string name)
        {
            string [] jsondata = { "first", "second", "third"};
            return Json(jsondata, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Authorize]
        public JsonResult JsonPost(string name)
        {
            string[] jsondata = { "first", "second", "third" , name};
            return Json(jsondata, JsonRequestBehavior.AllowGet);
        }

    }
}