using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StajBlogProject.Models;

namespace StajBlogProject.ViewModels
{
    public class PanelViewModel
    {

        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Anime> Animes { get; set; }
        public IEnumerable<Manga> Mangas { get; set; }

    }
}
