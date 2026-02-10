namespace MauiControlsPractice.Controls;

public partial class MildredStepper : ContentView
{
    private int _value;

    public MildredStepper()
    {
        InitializeComponent();
        _value = 0;
        ValueEntry.Text = _value.ToString();
    }

   private void MinusButton_Clicked(object sender, EventArgs e)
{
    if (_value > 0)
    {
        _value--;
        ValueEntry.Text = _value.ToString();
    }
}

    private void PlusButton_Clicked(object sender, EventArgs e)
    {
        _value++;
        ValueEntry.Text = _value.ToString();
    }

    private void ValueEntry_TextChanged(object sender, TextChangedEventArgs e)
{
    if (int.TryParse(e.NewTextValue, out var parsedValue))
    {
        if (parsedValue >= 0)
        {
            _value = parsedValue;
        }
        else
        {
            ValueEntry.Text = _value.ToString();
        }
    }
    else
    {
        ValueEntry.Text = _value.ToString();
    }
}
}