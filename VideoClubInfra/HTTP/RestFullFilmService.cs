using System;
using System.Collections.Generic;
using VideoClubCore.Domain;
using VideoClubCore.Services;

namespace VideoClubInfra.HTTP
{
    class RestFullFilmService : IFilmService
    {
        public List<Film> GetByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public Film GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
