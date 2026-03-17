using System;

class Repetition
{
    static void Main(string[] args)
    {
        int sum = 0;
        int upperbound;

        Console.Write("Enter the upper bound: ");
        upperbound = Convert.ToInt32(Console.ReadLine());

        // Task 2: while loop
        int number = 1;
        while (number <= upperbound)
        {
            sum += number;
            // Shows each iteration so you can trace what's happening
            Console.WriteLine("Current number: " + number + " the sum is " + sum);
            number++;
        }

        double average = (double)sum / upperbound;

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
    }
}