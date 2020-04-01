using Homework08.Helper;
using Homework08.Models;
using PostLibrary.Interfaces;
using PostLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework08.Controllers
{
    public class PostsController : Controller
    {
        private IPostService _postService;
        List<PostViewModel> list; 

        public PostsController()
        {
            _postService = new PostService();
            this.list = _postService.GetPosts()
                .Select(x => ModelConvertor.ModelToViewModel(x))
                .ToList();
        }

        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            return View(this.list);
        }

        //completed
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View("Details", ModelConvertor.ModelToViewModel(_postService.Get(id)));
        }

        //completed
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //completed
        [HttpPost]
        public ActionResult Create(PostViewModel post)
        {
            if (post.Message == null || post.Equals(""))
            {
                return HttpNotFound();
            }
            else
            {
                _postService.Add(ModelConvertor.ViewModelToModel(post));
                return RedirectToAction("Index");
            }
        }

        //completed
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View("Edit", ModelConvertor.ModelToViewModel(_postService.Get(id)));
        }

        [HttpPost]
        public ActionResult Edit(PostViewModel post)
        {
            if (ModelState.IsValid)
            {
                _postService.Edit(ModelConvertor.ViewModelToModel(post));
                return RedirectToAction("Details", post);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Delete(PostViewModel post)
        {
            _postService.Delete(post.Id);
            return RedirectToAction("Index");
        }
    }
}