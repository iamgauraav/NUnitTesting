using System;

namespace NUnitTesting
{
    class Program
    {/// <summary>
    /// UC1- Vending machine
    /// </summary>

        //Function to count
        //Print currency notes
        public static void FewestNotes(int amount)
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] count = new int[notes.Length];

            //count notes using Greedy approach
            for (int i = 0; i < notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    count[i] = amount / notes[i];
                    amount = amount - (count[i] * notes[i]);

                    if (amount < 0)
                    {
                        break;
                    }
                }
            }
            //print notes
            for (int a = 0; a < notes.Length; a++)
            {
                if (count[a] != 0)
                {
                    Console.WriteLine(+count[a] + " no of notes of rupees " + notes[a]);
                }
            }
        }
        //Driver function
        static void Main(string[] args)
        {
            int amount = 1000;
            FewestNotes(amount);
            Console.ReadLine();

        }
        
    }
}
