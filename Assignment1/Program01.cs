using System;

namespace Assignment1
{
    class Program01
    {
        static void Main(string[] args)
        {
            // Parse user input
            Console.Write("Enter a word: ");
            string userInput = Console.ReadLine();

            string reversedInput = "";

            // Loop through input string
            for (int i = 0; i < userInput.Length; i++)
            {
                // Add characters of the input string to the reversedInput string, starting from the end
                reversedInput += userInput[userInput.Length - (i + 1)];
            }

            // Output result
            if (userInput == reversedInput)
            {
                Console.WriteLine("{0} is a palindrome.", userInput);
            }
            else
            {
                Console.WriteLine("{0} is not a palindrome.", userInput);
            }

            Console.ReadKey();
        }
        
    }
}
