using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Internal;
using StajBlogProject.Models;
using StajBlogProject.ViewModels;

namespace StajBlogProject.Controllers
{
    public class AnimeController : Controller
    {
        private readonly IAnimeRepository _animeRepository;
        private readonly IHostingEnvironment _hostingEnvironment;

        public AnimeController(IAnimeRepository animeRepository,
            IHostingEnvironment hostingEnvironment)
        {
            _animeRepository = animeRepository;
            _hostingEnvironment = hostingEnvironment;
        }



        public IActionResult Index()
        {
            var model = _animeRepository.GetAllAnimes();
            return View(model);
        }


        public IActionResult Details(int id)
        {
            Anime anime = _animeRepository.GetAnime(id);
            if (anime == null)
            {
                return View("404Error");
            }

            return View(anime);
        }


        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AnimeCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Anime newAnime = new Anime
                {
                    Title = model.Title,
                    Summary = model.Summary,
                    ImageUrl = model.ImageUrl,
                    UploadDate = DateTime.Now,
                    Episodes = new List<AnimeEpisode>()
                };
                _animeRepository.AddAnime(newAnime);
                return RedirectToAction("Panel", "Account");
            }

            return View(model);
        }


        [Authorize]
        public IActionResult Delete(int id)
        {
            Anime anime = _animeRepository.GetAnime(id);
            if (anime == null)
            {
                return View("404Error");
            }

            _animeRepository.DeleteAnime(id);
            return RedirectToAction("Panel", "Account");
        }



        [Authorize]
        public IActionResult Edit(int id)
        {

            Anime anime = _animeRepository.GetAnime(id);

            if (anime == null)
                return View("404Error");

            AnimeEditViewModel model = new AnimeEditViewModel()
            {
                Id = anime.Id,
                Title = anime.Title,
                Summary = anime.Summary,
                ImageUrl = anime.ImageUrl
            };

            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AnimeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Anime anime = _animeRepository.GetAnime(model.Id);
                anime.Title = model.Title;
                anime.Summary = model.Summary;
                anime.ImageUrl = model.ImageUrl;
                _animeRepository.UpdateAnime(anime);
                return RedirectToAction("Panel","Account");
            }

            return View();
        }



        [Authorize]
        public IActionResult Episodes(int id)
        {
            var anime = _animeRepository.GetAnime(id);
            if (anime == null)
            {
                return View("404Error");
            }

            var panelEpisodesViewModel = new PanelEpisodesViewModel()
            {
                Anime = anime,
                AnimeEpisodes = _animeRepository.GetAnimeEpisodes(id)
            };
            return View(panelEpisodesViewModel);
        }


        [Authorize]
        public IActionResult CreateEpisode(int id)
        {
            Anime anime = _animeRepository.GetAnime(id);
            if (anime == null)
            {
                return View("404Error");
            }

            AnimeEpisodeCreateViewModel model = new AnimeEpisodeCreateViewModel();
            model.Anime = anime;
            var episodeList = _animeRepository.GetAnimeEpisodes(id);
            if (episodeList.Count() == 0)
            {
                model.EpisodeNo = 1;
            }
            else
            {
                model.EpisodeNo = episodeList.Max(e => e.EpisodeNo) + 1;
            }
            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateEpisode(int id, AnimeEpisodeCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                AnimeEpisode newEpisode = new AnimeEpisode()
                {
                    EpisodeNo = model.EpisodeNo,
                    AnimeId = id,
                    Title = model.Title,
                    Links = model.Alternative1 + "," 
                                               + model.Alternative2 + ","
                                               + model.Alternative3 + "," 
                                               + model.Alternative4 + ","
                                               + model.Alternative5

                };
                _animeRepository.AddEpisode(newEpisode);
                return RedirectToAction("Episodes",new {id = id});
            }

            return View(model);
        }


        [Authorize]
        public IActionResult EditEpisode(int id)
        {
            var animeEpisode = _animeRepository.GetEpisode(id);
            if (animeEpisode == null)
            {
                return View("404Error");
            }

            var strings = animeEpisode.Links.Split(",");

            var model = new EpisodeEditViewModel()
            {
                Id = animeEpisode.Id,
                Anime = _animeRepository.GetAnime(animeEpisode.AnimeId),
                Title = animeEpisode.Title,
                Alternative1 = strings[0],
                Alternative2 = strings[1],
                Alternative3 = strings[2],
                Alternative4 = strings[3],
                Alternative5 = strings[4],
            };
            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditEpisode(EpisodeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                AnimeEpisode episode = _animeRepository.GetEpisode(model.Id);
                episode.Title = model.Title;
                episode.Links = model.Alternative1 + ","
                                                   + model.Alternative2 + ","
                                                   + model.Alternative3 + ","
                                                   + model.Alternative4 + ","
                                                   + model.Alternative5;
                _animeRepository.UpdateEpisode(episode);
                return RedirectToAction("Episodes", new{id = episode.AnimeId});
            }

            return View();
        }



        [Authorize]
        public IActionResult DeleteEpisode(int id)
        {
            AnimeEpisode episode = _animeRepository.GetEpisode(id);
            if (episode == null)
            {
                return View("404Error");
            }

            _animeRepository.DeleteEpisode(id);
            return RedirectToAction("Episodes",new{id=episode.AnimeId});
        }


        public IActionResult Episode(int id)
        {
            AnimeEpisode episode = _animeRepository.GetEpisode(id);
            if (episode == null)
            {
                return View("404Error");
            }

            var orderedEpList = _animeRepository.GetAnimeEpisodes(episode.AnimeId).OrderBy(s => s.EpisodeNo);
            var current = orderedEpList.IndexOf(episode);
            var model = new EpisodeViewModel()
            {
                AnimeName = _animeRepository.GetAnime(episode.AnimeId).Title,
                Id = episode.Id,
                AnimeId = episode.AnimeId,
                EpNo = episode.EpisodeNo,
                Title = episode.Title,
                Links = episode.Links,
                PrevEpisode = orderedEpList.ElementAtOrDefault(current - 1),
                NextEpisode = orderedEpList.ElementAtOrDefault(current + 1)
            };
            return View(model);

        }

    }
}