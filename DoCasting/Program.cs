using System;

class DoCasting
{
    static void Main(string[] args)
    {
        // 1st step: declare and initialize variables
        int sum = 17;
        int count = 5;

        // 2nd step: calculate integer average
        int intAverage = sum / count;

        // 3rd step: print out the integer average
        Console.WriteLine("Integer average: " + intAverage);

        // 4th step: declare a double variable
        double doubleAverage = sum / count;

        // 5th step: print out the double average without casting
        Console.WriteLine("Double average: " + doubleAverage);

        // 6th step: cast sum to double and calculate the average
        doubleAverage = (double)sum / count;

        // 7th step: print out the double average with casting
        Console.WriteLine("Double average: " + doubleAverage);
    }
}
