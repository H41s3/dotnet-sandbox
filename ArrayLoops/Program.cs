using System;

//  TASK 2 — Integer Array with For Loops
//  Uses a for loop to populate an int array (0–9),
//  then a second for loop to print each element.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("  TASK 2: Integer Array with For Loops");
        Console.WriteLine();

        // Declares an array of type integer with 10 elements
        int[] myArray = new int[10];

        // For loop to populate the array — i starts at 0, goes up to (not including) 10
        for (int i = 0; i < 10; i++)
        {
            myArray[i] = i; // each element gets the value of its own index
        }

        Console.WriteLine("Array populated. Printing contents:");
        Console.WriteLine();

        // For loop to print the values in the array
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("The element at position " + i + " in the array is " + myArray[i]);
        }

        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}