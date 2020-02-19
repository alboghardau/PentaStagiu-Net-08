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
            List<PostViewModel> list = new List<PostViewModel>();
            PostViewModel post = new PostViewModel()
            {
                Id = 1,
                UserId = 1,
                Priority = 1,
                IsSticky = true,
                Message = " Bla bla ",
                Type = PostType.Photo,
                TimeOfPosting = DateTime.Now
            };
            list.Add(post);

            return View("Index", list);
        }

        public ActionResult Details()
        {
            PostViewModel post = new PostViewModel()
            {
                Id = 1,
                UserId = 1,
                Priority = 1,
                IsSticky = true,
                Message = " Bla bla ",
                Type = PostType.Photo,
                TimeOfPosting = DateTime.Now
            };

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
                return View();
            }
            else
            {
                return View("Datails", post);
            }
        }

        
    }
}