namespace NavigationLab;

public partial class GreetingPage : ContentPage
{
    public GreetingPage(string name)
    {
        InitializeComponent();
        GreetingLabel.Text = $"Hello, {name}! 👋";
    }

    async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}