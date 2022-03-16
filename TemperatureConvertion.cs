using System;
namespace NUnitTesting
{
    public class TemperatureConvertion
    {
        //Method to calculate CelsiusTOFahrenheit
        public double CelsiusTOFahrenheit(string celsiusTemp)
        {
            double celsius = double.Parse(celsiusTemp);
            double Fahrenheit = (celsius * 9 / 5) + 32;
            return Fahrenheit;

        }
        // Method to calculate FahrenheitToCelsius
        public double FahrenheitToCelsius(string fahrenheitTemp)
        {
            double fahrenheit = double.Parse(fahrenheitTemp);
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}
