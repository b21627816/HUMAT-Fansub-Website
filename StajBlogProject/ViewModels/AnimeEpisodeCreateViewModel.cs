using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using StajBlogProject.Models;

namespace StajBlogProject.ViewModels
{
    public class AnimeEpisodeCreateViewModel
    {
        public Anime Anime { get; set; }

        [Required]
        public int EpisodeNo { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Alternative1 { get; set; }

        public string Alternative2 { get; set; }

        public string Alternative3 { get; set; }

        public string Alternative4 { get; set; }

        public string Alternative5 { get; set; }


    }
}
