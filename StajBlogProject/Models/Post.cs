using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace StajBlogProject.Models
{
    public class Post
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string TextOnly { get; set; }

        [DataType(DataType.MultilineText)]
        public String Text { get; set; }

        public string ImageUrl { get; set; }

        public DateTime PostDate { get; set; }
    }
}
