using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajBlogProject.Models
{
    public class AnimeEpisode
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Links { get; set; }

        public int AnimeId { get; set; }

        public int EpisodeNo { get; set; }
    }
}
