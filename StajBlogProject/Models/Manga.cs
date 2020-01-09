using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajBlogProject.Models
{
    public class Manga
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string ImageUrl { get; set; }

        public DateTime UploadDate { get; set; }

        public List<MangaChapter> Chapters { get; set; }

    }
}
