namespace AlohaWorld;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(GreetingPage), typeof(GreetingPage));
    }
}