using FilmRest.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VideoClubCore.Domain;
using VideoClubCore.Services;

namespace FilmRest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private static IFilmService _filmService = new FilmServices();
        [HttpGet("GetMovie/{id}")]
        public Film GetMovie(string id)
        {
            var film = _filmService.GetById(id);
            return film;
        }
        [HttpGet("GetMovieByCategory/{category}")]
        public List<Film> GetMovieByCategory(string category)
        {
            var film = _filmService.GetByCategory(category);
            return film;
        }
        [HttpPost("[action]")]
        public Film SetFilm([FromBody] Film film)
        {
            return _filmService.SetFilm(film);
        }
    }
}
