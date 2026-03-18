using System;

class DivisibleFour
{
    static void Main(string[] args)
    {
        int n = 0;
        bool validInput = false;

        // Keep asking until the user enters a valid positive number
        do
        {
            Console.Write("Enter a positive integer n: ");
            string input = Console.ReadLine();

            // TryParse returns false if the user types letters or symbols
            validInput = int.TryParse(input, out n);

            if (!validInput || n < 1)
            {
                Console.WriteLine("Please enter a positive whole number.");
                validInput = false;
            }

        } while (!validInput);

        Console.WriteLine("\nNumbers between 1 and " + n + " divisible by 4 but NOT by 5:\n");

        // Check every number from 1 to n
        for (int i = 1; i <= n; i++)
        {
            // % gives the remainder — if remainder is 0, it divides evenly
            // e.g. 20 % 4 = 0 (yes) but 20 % 5 = 0 (no) so 20 is excluded
            if (i % 4 == 0 && i % 5 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}