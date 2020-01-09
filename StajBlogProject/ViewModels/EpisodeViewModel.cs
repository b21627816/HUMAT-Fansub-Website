using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StajBlogProject.Models;

namespace StajBlogProject.ViewModels
{
    public class EpisodeViewModel
    {
        public int Id { get; set; }
        public string AnimeName { get; set; }

        public int AnimeId { get; set; }

        public int EpNo { get; set; }

        public string Title { get; set; }

        public string Links { get; set; }

        public AnimeEpisode PrevEpisode { get; set; }

        public AnimeEpisode NextEpisode { get; set; }
    }
}
