using FilmRest.Interfaces;
using System;
using System.Collections.Generic;
using VideoClubInfra.DB;
using VideoClubInfra.DB.Models;

namespace FilmRest.Services
{
    public class FilmServices : IFilmService
    {
        private static FilmRepository _filmRepository = new FilmRepository();

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
