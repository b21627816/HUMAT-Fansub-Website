using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.FileProviders.Composite;
using Microsoft.Extensions.FileProviders.Internal;
using StajBlogProject.Models;
using StajBlogProject.ViewModels;

namespace StajBlogProject.Controllers
{
    public class MangaController : Controller
    {
        private readonly IMangaRepository _mangaRepository;
        private readonly IHostingEnvironment _hostingEnvironment;

        public MangaController(IMangaRepository mangaRepository,
            IHostingEnvironment hostingEnvironment)
        {
            _mangaRepository = mangaRepository;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View(_mangaRepository.GetAllMangas());
        }

        public IActionResult Details(int id)
        {
            Manga manga = _mangaRepository.GetManga(id);
            if (manga == null)
            {
                return View("404Error");
            }

            return View(manga);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MangaCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Manga newManga = new Manga
                {
                    Title = model.Title,
                    Summary = model.Summary,
                    ImageUrl = model.ImageUrl,
                    UploadDate = DateTime.Now,
                    Chapters = new List<MangaChapter>()
                };
                _mangaRepository.AddManga(newManga);
                return RedirectToAction("Panel", "Account");
            }

            return View(model);
        }

        [Authorize]
        public IActionResult Delete(int id)
        {
            Manga manga = _mangaRepository.GetManga(id);
            if (manga == null)
            {
                return View("404Error");
            }

            _mangaRepository.DeleteManga(id);
            return RedirectToAction("Panel", "Account");
        }


        [Authorize]
        public IActionResult Edit(int id)
        {

            Manga manga = _mangaRepository.GetManga(id);

            if (manga == null)
                return View("404Error");

            MangaEditViewModel model = new MangaEditViewModel()
            {
                Id = manga.Id,
                Title = manga.Title,
                Summary = manga.Summary,
                ImageUrl = manga.ImageUrl
            };

            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MangaEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Manga manga = _mangaRepository.GetManga(model.Id);
                manga.Title = model.Title;
                manga.Summary = model.Summary;
                manga.ImageUrl = model.ImageUrl;
                _mangaRepository.UpdateManga(manga);
                return RedirectToAction("Panel", "Account");
            }

            return View();
        }


        [Authorize]
        public IActionResult Chapters(int id)
        {
            var manga = _mangaRepository.GetManga(id);
            if (manga == null)
            {
                return View("404Error");
            }

            var panelChaptersViewModel = new PanelChaptersViewModel()
            {
                Manga = manga,
                Chapters = _mangaRepository.GetAllChapters(id)
            };
            return View(panelChaptersViewModel);
        }

        [Authorize]
        public IActionResult DeleteChapter(int id)
        {
            MangaChapter chapter = _mangaRepository.GetChapter(id);
            if (chapter == null)
            {
                return View("404Error");
            }

            _mangaRepository.DeleteChapter(id);
            return RedirectToAction("Chapters", new { id = chapter.MangaId });
        }



        [Authorize]
        public IActionResult CreateChapter(int id)
        {
            Manga manga = _mangaRepository.GetManga(id);
            if (manga == null)
            {
                return View("404Error");
            }

            MangaChapterCreateViewModel model = new MangaChapterCreateViewModel();
            model.Manga = manga;
            var chapterList = _mangaRepository.GetAllChapters(id);

            if (chapterList.Count() == 0)
            {
                model.ChapterNo = 1;
            }
            else
            {
                model.ChapterNo = chapterList.Max(c => c.ChapterNo) + 1;
            }

            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateChapter(int id, MangaChapterCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Files != null && model.Files.Count > 0)
                {
                    foreach (IFormFile file in model.Files)
                    {
                        string uploadsFolder =
                            Path.Combine(_hostingEnvironment.WebRootPath, "Mangas");
                        string filePath = 
                            Path.Combine(uploadsFolder, 
                                id.ToString(), 
                                model.ChapterNo.ToString());
                        if (!Directory.Exists(filePath))
                        {
                            Directory.CreateDirectory(filePath);
                        }

                        string fullPath =
                            Path.Combine(filePath, file.FileName);
                        file.CopyTo(new FileStream(fullPath, FileMode.Create));
                    }
                }

                MangaChapter newChapter = new MangaChapter()
                {
                    ChapterNo = model.ChapterNo,
                    MangaId = id,
                    Title = model.Title,
                    ChFolder = 
                        Path.Combine(_hostingEnvironment.WebRootPath, 
                            "Mangas",
                        id.ToString(), 
                        model.ChapterNo.ToString())
                };
                _mangaRepository.AddChapter(newChapter);
                return RedirectToAction("Chapters", new { id = id });
            }

            return View(model);
        }


        public IActionResult Chapter(int id)
        {
            MangaChapter chapter = _mangaRepository.GetChapter(id);
            if (chapter == null)
            {
                return View("404Error");
            }
            
            var orderedChList = _mangaRepository.GetAllChapters(chapter.MangaId).OrderBy(s => s.ChapterNo);
            var current = orderedChList.IndexOf(chapter);
            Manga manga = _mangaRepository.GetManga(chapter.MangaId);
            var model = new ChapterViewModel()
            {
                Manga = manga,
                Id = chapter.Id,
                ChNo = chapter.ChapterNo,
                Title = chapter.Title,
                PrevCh = orderedChList.ElementAtOrDefault(current - 1),
                NextCh = orderedChList.ElementAtOrDefault(current + 1),
                Contents = _hostingEnvironment.WebRootFileProvider.GetDirectoryContents("/Mangas/"+manga.Id +"/" + chapter.ChapterNo)
            };
            return View(model);

        }


    }
}