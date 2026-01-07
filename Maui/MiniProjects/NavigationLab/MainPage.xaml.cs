namespace NavigationLab;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    async void OnNavigateClicked(object sender, EventArgs e)
    {
        var name = NameEntry.Text;

        if (string.IsNullOrWhiteSpace(name))
        {
            await DisplayAlert("Error", "Please enter your name", "OK");
            return;
        }

        await Navigation.PushAsync(new GreetingPage(name));
    }
}