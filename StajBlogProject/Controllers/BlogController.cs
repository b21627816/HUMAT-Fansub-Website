using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using StajBlogProject.Models;
using StajBlogProject.ViewModels;

namespace StajBlogProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly IHostingEnvironment _hostingEnvironment;

        public BlogController(IPostRepository postRepository,
                                IHostingEnvironment hostingEnvironment)
        {
            _postRepository = postRepository;
            _hostingEnvironment = hostingEnvironment;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var model = _postRepository.getAllPosts();
            return View(model);
        }

        public IActionResult Details(int id)
        {

            Post post = _postRepository.getPost(id);

            if (post == null)
            {
                return View("404Error");
            }

            return View(post);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PostCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Post newPost = new Post
                {
                    Title = model.Title,
                    Text = model.Text,
                    TextOnly = model.TextOnly,
                    ImageUrl = model.ImageUrl,
                    PostDate = DateTime.Now
                };
                _postRepository.addPost(newPost);
                return RedirectToAction("Panel", "Account");
            }

            return View(model);
        }

        [Authorize]
        public IActionResult Edit(int id)
        {

            Post post = _postRepository.getPost(id);

            if (post == null)
                return View("404Error");

            PostEditViewModel model = new PostEditViewModel()
            {
                Id = post.Id,
                Title = post.Title,
                TextOnly = post.TextOnly,
                Text = post.Text,
                ImageUrl = post.ImageUrl
            };

            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PostEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Post post = _postRepository.getPost(model.Id);
                post.Title = model.Title;
                post.Text = model.Text;
                post.ImageUrl = model.ImageUrl;
                post.TextOnly = model.TextOnly;
                _postRepository.updatePost(post);
                return RedirectToAction("Panel", "Account");
            }

            return View();
        }

        [Authorize]
        public IActionResult Delete(int id)
        {
            Post post = _postRepository.getPost(id);
            if (post == null)
            {
                return View("404Error");
            }

            _postRepository.deletePost(id);
            return RedirectToAction("Index");
        }


    }
}