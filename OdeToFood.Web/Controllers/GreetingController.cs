using OdeToFood.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            // the name will be passed into the request query string;
            var model = new GreetingViewModel();

            // route should be
            // greetind?name=gana

            model.Name = name ?? "No name"; // acts as ternary operator;
            model.Message = ConfigurationManager.AppSettings["message"];
            return View(model);
        }
    }
}