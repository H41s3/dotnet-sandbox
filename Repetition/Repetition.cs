using System;

// SIT232 - Practical Task 1.2
// Tasks 1, 2, 3: Demonstrating for, while, and do...while loops
// All three loops produce the same result: sum and average of 1..upperbound

class Repetition
{
    static void Main(string[] args)
    {
        // --- Setup ---
        int upperbound = 100;
        int sum;
        double average;

        // =============================================
        // TASK 1: FOR LOOP
        // Use when you know exactly how many iterations
        // =============================================
        Console.WriteLine("=== Task 1: FOR Loop ===");

        sum = 0; // reset before each loop block
        for (int number = 1; number <= upperbound; number++)
        {
            sum += number;
        }

        // Cast sum to double so division gives a decimal result (not integer)
        average = (double)sum / upperbound;

        Console.WriteLine("The sum is " + sum);
        Console.WriteLine("The average is " + average);

        // =============================================
        // TASK 2: WHILE LOOP
        // Use when the number of iterations isn't known upfront
        // =============================================
        Console.WriteLine("\n=== Task 2: WHILE Loop ===");

        sum = 0;
        int number2 = 1; // initialise counter outside the loop

        while (number2 <= upperbound)
        {
            sum += number2;
            number2++; // don't forget to increment or you get an infinite loop!
        }

        average = (double)sum / upperbound;

        Console.WriteLine("The sum is " + sum);
        Console.WriteLine("The average is " + average);

        // =============================================
        // TASK 3: DO...WHILE LOOP
        // Executes the body AT LEAST once before checking the condition
        // Great for input validation
        // =============================================
        Console.WriteLine("\n=== Task 3: DO...WHILE Loop ===");

        sum = 0;
        int number3 = 1;

        do
        {
            sum += number3;
            number3++;
        } while (number3 <= upperbound); // condition checked AFTER the body runs

        average = (double)sum / upperbound;

        Console.WriteLine("The sum is " + sum);
        Console.WriteLine("The average is " + average);
    }
}
