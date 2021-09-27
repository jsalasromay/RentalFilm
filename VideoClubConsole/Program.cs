using FilmRest.Services;
using System;
using VideoClubCore.Services;

namespace VideoClubConsole
{
    class Program
    {
        private static IFilmService _filmService = new FilmServices();
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione la pelicula que desee ver: AA, AB, AC");
            var film = _filmService.GetById(Console.ReadLine());
            Console.WriteLine($"Nombre: {film.Name}");
            Console.WriteLine($"Category: {film.Category}");
        }
    }
}
