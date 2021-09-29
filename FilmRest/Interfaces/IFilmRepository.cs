using System.Collections.Generic;

namespace FilmRest.Interfaces
{
    public interface IFilmRepository
    {
        List<Film> GetAll();
        List<Film> GetByCategory(string category);
        Film GetById(string id);
    }
}