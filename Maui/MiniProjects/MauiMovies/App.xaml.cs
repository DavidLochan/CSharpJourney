using Microsoft.Extensions.DependencyInjection;

namespace MauiMovies;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new MainPage())
        {
            Title = "MauiMovies 🎬",
			MinimumWidth = 1100,
            MinimumHeight = 700
        };
    }
}