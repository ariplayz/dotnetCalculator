using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace dotnetCalculator;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void calculate(int num1, int num2, int operation)
    {
        double result = 0;





        
        output.Content = result.ToString();
    }
    
    public void zero(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("0");
    }
    
    public void one(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("1");
    }
    
    public void two(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("2");
    }
    
    public void three(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("3");
    }
    
    public void four(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("4");
    }
    
    public void five(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("5");
    }
    
    public void six(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("6");
    }
    
    public void seven(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("7");
    }
    
    public void eight(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("8");
    }
    
    public void nine(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("9");
    }

    public void plus(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("+");
    }
    
    public void minus(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("-");
    }
    
    public void multiply(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("*");
    }

    public void divide(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("/");
    }

    public void equal(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("=");
    }

}