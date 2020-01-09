using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StajBlogProject.Models;
using StajBlogProject.ViewModels;

namespace StajBlogProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IPostRepository _postRepository;
        private readonly IMangaRepository _mangaRepository;
        private readonly IAnimeRepository _animeRepository;

        public AccountController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IPostRepository postRepository,
            IMangaRepository mangaRepository,
            IAnimeRepository animeRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _postRepository = postRepository;
            _mangaRepository = mangaRepository;
            _animeRepository = animeRepository;
        }


        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {

            if (ModelState.IsValid)
            {
                var result = await _signInManager
                    .PasswordSignInAsync
                    (
                        model.Email,
                        model.Password,
                        model.RememberMe,
                        false
                    );

                if (result.Succeeded)
                {

                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Blog");
                    }

                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }

            return View(model);
        }



        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Blog");
        }

        [Authorize]
        public IActionResult Panel()
        {
            var model = new PanelViewModel()
            {
                Posts = _postRepository.getAllPosts(),
                Animes = _animeRepository.GetAllAnimes(),
                Mangas = _mangaRepository.GetAllMangas(),
            };
            return View(model);
        }
    }
}