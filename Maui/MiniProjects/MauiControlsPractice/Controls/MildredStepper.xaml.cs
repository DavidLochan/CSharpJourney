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
        _value--;
        ValueEntry.Text = _value.ToString();
    }

    private void PlusButton_Clicked(object sender, EventArgs e)
    {
        _value++;
        ValueEntry.Text = _value.ToString();
    }
}