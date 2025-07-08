using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace dotnetCalculator;

public partial class MainWindow : Window
{
    private string currentNumber = "";
    private double firstNumber = 0;
    private string currentOperation = "";
    private bool isNewNumber = true;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void NumberButton_Click(object sender, RoutedEventArgs e)
    {
        if (sender is not Button button || button.Content is not string number)
            return;

        if (number == "." && currentNumber.Contains("."))
            return; // Prevent multiple decimal points

        if (isNewNumber)
        {
            currentNumber = number == "." ? "0." : number;
            isNewNumber = false;
        }
        else
        {
            currentNumber += number;
        }

        if (output != null)
        {
            output.Content = currentNumber;
        }
    }

    private void OperationButton_Click(object sender, RoutedEventArgs e)
    {
        if (sender is not Button button)
            return;

        if (!string.IsNullOrEmpty(currentNumber))
        {
            if (!string.IsNullOrEmpty(currentOperation))
            {
                CalculateResult();
            }
            
            firstNumber = double.Parse(currentNumber);
            currentOperation = button.Tag?.ToString() ?? "";
            isNewNumber = true;
        }
    }

    private void EqualButton_Click(object sender, RoutedEventArgs e)
    {
        if (!string.IsNullOrEmpty(currentOperation) && !string.IsNullOrEmpty(currentNumber))
        {
            CalculateResult();
            currentOperation = "";
        }
    }

    private void ClearButton_Click(object sender, RoutedEventArgs e)
    {
        output.Content = "";
        currentNumber = "";
        currentOperation = "";
        isNewNumber = true;
        
    }

    private void CalculateResult()
    {
        if (string.IsNullOrEmpty(currentNumber) || output == null) return;

        double secondNumber = double.Parse(currentNumber);
        double result = currentOperation switch
        {
            "+" => firstNumber + secondNumber,
            "-" => firstNumber - secondNumber,
            "*" => firstNumber * secondNumber,
            "/" => secondNumber != 0 ? firstNumber / secondNumber : double.NaN,
            _ => double.NaN
        };

        if (double.IsNaN(result))
        {
            output.Content = "Error";
        }
        else
        {
            result = Math.Round(result, 4);
            currentNumber = result.ToString();
            output.Content = result.ToString();
        }
        
        isNewNumber = true;
    }
}