/* The class "Repetition" calculates the sum and average of numbers up to a specified upper bound using
a do-while loop. */
using System;

class Repetition
{
    static void Main(string[] args)
    {
        int sum = 0;
        int upperbound;

        Console.Write("Enter the upper bound: ");
        upperbound = Convert.ToInt32(Console.ReadLine());
        int number = 1;

        // do while loop
        do
        {
            sum += number;
            // Shows each iteration so you can trace what's happening
            Console.WriteLine("Current number: " + number + " the sum is " + sum);
            number++;
        } while (number <= upperbound);

        double average = (double)sum / upperbound;
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
    }
}