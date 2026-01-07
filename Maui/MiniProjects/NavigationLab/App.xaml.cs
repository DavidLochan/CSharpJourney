using Microsoft.Extensions.DependencyInjection;

namespace NavigationLab;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new NavigationPage(new MainPage());
	}
}