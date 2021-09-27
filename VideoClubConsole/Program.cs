using FilmRest.Services;
using System;
using VideoClubCore.Domain;
using VideoClubCore.Services;

namespace VideoClubConsole
{
    class Program
    {
        private static IFilmService _filmService = new FilmServices();
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione la pelicula que desee ver: AA, AB, AC, AD");
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

            Console.WriteLine("Seleccione la pelicula que desea modificar: AA, AB, AC, AD");
            string id = Console.ReadLine();
            Console.WriteLine("Elija nuevo nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Elija nueva categoria: ");
            string category = Console.ReadLine();
            Film film3 = new Film(id, name, category);
            var film4 = _filmService.SetFilm(film3);
            Console.WriteLine($"Pelicula modiicada con exito: ");
            Console.WriteLine($"Nombre: {film4.Name}");
            Console.WriteLine($"Category: {film4.Category}");
            Console.ReadLine();
        }
    }
}
