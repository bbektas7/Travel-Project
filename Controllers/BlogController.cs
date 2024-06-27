using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;
namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogComment bc = new BlogComment();
        public ActionResult Index()
        {
            //var blogs = c.Blogs.ToList();
            bc.Value1 = c.Blogs.ToList();
            bc.Value3 = c.Blogs.OrderByDescending(x => x.Id).Take(3).ToList();
            return View(bc);
        }
        public ActionResult BlogDetail(int id)
        {
            //var findblog = c.Blogs.Where(x => x.Id == id).ToList();
            bc.Value1 = c.Blogs.Where(x => x.Id == id).ToList();
            bc.Value2 = c.Commentss.Where(x => x.Blogid == id).ToList();
            return View(bc);
        }
    }
}