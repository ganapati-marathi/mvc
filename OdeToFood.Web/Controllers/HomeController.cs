using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class HomeController : Controller
    {

        IRestarauntData db;
        // constructor;
        public HomeController()
        {
            db = new InMemoryRestarauntData();
        }
        public ActionResult Index()
        {
            // get the db model from the inmemory
            var model = db.GetAll();

            //pass it to the view 
            return View(model);
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