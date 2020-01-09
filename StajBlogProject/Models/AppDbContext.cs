using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace StajBlogProject.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {
            
        }


        public DbSet<Post> Posts { get; set; }

        public DbSet<AnimeEpisode> AnimeEpisodes { get; set; }

        public DbSet<Anime> Animes { get; set; }

        public DbSet<MangaChapter> MangaChapters { get; set; }

        public DbSet<Manga> Mangas { get; set; }

        

    }
}
