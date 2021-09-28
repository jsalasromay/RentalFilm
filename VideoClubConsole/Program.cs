using VideoClubCore.Domain;
using VideoClubCore.Services;
using VideoClubInfra.HTTP;
using System;

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
            Film setFilm = new Film(id, name, category);
            var film2 = _filmService.SetFilm(setFilm);

            var film3 = _filmService.GetAll();
            foreach (var f in film3)
            {
                Console.WriteLine($"Nombre: {f.Name}, Categoria: {f.Category}");
            }
        }
    }
}
