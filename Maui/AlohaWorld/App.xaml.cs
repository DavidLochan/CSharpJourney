using Microsoft.Extensions.DependencyInjection;

namespace AlohaWorld;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new NavigationPage(new MainPage());
	}
}