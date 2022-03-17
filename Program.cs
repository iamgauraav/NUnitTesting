using System;

namespace NUnitTesting
{
    class Program
    {

        public static void SwapNibbles()
        {
            Console.WriteLine("Enter a value");
            int x = Convert.ToInt32(Console.ReadLine());
            int result = ((x & 0x0F) << 4 | (x & 0xF0) >> 4);
            Console.WriteLine("After swapping a bits " + result);
            //turnary operator use-> method(variable) ? is like if condition,: is like else .
            Console.WriteLine(isPowerOfTwo(result) ? "Number is power of 2" : "Number is not a power of 2");
        }

        // Method to check if result is power of 2
        public static bool isPowerOfTwo(int result)
        {
            if (result == 0)
            {
                return false;
            }
            while (result != 1)
            {
                if (result % 2 != 0)
                {
                    return false;
                }
                result = result / 2;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Program swap = new Program();
            SwapNibbles();
            isPowerOfTwo(12);
            Console.ReadLine();
        }
    }
}

