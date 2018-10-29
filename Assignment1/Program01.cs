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

            // Loop through input string in reverse
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                // Add characters of the input string to the reversedInput string
                reversedInput += userInput[i];
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
