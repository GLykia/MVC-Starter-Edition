using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace mvc_controller_1.Controllers
{
    public class JsonController : Controller
    {
        // GET: Json
        public JsonResult Index()
        {
            var urun = new List<Product>
            {
                new Product
                {
                    Name="Laptop",
                    UnitPrice=700,
                },
                new Product
                {
                    Name="Klavye",
                    UnitPrice=200,
                },
            };
            return Json(urun, "application/json", Encoding.UTF8, JsonRequestBehavior.AllowGet);
        }
        public class Product
        {
            public string Name { get; set; }
            public int UnitPrice { get; set; }
        }
        
    }
}