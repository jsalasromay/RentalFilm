using FilmRest.Services;
using Microsoft.AspNetCore.Mvc;
using VideoClubCore.Domain;
using VideoClubCore.Services;

namespace FilmRest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private static IFilmService _filmService = new FilmServices();
        [HttpGet("{id}")]
        public Film GetMovie(string id)
        {
            var film = _filmService.GetById(id);
            return film;
        }
    }
}
