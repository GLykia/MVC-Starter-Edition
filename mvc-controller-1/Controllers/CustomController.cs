using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_controller_1.Controllers
{
    public class CustomController : Controller
    {
        // GET: Custom
        public ActionResult Index()
        {
            return new CustomResult();
        }
        public class CustomResult:ActionResult
        {
            public override void ExecuteResult(ControllerContext context)
            {
                context.HttpContext.Response.Write("Benim çıktım");
            }
        }

        //public class XmlResult: ActionResult
        //{
        //    private readonly object _data;
        //    public XmlResult(object data)
        //    {
        //        _data = data;
        //    }
            
        //}
    }
}