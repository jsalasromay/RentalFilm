using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoClubInfra.DB.Models;

namespace FilmRest.Interfaces
{
    public interface IFilmService
    {
        Film GetById(string id);
        List<Film> GetByCategory(string category);
        Film SetFilm(Film film);
        List<Film> GetAll();
    }
}
