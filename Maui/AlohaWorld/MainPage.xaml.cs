namespace AlohaWorld;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnShowGreetingClicked(object sender, EventArgs e)
{
    if (string.IsNullOrWhiteSpace(NameEntry.Text))
        return;

    await Shell.Current.GoToAsync(nameof(GreetingPage));
}
}