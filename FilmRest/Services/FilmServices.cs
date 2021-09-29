using FilmRest.Interfaces;
using System;
using System.Collections.Generic;

namespace FilmRest.Services
{
    public class FilmServices : IFilmService
    {
        private static IFilmRepository _filmRepository;
        public FilmServices(IFilmRepository filmRepository)
        {
            _filmRepository = filmRepository;
        }
        public List<Film> GetAll()
        {
            return _filmRepository.GetAll();
        }

        public List<Film> GetByCategory(string category)
        {
            return _filmRepository.GetByCategory(category);
        }

        public Film GetById(string id)
        {
            return _filmRepository.GetById(id);
        }

        public Film SetFilm(Film film)
        {
            var setFilm = _filmRepository.GetById(film.Id);
            setFilm.Name = film.Name;
            setFilm.Category = film.Category;
            return setFilm;
        }
    }
}
