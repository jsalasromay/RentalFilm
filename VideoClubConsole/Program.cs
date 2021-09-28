using VideoClubCore.Domain;
using VideoClubCore.Services;
using System;
using VideoClubInfratruc.HTTP;

namespace VideoClubConsole
{
    class Program
    {
        private static IFilmService _filmService = new RestFullFilmService();
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione la pelicula que desea modificar: AA, AB, AC, AD");
            var id = Console.ReadLine();
            Console.WriteLine("Introduce nuevo nombre");
            var name = Console.ReadLine();
            Console.WriteLine("Introduce nueva categoria");
            var category = Console.ReadLine();
            FilmCore setFilm = new FilmCore(id, name, category);
            _filmService.SetFilm(setFilm);

            var film3 = _filmService.GetAll();
            foreach (var f in film3)
            {
                Console.WriteLine($"Nombre: {f.Name}, Categoria: {f.Category}");
            }
        }
    }
}
