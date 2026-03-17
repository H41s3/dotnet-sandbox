using System;

class Repetition
{
    static void Main(string[] args)
    {
        int sum = 0;
        int upperbound;

        // Ask the user for the upper bound
        Console.Write("Enter the upper bound: ");
        upperbound = Convert.ToInt32(Console.ReadLine());

        // Add every number from 1 up to upperbound
        for (int number = 1; number <= upperbound; number++)
        {
            sum += number;
        }

        // Cast sum to double so we get a decimal average, not a rounded integer
        double average = (double)sum / upperbound;

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
    }
}