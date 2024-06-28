using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Blogs.Take(4).ToList();
            return View(values);
        }
        public ActionResult About()
        {

            return View();
        }

        public PartialViewResult Partial1()
        {
            var value = c.Blogs.Take(10).ToList();
            return PartialView(value);
        }
        public PartialViewResult Partial2()
        {
            var value = c.Blogs.Take(3).ToList();
            return PartialView(value);
        }
        public PartialViewResult Partial3()
        {
            var value = c.Blogs.OrderByDescending(x=> x.Id).Take(3).ToList();
            return PartialView(value);
        }
    }
}

