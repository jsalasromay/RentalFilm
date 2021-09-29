using Microsoft.Extensions.DependencyInjection;
using ServiceLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using VideoClubCore.Services;
using VideoClubInfratruc.HTTP;

namespace VideoClubConsole
{
    class Container
    {
        public static IServiceProvider Build()
        {
            var Container = new ServiceCollection()
                .AddSingleton<IFilmService, RestFullFilmService>()
                .AddSingleton<IApplication, Application>();
            return Container.BuildServiceProvider();
        }
    }
}
