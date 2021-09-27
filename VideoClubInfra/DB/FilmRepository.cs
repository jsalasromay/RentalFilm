using System.Collections.Generic;
using System.Linq;
using VideoClubCore.Domain;

namespace VideoClubInfra.DB
{
    public class FilmRepository
    {
        private static List<Film> _film;
        static FilmRepository()
        {
            _film = new List<Film>() { new Film("AA", "El señor de los palillos", "Comedia"), new Film("AB", "Titanic", "Drama"), new Film("AC", "Star wars", "Ciencia Ficción") };
        }
        public Film GetById(string id)
        {
            return _film.FirstOrDefault(m => m.Id == id);
        }
        public List<Film> GetByCategory(string category)
        {
            return _film.Where(m => m.Category == category).ToList();
        }
    }
}
