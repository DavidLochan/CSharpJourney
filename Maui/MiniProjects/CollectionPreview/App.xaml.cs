using Microsoft.Extensions.DependencyInjection;

namespace CollectionPreview;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new MainPage();
    }
}