using System;

namespace DailyBread
{
    class Program
    {
        
        static void Main()
        {
            Scripture scripture = new Scripture("Ether ", 12, 27, "And if men come unto me I will show unto them their aweakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make eweak things become strong unto them.");
            Console.Clear();
            scripture.Display(); 
            Console.WriteLine("\n\nPress Enter to continue or type 'quit' to exit.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWord())
                {
                    Console.WriteLine("\nYou memorized the scripture!!");
                    break;
                }

                Console.Clear();
                scripture.Display();
                Console.WriteLine("\n\nPress Enter to continue or type 'quit' to exit.");
            }
        }
    }
}