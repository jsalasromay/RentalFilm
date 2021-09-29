using FilmRest.Interfaces;
using FilmRest.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FilmRest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private static IFilmService _filmService;
        public FilmController(IFilmService filmService)
        {
            _filmService = filmService;
        }
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
        [HttpGet("GetAll")]
        public List<Film> GetAll()
        {
            return _filmService.GetAll();
        }
    }
}
