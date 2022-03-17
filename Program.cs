using System;

namespace NUnitTesting
{/// <summary>
/// UC- 2 Day Of Week
/// </summary>
    class Program
    {
        public static void UserInput()
        {
            Console.WriteLine("Enter Date");
            int d =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year");
            int y = Convert.ToInt32(Console.ReadLine());
        }
        public static void CalculateDay(int d ,int m , int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) -2;
            int d0 = (d + x + 31 * m0 / 12) % 7;

            //switch case
            switch (d0)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednessday");
                    break;
                case 4:
                    Console.WriteLine("Thrusday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Program cal = new Program();
            UserInput();
            Program.CalculateDay(12,04,2015);
            Console.ReadLine();
        }
    }
}

