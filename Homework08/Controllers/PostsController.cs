using Homework08.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework08.Controllers
{
    public class PostsController : Controller
    {
        // GET: Posts
        public ActionResult Index()
        {
            //list to display something
            List<PostViewModel> list = new List<PostViewModel>();
            PostViewModel post = new PostViewModel()
            {
                Id = 1,
                UserId = 1,
                Priority = 1,
                IsSticky = true,
                Message = "This is the first post",
                Type = PostType.Photo,
                TimeOfPosting = DateTime.Now
            };
            list.Add(post);
            PostViewModel post2 = new PostViewModel()
            {
                Id = 1,
                UserId = 1,
                Priority = 1,
                IsSticky = true,
                Message = "This is another post",
                Type = PostType.Photo,
                TimeOfPosting = DateTime.Now
            };
            list.Add(post2);

            return View("Index", list);
        }

        public ActionResult Details(PostViewModel post)
        {
            return View("Details", post);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PostViewModel post)
        {
            if (post.Message == null || post.Equals(""))
            {
                return HttpNotFound();
            }
            else
            {
                return RedirectToAction("Details", post);
            }
        }    
        
        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(PostViewModel post)
        {
            return RedirectToAction("Details", post);
        }
    }
}