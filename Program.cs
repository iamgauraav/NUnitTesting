using System;

namespace NUnitTesting
{/// <summary>
/// UC-5 Calculating square root of  a number using newtons method
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //N is the numbeer for which you are calculating squareroot
            Console.WriteLine("Enter a number");
            double N = Convert.ToDouble(Console.ReadLine());
            //set L is the tolerence level
            double L = 0.00001;
            double t = N;
            double sqRoot;
            int count = 0;

            while (true)
            {
                count++;
                sqRoot = 0.5 * (t + (N / t));

                if (Math.Abs(sqRoot - t) < L)
                {
                    break;
                }
                t = sqRoot;
            }
            Console.WriteLine("Root Value is : " + Math.Round(sqRoot, 2));
            Console.ReadLine();
        }
    }
}

