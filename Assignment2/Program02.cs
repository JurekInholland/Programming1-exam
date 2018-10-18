using System;

namespace Assignment2
{
    class Program02
    {
        static void Main(string[] args)
        {
            int input = 1;

            while (input != 0)
            {
                // Parse user input
                Console.Write("Enter a number: ");
                input = int.Parse(Console.ReadLine());

                int halfOfInput = input / 2;

                // Only process positive numbers
                if (input > 0)
                {
                    // Loop user specified amount of times. 
                    for (int i = 0; i < input; i++)
                    {
                        // Print either "*" or "!" depending on if it's the first or second half
                        if (i < halfOfInput)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("!");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            // End the program once "0" is entered
            Console.WriteLine("end of program");
            Console.ReadKey();
        }
    }
}
