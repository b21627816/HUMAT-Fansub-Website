using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajBlogProject.Models
{
    public interface IMangaRepository
    {

        IEnumerable<Manga> GetAllMangas();

        IEnumerable<MangaChapter> GetAllChapters(int id);

        Manga GetManga(int id);

        MangaChapter GetChapter(int id);

        Manga AddManga(Manga manga);

        MangaChapter AddChapter(MangaChapter chapter);

        MangaChapter UpdateChapter(MangaChapter changedChapter);

        Manga UpdateManga(Manga changedManga);

        Manga DeleteManga(int id);

        MangaChapter DeleteChapter(int id);


    }
}
