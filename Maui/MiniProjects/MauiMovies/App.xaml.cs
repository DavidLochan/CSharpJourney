using Microsoft.Extensions.DependencyInjection;

namespace MauiMovies;

public partial class App : Application
{ 
	BaseAddress = new Uri(AppSecrets.TmdbBaseUrl)

    var url = $"trending/movie/week?api_key={AppSecrets.TmdbApiKey}";
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell())
        {
            Title = "MauiMovies 🎬",
            MinimumWidth = 1100,
            MinimumHeight = 700
        };
    }
}