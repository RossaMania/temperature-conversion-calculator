// See https://aka.ms/new-console-template for more information
using System;

namespace temperature_conversion_calculator
{
    class Program
    {
        static void Main(string[] args)
        {

          int fahrenheit = 94;;
          decimal firstCalculation = (decimal)fahrenheit - 32;
          // decimal celsius = firstCalculation * ((decimal)5m / (decimal)9m);
          decimal celsius = firstCalculation * (5m / 9m);

          Console.WriteLine("The temperature is " + Math.Round(celsius, 1) + " degrees Celsius.");

        }
    }
}