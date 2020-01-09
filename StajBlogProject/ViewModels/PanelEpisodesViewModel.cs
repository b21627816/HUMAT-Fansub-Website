using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StajBlogProject.Models;

namespace StajBlogProject.ViewModels
{
    public class PanelEpisodesViewModel
    {

        public Anime Anime { get; set; }

        public IEnumerable<AnimeEpisode> AnimeEpisodes { get; set; }

    }
}
