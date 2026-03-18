using System;

class DivisibleFour
{
    static void Main(string[] args)
    {
        int n = 0;
        bool validInput = false;

        // Get a valid upper bound from the user
        do
        {
            Console.Write("Enter a positive integer n: ");
            string input = Console.ReadLine();

            validInput = int.TryParse(input, out n);

            if (!validInput || n < 1)
            {
                Console.WriteLine("Please enter a positive whole number.");
                validInput = false;
            }

        } while (!validInput);

        Console.WriteLine("\nNumbers between 1 and " + n + " divisible by 4 but NOT by 5:\n");

        // for loop: task explicitly asks for a for loop here
        for (int i = 1; i <= n; i++)
        {
            // % is the modulo (remainder) operator
            // i % 4 == 0 -> divisible by 4
            // i % 5 != 0 -> NOT divisible by 5
            if (i % 4 == 0 && i % 5 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
