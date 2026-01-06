namespace AlohaWorld;

public partial class GreetingPage : ContentPage
{
    public GreetingPage(string name)
    {
        InitializeComponent();
        GreetingLabel.Text = $"Hello, {name}! 👋";
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}