namespace MauiControlsPractice.Controls;

public partial class MildredStepper : ContentView
{
    public static readonly BindableProperty ValueProperty =
        BindableProperty.Create(
            nameof(Value),
            typeof(int),
            typeof(MildredStepper),
            0);

    public int Value
    {
        get => (int)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }

    public static new readonly BindableProperty IsEnabledProperty =
    BindableProperty.Create(
        nameof(IsEnabled),
        typeof(bool),
        typeof(MildredStepper),
        true,
        propertyChanged: OnIsEnabledChanged);

        private static void OnIsEnabledChanged(
    BindableObject bindable,
    object oldValue,
    object newValue)
{
    if (bindable is MildredStepper stepper)
    {
        bool isEnabled = (bool)newValue;

        stepper.ValueEntry.IsEnabled = isEnabled;
        stepper.PlusButton.IsEnabled = isEnabled;
        stepper.MinusButton.IsEnabled = isEnabled;
    }
}
    public MildredStepper()
{
    InitializeComponent();
    Value = 0;
    ValueEntry.Text = Value.ToString();
}

  private void MinusButton_Clicked(object sender, EventArgs e)
{
    if (Value > 0)
    {
        Value--;
        ValueEntry.Text = Value.ToString();
    }
}

    private void PlusButton_Clicked(object sender, EventArgs e)
{
    Value++;
    ValueEntry.Text = Value.ToString();
}

    private void ValueEntry_TextChanged(object sender, TextChangedEventArgs e)
{
    if (int.TryParse(e.NewTextValue, out var parsedValue))
    {
        if (parsedValue >= 0)
        {
            Value = parsedValue;
        }
        else
        {
            ValueEntry.Text = Value.ToString();
        }
    }
    else
    {
        ValueEntry.Text = Value.ToString();
    }
}
}