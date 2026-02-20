using Microsoft.Extensions.DependencyInjection;

namespace MacDeskLab;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}
	protected override Window CreateWindow(IActivationState? activationState)
{
    return new Window(new AppShell())
    {
        Title = "MacDeskLab",
        MinimumWidth = 1000,
        MinimumHeight = 650
    };
}
}