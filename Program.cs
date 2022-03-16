using System;

namespace NUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //for calling  method created obj of the class 
            TemperatureConvertion temp = new TemperatureConvertion();

            //taking celsius value from user
            Console.WriteLine("Please provide celsius temp:");
            string val1 = Console.ReadLine();
            //CelsiusTOFahrenheit using double so double Fahrenheit
            double Fahrenheit = temp.CelsiusTOFahrenheit(val1);
            //interpulated string to print values
            Console.WriteLine($"The value of {val1} celsius is {Fahrenheit} Fahrenheit ");

            Console.WriteLine("Please provide Fahrenheit temp:");
            string val2 = Console.ReadLine();
            double celsius = temp.FahrenheitToCelsius(val2);
            Console.WriteLine($"The value of {val2} Fahrenheit is {celsius} celsius");
            Console.ReadLine();
        }
        
    }
}

