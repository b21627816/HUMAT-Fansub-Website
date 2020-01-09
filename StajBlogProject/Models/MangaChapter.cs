using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajBlogProject.Models
{
    public class MangaChapter
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int ChapterNo { get; set; }

        public int MangaId { get; set; }

        public string ChFolder { get; set; }

    }
}
