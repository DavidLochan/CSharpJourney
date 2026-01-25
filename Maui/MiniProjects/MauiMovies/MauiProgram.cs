using Microsoft.Extensions.Logging;
using MauiMovies.Services;
using Microsoft.Extensions.DependencyInjection;
using MauiMovies.Views; 
using MauiMovies.ViewModels;

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

builder.Services.AddTransient<MoviesViewModel>();

builder.Services.AddTransient<MoviesPage>();
builder.Services.AddTransient<MovieDetailsPage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
