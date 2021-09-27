using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using VideoClubCore.Domain;
using VideoClubCore.Services;

namespace VideoClubInfra.HTTP
{
    class RestFullFilmService : IFilmService
    {
        private Film _film;
        public List<Film> GetByCategory(string category)
        {
            string apiUrl = "https://localhost:44306/film/GetMovieByCategory";
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.DownloadString($"{apiUrl}/{_film.Category}");
                var film = JsonConvert.DeserializeObject<List<Film>>(json);
                return film;
            }
        }

        public Film GetById(string id)
        {
            string apiUrl = "https://localhost:44306/film/GetMovie";
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.DownloadString($"{apiUrl}/{_film.Id}");
                var film = JsonConvert.DeserializeObject<Film>(json);
                return film;
            }
        }

        public Film SetFilm(Film film)
        {
            string apiUrl = "https://localhost:44306/film/SetFilm";
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString($"{apiUrl}", film.ToString());
                var film2 = JsonConvert.DeserializeObject<Film>(json);
                return film2;
            }
        }
    }
}
