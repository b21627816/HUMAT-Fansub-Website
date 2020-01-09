using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using StajBlogProject.Models;

namespace StajBlogProject.ViewModels
{
    public class MangaChapterCreateViewModel
    {

        public Manga Manga { get; set; }

        [Required]
        public int ChapterNo { get; set; }

        [Required]
        public string Title { get; set; }

        public List<IFormFile> Files { get; set; }

    }
}
