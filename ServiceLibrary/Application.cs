using System;
using System.Collections.Generic;
using System.Text;
using VideoClubCore.Domain;
using VideoClubCore.Services;

namespace ServiceLibrary
{
    public class Application : IApplication
    {
        private IFilmService _filmServices;
        public Application(IFilmService filmServices)
        {
            _filmServices = filmServices;
        }
        public void Run()
        {
            GetById();
        }
        public void GetAll()
        {
            Console.WriteLine("Listado de peliculas");
            var film = _filmServices.GetAll();
            foreach (var f in film)
            {
                Console.WriteLine($"Identificador: {f.Id}, Nombre: {f.Name}, Categoria: {f.Category}");
            }
        }
        public void GetById()
        {
            Console.WriteLine("Seleccione el Identificador de la pelicula que desea ver: ");
            GetAll();
            var film = _filmServices.GetById(Console.ReadLine());
            Console.WriteLine($"Nombre: {film.Name}");
        }
    }
}
