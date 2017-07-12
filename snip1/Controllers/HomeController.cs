using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace snip1.Controllers
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
        public ActionResult Create()
        {
            ViewBag.Message = "This is our CREATE page.";

            return View();
        }
        public ActionResult Read()
        {
            ViewBag.Message = "This is our READ page.";

            return View();
        }
        public ActionResult Update()
        {
            ViewBag.Message = "This is our UPDATE page.";

            return View();
        }
    }
    
}