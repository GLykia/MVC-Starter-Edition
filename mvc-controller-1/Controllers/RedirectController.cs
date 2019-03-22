using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mvc_controller_1.Controllers
{
    public class RedirectController : Controller
    {
        // GET: Redirect
        public ActionResult Index()
        {
            return View();
        }

        public RedirectResult Index2()
        {
            return Redirect("http://google.com");
        }

        public RedirectToRouteResult Index3()
        {
            //return RedirectToAction("Index");
            //return RedirectToAction("Index", "Home");
            //return RedirectToAction("Default", new { controller = "View", action="Index2" });
            //return RedirectToAction("Index", new RouteValueDictionary()
            //{
            //    {"controller","View" },
            //    {"Id","6" }
            //});

            return RedirectToRoute("Default", new { controller = "View", action = "Index2" });
        }
    }
    
}