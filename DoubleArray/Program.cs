using System;

//  TASK 1 — Manual Double Array
//  Declares a double array of 10 elements, assigns each value
//  individually, then prints each element to the console.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("  TASK 1: Manual Double Array");

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine();

        // Declares an array of type double with 10 elements
        // All elements default to 0.0 until we assign them
        double[] myArray = new double[10];

        // Assigning the first element of the array
        myArray[0] = 1.0;
        // Assigning the second element of the array
        myArray[1] = 1.1;
        myArray[2] = 1.2;
        myArray[3] = 1.3;
        myArray[4] = 1.4;
        myArray[5] = 1.5;
        myArray[6] = 1.6;
        myArray[7] = 1.7;
        myArray[8] = 1.8;
        myArray[9] = 1.9;

        // Print each element individually (no loop — as required by task)
        Console.WriteLine("The element at index 0 in the array is " + myArray[0]);
        Console.WriteLine("The element at index 1 in the array is " + myArray[1]);
        Console.WriteLine("The element at index 2 in the array is " + myArray[2]);
        Console.WriteLine("The element at index 3 in the array is " + myArray[3]);
        Console.WriteLine("The element at index 4 in the array is " + myArray[4]);
        Console.WriteLine("The element at index 5 in the array is " + myArray[5]);
        Console.WriteLine("The element at index 6 in the array is " + myArray[6]);
        Console.WriteLine("The element at index 7 in the array is " + myArray[7]);
        Console.WriteLine("The element at index 8 in the array is " + myArray[8]);
        Console.WriteLine("The element at index 9 in the array is " + myArray[9]);

        Console.WriteLine();
        Console.WriteLine("--- Out-of-bounds demonstration ---");
        Console.WriteLine("Trying myArray[10] would cause an IndexOutOfRangeException.");
        Console.WriteLine("The array only has indices 0 to 9 (10 elements total).");

        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}