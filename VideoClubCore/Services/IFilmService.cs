using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubCore.Domain;

namespace VideoClubCore.Services
{
    public interface IFilmService
    {
        FilmCore GetById(string id);
        List<FilmCore> GetByCategory(string category);
        FilmCore SetFilm(FilmCore film);
        List<FilmCore> GetAll();
    }
}
