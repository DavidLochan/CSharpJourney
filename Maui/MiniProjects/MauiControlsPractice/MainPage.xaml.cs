namespace MauiControlsPractice;

public partial class MainPage : ContentPage
{
    private int _count;

    public int Count
    {
        get => _count;
        set
        {
            _count = value;

            if (_count == 1)
                CounterBtn.Text = $"Clicked {_count} time";
            else
                CounterBtn.Text = $"Clicked {_count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
        Count = 0;
    }

    private void OnCounterClicked(object? sender, EventArgs e)
    {
        Count++;
    }
}