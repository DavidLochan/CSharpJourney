using Microsoft.Extensions.Logging;
using MauiMovies.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MauiMovies;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
           
		    builder.Services.AddHttpClient<IMovieService, MovieService>(client =>
{
    client.BaseAddress = new Uri(AppSecrets.TmdbBaseUrl);
});

builder.Services.AddTransient<MoviesPage>();
builder.Services.AddTransient<MovieDetailsPage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
