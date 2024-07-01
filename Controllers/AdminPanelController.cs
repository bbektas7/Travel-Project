using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models;
using TravelTripProject.Models.Classes;
namespace TravelTripProject.Controllers
{
    public class AdminPanelController : Controller
    {
        // GET: AdminPanel
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        [HttpGet]// sayfayı yükleyince bir şey yapma boş halini döndür.
        public ActionResult NewBlog()
        {
            return View();
        }
        [HttpPost]// sayfasa bir sey gönderdiğimde burdaki işlemleri gönder.
        public ActionResult NewBlog(Blog p)
        {
            c.Blogs.Add(p);// P ler İnternette Sayfasında girdiğimiz inputtan geliyor
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id) 
        { 
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BringBlog(int id)
        {
            var b1 = c.Blogs.Find(id);
            return View("BringBlog",b1);
        }
        public ActionResult UpdateBlog(Blog b)
        {
            var blg = c.Blogs.Find(b.Id);
            blg.Explanation = b.Explanation;
            blg.Title = b.Title;
            blg.Date = b.Date;
            blg.BlogImage = b.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CommentList()
        {
            var comments = c.Commentss.ToList();
            return View(comments);
        }
        public ActionResult DeleteComment(int id)
        {
            var b = c.Commentss.Find(id);
            c.Commentss.Remove(b);
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
        public ActionResult BringComment(int id)
        {
            var cm = c.Blogs.Find(id);
            return View("BringComment", cm);
        }
        public ActionResult UpdateComment(Comments y)
        {
            var cmt = c.Commentss.Find(y.Id);
            cmt.User = y.User;
            cmt.Email = y.Email;
            cmt.comment = y.comment ;
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
    }
}