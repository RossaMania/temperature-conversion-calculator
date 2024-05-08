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

        public static string GetTemperatureMessage(int fahrenheit)
        {
            decimal celsius = ConvertFahrenheitToCelsius(fahrenheit);
            return "The temperature is " + celsius + " degrees Celsius.";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(GetTemperatureMessage(94));
        }
    }
}