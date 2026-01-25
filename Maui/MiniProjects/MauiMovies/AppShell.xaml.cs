using MauiMovies.Views;

namespace MauiMovies;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(MovieDetailsPage), typeof(MovieDetailsPage));
	}
}
