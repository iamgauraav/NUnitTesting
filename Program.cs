using System;

namespace NUnitTesting
{/// <summary>
/// UC-4 Monthly Payment
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Taking Principal from user
            Console.WriteLine("Enter a Principal");
            double principal = Convert.ToDouble(Console.ReadLine());
            //Taking Interest rate from user
            Console.WriteLine("Enter Interest Rate");
            double rate = Convert.ToDouble(Console.ReadLine());
            //rate formula
            rate = (rate / 100) / 12;
            //Taking year from user
            Console.WriteLine("Enter a Year");
            int year = Convert.ToInt32(Console.ReadLine());
            year = year * 12;

            //Calculating payment 
            double pay = (principal * rate) / (1 - Math.Pow(1 + rate, -year));

            Console.WriteLine("Payment " + pay);
            Console.ReadLine();
        }
        
    }
}

