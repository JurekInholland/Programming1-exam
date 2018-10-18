using System;

namespace Assignment3
{
    class Program03
    {

        static void Main(string[] args)
        {
            // Create a string-array with 20 elements
            string[] stringArray = new string[20];

            // Initialize iterator variable beforehand to access it later
            int i;

            // Loop through the entire array
            for (i = 0; i < stringArray.Length; i++)
            {
                // Parse user input
                Console.Write("Enter a word: ");
                string userInput = Console.ReadLine();

                // Only process input if it is not empty
                if (userInput.Length != 0)
                {
                    // store input in array
                    stringArray[i] = userInput;
                }

                // exit loop if input is empty
                else
                {
                    break;
                }
            }

            // Loop through all non empty array elements
            for (int j = 0; j < i; j++)
            {
                    // Determine if word length is even or odd; color accordingly
                    if (stringArray[j].Length % 2 != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    // Output colored word
                    Console.WriteLine(stringArray[j]);
            }

            // End
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("end of program");

            Console.ReadKey();
        }
    }
}
