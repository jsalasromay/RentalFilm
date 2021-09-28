using FilmRest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using VideoClubCore.Domain;
using VideoClubCore.Services;

namespace VideoClubInfratruc.HTTP
{
    public class RestFullFilmService : IFilmService
    {
        public List<FilmCore> GetAll()
        {
            string apiUrl = "https://localhost:44306/film/GetAll";
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.DownloadString($"{apiUrl}");
                var film = JsonConvert.DeserializeObject<List<FilmCore>>(json);
                return film;
            }
        }

        public List<FilmCore> GetByCategory(string category)
        {
            string apiUrl = "https://localhost:44306/film/GetMovieByCategory";
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.DownloadString($"{apiUrl}/{category}");
                var film = JsonConvert.DeserializeObject<List<FilmCore>>(json);
                return film;
            }
        }

        public FilmCore GetById(string id)
        {
            string apiUrl = "https://localhost:44306/film/GetMovie";
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.DownloadString($"{apiUrl}/{id}");
                var film = JsonConvert.DeserializeObject<FilmCore>(json);
                return film;
            }
        }

        public FilmCore SetFilm(FilmCore film)
        {
            string apiUrl = "https://localhost:44306/film/SetFilm";
            Film setFilm = new Film(film.Id, film.Name, film.Category);
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString($"{apiUrl}", setFilm.ToString());
                var film2 = JsonConvert.DeserializeObject<FilmCore>(json);
                return film2;
            }
        }
    }
}
