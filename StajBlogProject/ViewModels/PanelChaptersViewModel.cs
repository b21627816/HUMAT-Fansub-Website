using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StajBlogProject.Models;

namespace StajBlogProject.ViewModels
{
    public class PanelChaptersViewModel
    {
        public Manga Manga { get; set; }
        public IEnumerable<MangaChapter> Chapters { get; set; }
    }
}
