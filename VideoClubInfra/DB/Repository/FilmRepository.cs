using System.Collections.Generic;
using System.Linq;
using VideoClubInfra.DB.Models;

namespace VideoClubInfra.DB
{
    public class FilmRepository
    {
        private static List<Film> _film;
        static FilmRepository()
        {
            _film = new List<Film>() { 
                new Film("AA", "El señor de los palillos", "Comedia"), 
                new Film("AB", "Titanic", "Drama"), 
                new Film("AC", "Star wars", "Sci-fi"),
                new Film("AD", "Los simpsons la pelicula", "Comedia") };
        }
        public Film GetById(string id)
        {
            return _film.FirstOrDefault(m => m.Id == id);
        }
        public List<Film> GetByCategory(string category)
        {
            return _film.Where(m => m.Category == category).ToList();
        }
        public List<Film> GetAll()
        {
            return _film.ToList();
        }
    }
}
