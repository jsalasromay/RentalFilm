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


            Console.WriteLine("Seleccione la categoria que desee ver: Comedia, Drama, Sci-fi");
            var film2 = _filmService.GetByCategory(Console.ReadLine());
            foreach (var f in film2)
            {
                Console.WriteLine($"Nombre: {f.Name}");
                Console.WriteLine($"Category: {f.Category}");
            }
        }
    }
}
