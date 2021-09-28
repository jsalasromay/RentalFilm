using System;
using System.Collections.Generic;
using System.Text;
using VideoClubCore.Domain;
using VideoClubCore.Services;

namespace ServiceLibrary
{
    public class Application
    {
        private IFilmService _filmServices;
        public Application(IFilmService filmServices)
        {
            _filmServices = filmServices;
        }
        public void Run()
        {
            var listFilm = GetAll();
        }
        public List<FilmCore> GetAll()
        {
            Console.WriteLine("Listado de peliculas");
            var film = _filmServices.GetAll();
            foreach (var f in film)
            {
                Console.WriteLine($"Nombre: {f.Name}, Categoria: {f.Category}");
            }
            return film;
        }
    }
}
