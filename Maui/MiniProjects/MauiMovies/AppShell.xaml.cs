namespace MauiMovies;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("details", typeof(MovieDetailsPage));
	}
}
