using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Entities;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        Context context=new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = context.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id)
        {
            var blog = context.Blogs.Find(id);
            context.Blogs.Remove(blog);
            context.SaveChanges();
            return RedirectToAction("Index");   
        }
        public ActionResult GetBlog(int id)
        {
            var bl=context.Blogs.Find(id);
            return View("GetBlog",bl);
        }
        public ActionResult UpdateBlog(Blog blog)
        {
            var blg = context.Blogs.Find(blog.BlogId);
            blg.Description = blog.Description;
            blg.Title = blog.Title;
            blg.Tarih = blog.Tarih;
            blg.BlogWrite = blog.BlogWrite;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CommentList()
        {
            var comment = context.Comments.ToList();
            return View(comment);
        }
        public ActionResult DeleteComment(int id)
        {
            var blog = context.Comments.Find(id);
            context.Comments.Remove(blog);
            context.SaveChanges();
            return RedirectToAction("CommentList");
        }
        public ActionResult GetComment(int id)
        {
            var yr = context.Comments.Find(id);
            return View("GetComment",yr);
        }
        public ActionResult UpdateComment(Comment comment)
        {
            var cmt = context.Comments.Find(comment.CommentId);
            cmt.UserName = comment.UserName;
            cmt.Mail = comment.Mail;
            cmt.Comments = comment.Comments;
            context.SaveChanges();
            return RedirectToAction("CommentList");
        }
    }
}