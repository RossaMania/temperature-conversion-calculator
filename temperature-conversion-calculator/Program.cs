// See https://aka.ms/new-console-template for more information
using System;

namespace temperature_conversion_calculator
{
    public class Program
    {
        public static decimal ConvertFahrenheitToCelsius(int fahrenheit)
        {
            decimal firstCalculation = (decimal)fahrenheit - 32;
            decimal celsius = firstCalculation * (5m / 9m);
            return Math.Round(celsius, 1);
        }

        public static void Main(string[] args)
        {
            int fahrenheit = 94;
            decimal celsius = ConvertFahrenheitToCelsius(fahrenheit);
            Console.WriteLine("The temperature is " + celsius + " degrees Celsius.");
        }
    }
}