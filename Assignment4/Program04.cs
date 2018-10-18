using System;

namespace Assignment4
{
    class Program04
    {
        static void Main(string[] args)
        {
            // Init RNG
            Random random = new Random();

            bool zeroOccured = false;
            int randomFactorial = 0;

            // Loop until a zero is generated
            while (zeroOccured == false)
            {
                // generate a random number
                int randomNr = random.Next(10);

                if (randomNr > 0)
                {
                    // Calculate and output factorial
                    randomFactorial = Factorial(randomNr);
                    Console.WriteLine("factorial of {0} is {1}", randomNr, randomFactorial);
                }
                else
                {
                    zeroOccured = true;
                }  
            }

            // End
            Console.WriteLine();
            Console.WriteLine("end of program");
            Console.ReadKey();
        }

        /// <summary>
        /// Calculate the factorial of any given integer.
        /// </summary>
        /// <param name="input"></param>
        static int Factorial(int input)
        {
            int factorial = 1;

            // Loop input amount of times
            for (int i = 0; i < input; i++)
            {
                // Calculate factorial
                factorial = factorial * (i + 1);
            }

            return factorial;
        }
    }
}
