using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Entities;
using TravelTripProject.Controllers;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        Context context= new Context();
        BlogComment bc = new BlogComment();
        public ActionResult Index()
        {
            bc.values1=context.Blogs.ToList();
            bc.values3=context.Blogs.Take(3).ToList();
            return View(bc);
        }
        public ActionResult BlogDetail(int id)
        {
            bc.values1 = context.Blogs.Where(x => x.BlogId == id).ToList();
            bc.values2=context.Comments.Where(x=>x.BlogId==id).ToList();
            return View(bc);
        }
        [HttpGet]
        public PartialViewResult BlogComment(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult BlogComment(Comment comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();
            return PartialView();
        }
    }
}