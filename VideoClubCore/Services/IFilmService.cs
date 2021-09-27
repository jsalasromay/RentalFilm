using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubCore.Domain;

namespace VideoClubCore.Services
{
    public interface IFilmService
    {
        Film GetById(string id);
        List<Film> GetByCategory(string category);
    }
}
