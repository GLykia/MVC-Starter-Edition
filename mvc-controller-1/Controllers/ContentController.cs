using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace mvc_controller_1.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        public ActionResult Index()
        {
            return View();
        }

        public ContentResult Index2()
        {
            //return Content("SmartPro", "text/html", Encoding.UTF8);
            return Content("Hellooo");
        }

        public ContentResult Index3()
        {
            return Content("<div> Merhaba </div>","text/plain");

        }
        
        public ContentResult Index4()
        {
            var xml = "<product>" + "<Product> <name> Laptop </name></Product>" + "<Product> <name> PC </name></Product>" + "</product>";
            return Content(xml, "application/xml");
        }
    }
}