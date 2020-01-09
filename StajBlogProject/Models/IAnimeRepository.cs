using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace StajBlogProject.Models
{
    public interface IAnimeRepository
    {
        IEnumerable<Anime> GetAllAnimes();
        IEnumerable<AnimeEpisode> GetAnimeEpisodes(int id);
        Anime GetAnime(int id);
        AnimeEpisode GetEpisode(int id);
        Anime AddAnime(Anime anime);
        AnimeEpisode AddEpisode(AnimeEpisode episode);
        AnimeEpisode UpdateEpisode(AnimeEpisode changedEpisode);
        Anime UpdateAnime(Anime changedAnime);
        Anime DeleteAnime(int id);
        AnimeEpisode DeleteEpisode(int id);
        
    }
}
