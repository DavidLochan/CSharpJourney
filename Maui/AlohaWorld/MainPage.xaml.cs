namespace AlohaWorld;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnShowGreetingClicked(object sender, EventArgs e)
{
    var name = NameEntry.Text;

    if (string.IsNullOrWhiteSpace(name))
    {
        ResultLabel.Text = "Please enter your name ";
        return;
    }

    await Navigation.PushAsync(new GreetingPage(name));
}
}