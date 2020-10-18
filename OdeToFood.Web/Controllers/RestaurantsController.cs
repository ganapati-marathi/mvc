using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IRestarauntData db;

        public RestaurantsController(IRestarauntData db)
        {
            this.db = db;
        }

        // GET: Restaurants
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }
        public ActionResult Details(int id)
        {

            var model = db.Get(id);
            if(model == null)
            {
                // redirecting
                //return RedirectToAction("Index");
                // even can render a view here
                // return view("name of the view to be rendered")
                return View("NotFound");
            }
            return View(model);


        }
    }
}