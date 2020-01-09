using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.FileProviders;
using StajBlogProject.Models;

namespace StajBlogProject.ViewModels
{
    public class ChapterViewModel
    {
        public Manga Manga { get; set; }
        public int Id { get; set; }

        public int ChNo { get; set; }

        public string Title { get; set; }

        public IDirectoryContents Contents { get; set; }

        public MangaChapter PrevCh { get; set; }

        public MangaChapter NextCh { get; set; }
    }
}
