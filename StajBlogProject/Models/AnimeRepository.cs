using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace StajBlogProject.Models
{
    public class AnimeRepository:IAnimeRepository
    {
        private readonly AppDbContext _context;

        public AnimeRepository(AppDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Anime> GetAllAnimes()
        {
            return _context.Animes.ToList();
        }

        public IEnumerable<AnimeEpisode> GetAnimeEpisodes(int id)
        {
            var animeEpisodes = _context.AnimeEpisodes.Where(i => i.AnimeId == id);
            return animeEpisodes;
        }

        public Anime GetAnime(int id)
        {
            return _context.Animes.Find(id);
        }

        public AnimeEpisode GetEpisode(int id)
        {
            return _context.AnimeEpisodes.Find(id);
        }

        public Anime AddAnime(Anime anime)
        {
            _context.Animes.Add(anime);
            _context.SaveChanges();
            return anime;
        }

        public AnimeEpisode AddEpisode(AnimeEpisode episode)
        {
            _context.AnimeEpisodes.Add(episode);
            Anime anime = _context.Animes.Find(episode.AnimeId);
            anime.Episodes.Add(episode);
            _context.SaveChanges();
            return episode;
        }

        public AnimeEpisode UpdateEpisode(AnimeEpisode changedEpisode)
        {
            var episode = _context.AnimeEpisodes.Attach(changedEpisode);
            episode.State = EntityState.Modified;
            _context.SaveChanges();
            return changedEpisode;
        }

        public Anime UpdateAnime(Anime changedAnime)
        {
            var anime = _context.Animes.Attach(changedAnime);
            anime.State = EntityState.Modified;
            _context.SaveChanges();
            return changedAnime;
        }

        public Anime DeleteAnime(int id)
        {
            Anime anime = _context.Animes.Find(id);
            if (anime != null)
            {
                _context.Animes.Remove(anime);
                _context.SaveChanges();
            }

            return anime;
        }

        public AnimeEpisode DeleteEpisode(int id)
        {
            AnimeEpisode episode = _context.AnimeEpisodes.Find(id);
            if (episode != null)
            {
                _context.AnimeEpisodes.Remove(episode);
                _context.SaveChanges();
            }

            return episode;
        }
    }
}
