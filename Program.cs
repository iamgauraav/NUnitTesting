using System;

namespace NUnitTesting
{/// <summary>
/// UC-6 To Binary
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //local variable
            int n, i;

            //array to store value 
            int[] a = new int[10];

            Console.Write("Enter the number to convert: ");
            n = int.Parse(Console.ReadLine());
            //for loop 
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }


            Console.Write("Binary of the given number= ");

            //for loop for binary
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
            Console.ReadLine();

            
        }
    }
}

