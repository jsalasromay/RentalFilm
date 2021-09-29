using Microsoft.Extensions.DependencyInjection;
using System;
using System.Text;
using VideoClubCore.Services;
using VideoClubInfratruc.HTTP;

namespace ServiceLibrary
{
    public class Container
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
