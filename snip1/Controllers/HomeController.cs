using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Driver;

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
        [HttpPost]
        public ActionResult Create(Snips snip)
        {
            var mongoClient = new MongoClient();
            var db = mongoClient.GetDatabase("snippets");
            var snippetCollection = db.GetCollection<Snips>("snippets");
            snippetCollection.InsertOne(snip);
            return Redirect("/Home/Create");
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