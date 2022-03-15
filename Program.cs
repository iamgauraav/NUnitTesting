using System;

namespace NUnitTesting
{/// <summary>
/// UC1- Vending machine
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNotes = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };

            Console.WriteLine("Enter the amount to get change \n(1000, 500, 100, 50, 5, 2, 1 available)");
            int amount = Convert.ToInt32(Console.ReadLine());
            ////count notes using For loop
            for (int i = 0; i < arrNotes.Length; i++)
            {
                int noOfNotes = 0;

                if(amount >= arrNotes[i]);
                {
                    noOfNotes = amount / arrNotes[i];
                    //Using % finding remaining change
                    amount = amount % arrNotes[i];

                    
                    Console.WriteLine(+arrNotes[i] + " no of notes of rupees " + noOfNotes );
                }
            }
            Console.ReadLine();
        }
        
    }
}
