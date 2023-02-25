using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MovieManager.Dao;
using MovieManager.Dao.Interfaces;
using MovieManager.Services;

namespace MovieManager;

/// <summary>
///     Used for registration of new interfaces
/// </summary>
internal class Startup
{
    public IServiceProvider ConfigureServices()
    {
        IServiceCollection services = new ServiceCollection();

        services.AddLogging(builder =>
        {
            builder.AddConsole();
            builder.AddFile("app.log");
        });

        // Add new lines of code here to register any interfaces and concrete services you create
        services.AddTransient<IMainService, MainService>();
        services.AddTransient<IRepository, MovieRepository>();
        services.AddTransient<IMovieContext, MovieContext>();

        return services.BuildServiceProvider();
    }
}
