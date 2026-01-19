using System;

class DoCasting
{
    static void Main(string[] args)
    {
        // Step 1: Declare and initialize variables
        int sum = 17;
        int count = 5;

        // Step 2: Calculate integer average
        int intAverage = sum / count;

        // Step 3: Print out the integer average
        Console.WriteLine("Integer average: " + intAverage);

        // Step 4: Declare a double variable
        double doubleAverage = sum / count;

        // Step 5: Print out the double average without casting
        Console.WriteLine("Double average without casting: " + doubleAverage);

        // Step 6: Cast sum to double and calculate the average
        doubleAverage = (double)sum / count;

        // Step 7: Print out the double average with casting
        Console.WriteLine("Double average with casting: " + doubleAverage);
    }
}
