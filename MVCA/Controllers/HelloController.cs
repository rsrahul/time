using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCA.Controllers
{
    public class HelloController : Controller
    {
        //
        // GET: /Hello/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult rahul()
        {
            ViewBag.Message = "Hi Rahul";

            return View();
        }
	}
}