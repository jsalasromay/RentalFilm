using System;
using System.Collections.Generic;
using VideoClubCore.Domain;
using VideoClubCore.Services;
using VideoClubInfra.DB;

namespace FilmRest.Services
{
    public class FilmServices : IFilmService
    {
        private static FilmRepository _filmRepository = new FilmRepository();
        public List<Film> GetByCategory(string category)
        {
            return _filmRepository.GetByCategory(category);
        }

        public Film GetById(string id)
        {
            return _filmRepository.GetById(id);
        }
    }
}
