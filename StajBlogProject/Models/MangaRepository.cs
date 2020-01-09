using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StajBlogProject.Models
{
    public class MangaRepository:IMangaRepository
    {
        private readonly AppDbContext _context;

        public MangaRepository(AppDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Manga> GetAllMangas()
        {
            return _context.Mangas.ToList();
        }

        public IEnumerable<MangaChapter> GetAllChapters(int id)
        {
            return _context.MangaChapters.Where(i => i.MangaId == id).ToList();
        }

        public Manga GetManga(int id)
        {
            return _context.Mangas.Find(id);    
        }

        public MangaChapter GetChapter(int id)
        {
            return _context.MangaChapters.Find(id);
        }

        public Manga AddManga(Manga manga)
        {
            _context.Mangas.Add(manga);
            _context.SaveChanges();
            return manga;
        }

        public MangaChapter AddChapter(MangaChapter chapter)
        {
            _context.MangaChapters.Add(chapter);
            _context.Mangas.Find(chapter.MangaId).Chapters.Add(chapter);
            _context.SaveChanges();
            return chapter;
        }

        public MangaChapter UpdateChapter(MangaChapter changedChapter)
        {
            var chapter = _context.MangaChapters.Attach(changedChapter);
            chapter.State = EntityState.Modified;
            _context.SaveChanges();
            return changedChapter;
        }

        public Manga UpdateManga(Manga changedManga)
        {
            var manga = _context.Mangas.Attach(changedManga);
            manga.State = EntityState.Modified;
            _context.SaveChanges();
            return changedManga;
        }

        public Manga DeleteManga(int id)
        {
            Manga manga = _context.Mangas.Find(id);
            if (manga != null)
            {
                foreach (var mangaChapter in GetAllChapters(id))
                {
                    DeleteChapter(mangaChapter.Id);
                }
                _context.Mangas.Remove(manga);
                _context.SaveChanges();
            }

            return manga;
        }

        public MangaChapter DeleteChapter(int id)
        {
            MangaChapter chapter = _context.MangaChapters.Find(id);
            if (chapter != null)
            {
                Directory.Delete(chapter.ChFolder,true);
                _context.MangaChapters.Remove(chapter);
                _context.SaveChanges();
            }

            return chapter;
        }
    }
}
