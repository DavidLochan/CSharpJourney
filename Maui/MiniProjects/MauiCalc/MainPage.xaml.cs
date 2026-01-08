namespace MauiCalc;

public partial class MainPage : ContentPage
{
    private double firstNumber = 0;
    private double secondNumber = 0;
    private string currentOperation = "";
    private bool isOperationPressed = false;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnNumberClicked(object sender, EventArgs e)
    {
        var btn = sender as Button;
        
        // If an operation was just pressed, clear display for new number
        if (isOperationPressed)
        {
            LCD.Text = "";
            isOperationPressed = false;
        }
        
        // Don't allow multiple zeros at start
        if (LCD.Text == "0")
        {
            LCD.Text = btn.Text;
        }
        else
        {
            LCD.Text += btn.Text;
        }
    }

    private void OnOperationClicked(object sender, EventArgs e)
    {
        var btn = sender as Button;
        
        if (double.TryParse(LCD.Text, out firstNumber))
        {
            currentOperation = btn.Text;
            isOperationPressed = true;
        }
    }

    private void OnEqualsClicked(object sender, EventArgs e)
    {
        if (double.TryParse(LCD.Text, out secondNumber))
        {
            double result = 0;
            
            switch (currentOperation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "×":
                    result = firstNumber * secondNumber;
                    break;
               case "÷":
                     if (secondNumber != 0)
                    {
                      result = firstNumber / secondNumber;
                      }
                     else
                     {
                      LCD.Text = "Error";
                           return;
                    }
                 break;
				 isOperationPressed = true;

            }
            
            LCD.Text = result.ToString();
            currentOperation = "";
        }
    }

    private void OnClearClicked(object sender, EventArgs e)
    {
        LCD.Text = "0";
        firstNumber = 0;
        secondNumber = 0;
        currentOperation = "";
        isOperationPressed = false;
    }
}