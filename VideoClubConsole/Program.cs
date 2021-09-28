using VideoClubCore.Domain;
using VideoClubCore.Services;
using System;
using VideoClubInfratruc.HTTP;
using ServiceLibrary;

namespace VideoClubConsole
{
    class Program
    {
        private static IFilmService _filmService = new RestFullFilmService();
        static void Main(string[] args)
        {
            var application = new Application(_filmService);
            application.Run();
        }
    }
}
