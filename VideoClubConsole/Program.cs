using VideoClubCore.Domain;
using VideoClubCore.Services;
using System;
using VideoClubInfratruc.HTTP;
using ServiceLibrary;
using Microsoft.Extensions.DependencyInjection;

namespace VideoClubConsole
{
    class Program
    {
        //private static IFilmService _filmService = new RestFullFilmService();
        //static void Main(string[] args)
        //{
        //    var application = new Application(_filmService);
        //    application.Run();
        //}
        private static IServiceProvider _provider ;
        static void Main(string[] args)
        {
            _provider = Container.Build();
            IApplication app = _provider.GetService<IApplication>();
            app.Run();
        }
    }
}
