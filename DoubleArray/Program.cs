using System;
using System.Collections.Generic;

class Program
{
    // checks if an int array is a palindrome
    // returns false if the array is empty
    static bool Palindrome(int[] array)
    {
        if (array.Length < 1)
            return false;

        for (int i = 0; i < array.Length / 2; i++)
        {
            int mirrorIndex = array.Length - 1 - i;

            if (array[i] != array[mirrorIndex])
                return false;
        }

        return true;
    }

    // helper for Merge - checks if a list is sorted in ascending order
    static bool IsSorted(List<int> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] > list[i + 1])
                return false;
        }
        return true;
    }

    // merges two sorted lists into one sorted list
    // returns null if either list is unsorted
    static List<int> Merge(List<int> list_a, List<int> list_b)
    {
        if (!IsSorted(list_a) || !IsSorted(list_b))
            return null;

        List<int> merged = new List<int>();

        int a = 0;
        int b = 0;

        while (a < list_a.Count && b < list_b.Count)
        {
            if (list_a[a] <= list_b[b])
                merged.Add(list_a[a++]);
            else
                merged.Add(list_b[b++]);
        }

        while (a < list_a.Count)
            merged.Add(list_a[a++]);

        while (b < list_b.Count)
            merged.Add(list_b[b++]);

        return merged;
    }

    // extracts all odd values from a 2D array, scanned column by column
    static int[] ArrayConversion(int[,] array)
    {
        List<int> oddValues = new List<int>();

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int col = 0; col < cols; col++)
        {
            for (int row = 0; row < rows; row++)
            {
                if (array[row, col] % 2 != 0)
                    oddValues.Add(array[row, col]);
            }
        }

        return oddValues.ToArray();
    }

    static void Main(string[] args)
    {
        //declares an array of type double with 10 elements
        double[] myArray = new double[10];

        //assigning the first element of the array
        myArray[0] = 1.0;
        //assigning the second element of the array
        myArray[1] = 1.1;
        myArray[2] = 1.2;
        myArray[3] = 1.3;
        myArray[4] = 1.4;
        myArray[5] = 1.5;
        myArray[6] = 1.6;
        myArray[7] = 1.7;
        myArray[8] = 1.8;
        myArray[9] = 1.9;

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

        //declares an array of type integer with 10 elements
        int[] myIntArray = new int[10];

        for (int i = 0; i < 10; i++)
        {
            myIntArray[i] = i;
        }

        // for loop to print the values in the array
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("The element at position " + i + " in the array is " + myIntArray[i]);
        }

        int[] studentArray = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };

        // total is declared outside the loop so we can use it after the loop
        int total = 0;

        for (int i = 0; i < studentArray.Length; i++)
        {
            total += studentArray[i];
        }

        Console.WriteLine("The total marks for the student is: " + total);
        Console.WriteLine("This consist of " + studentArray.Length + " marks");
        Console.WriteLine("Therefore the average mark is " + (total / studentArray.Length));

        string[] studentNames = new string[6];

        for (int i = 0; i < studentNames.Length; i++)
        {
            Console.Write("Enter name of student " + (i + 1) + ": ");
            studentNames[i] = Console.ReadLine();
        }

        for (int i = 0; i < studentNames.Length; i++)
        {
            Console.WriteLine(studentNames[i]);
        }

        double[] valuesArray = new double[10];
        int currentSize = 0;
        double currentLargest;
        double currentSmallest;

        for (int i = 0; i < valuesArray.Length; i++)
        {
            Console.Write("Enter value " + (i + 1) + ": ");
            valuesArray[i] = double.Parse(Console.ReadLine());
            currentSize++;
        }

        // start by assuming the first element is both largest and smallest
        currentLargest = valuesArray[0];
        currentSmallest = valuesArray[0];

        for (int i = 0; i < valuesArray.Length; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + valuesArray[i]);

            if (valuesArray[i] > currentLargest)
                currentLargest = valuesArray[i];

            if (valuesArray[i] < currentSmallest)
                currentSmallest = valuesArray[i];
        }

        Console.WriteLine("The largest value is: " + currentLargest);
        Console.WriteLine("The smallest value is: " + currentSmallest);

        int[,] myArray2D = new int[3, 4] { { 1, 2, 3, 4 }, { 1, 1, 1, 1 }, { 2, 2, 2, 2 } };

        int value = myArray2D[2, 3];
        Console.WriteLine("myArray2D[2,3] = " + value);

        for (int i = 0; i < myArray2D.GetLength(0); i++)
        {
            for (int j = 0; j < myArray2D.GetLength(1); j++)
            {
                Console.Write(myArray2D[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // lists don't need a fixed size and use .Count instead of .Length
        List<string> myStudentList = new List<string>();

        Random randomValue = new Random();
        int randomNumber = randomValue.Next(1, 12);

        Console.WriteLine("You now need to add " + randomNumber + " students to your class list");

        for (int i = 0; i < randomNumber; i++)
        {
            Console.Write("Please enter the name of Student " + (i + 1) + ": ");
            myStudentList.Add(Console.ReadLine());
            Console.WriteLine();
        }

        for (int i = 0; i < myStudentList.Count; i++)
        {
            Console.WriteLine(myStudentList[i]);
        }

        int[] palTest1 = { 1, 2, 2, 1 };
        int[] palTest2 = { 1, 2, 3, 1, 3, 2, 1 };
        int[] palTest3 = { 3, 2, 1 };
        int[] palTest4 = { 5 };
        int[] palTest5 = { };

        Console.WriteLine("Palindrome {1,2,2,1}: " + Palindrome(palTest1));
        Console.WriteLine("Palindrome {1,2,3,1,3,2,1}: " + Palindrome(palTest2));
        Console.WriteLine("Palindrome {3,2,1}: " + Palindrome(palTest3));
        Console.WriteLine("Palindrome {5}: " + Palindrome(palTest4));
        Console.WriteLine("Palindrome {}: " + Palindrome(palTest5));

        List<int> listA = new List<int> { 1, 2, 2, 5 };
        List<int> listB = new List<int> { 1, 3, 4, 5, 7 };
        List<int> listEmpty = new List<int>();
        List<int> listUnsorted = new List<int> { 5, 2, 2, 1 };

        List<int> mergeResult1 = Merge(listA, listB);
        List<int> mergeResult2 = Merge(listA, listEmpty);
        List<int> mergeResult3 = Merge(listUnsorted, listB);

        Console.WriteLine("Merge {1,2,2,5} + {1,3,4,5,7}: " +
            (mergeResult1 != null ? string.Join(", ", mergeResult1) : "null"));

        Console.WriteLine("Merge {1,2,2,5} + {}: " +
            (mergeResult2 != null ? string.Join(", ", mergeResult2) : "null"));

        Console.WriteLine("Merge {5,2,2,1} + {1,3,4,5,7}: " +
            (mergeResult3 != null ? string.Join(", ", mergeResult3) : "null"));

        int[,] conversionInput = {
            { 0, 2, 4, 0, 9, 5 },
            { 7, 1, 3, 3, 2, 1 },
            { 1, 3, 9, 8, 5, 6 },
            { 4, 6, 7, 9, 1, 0 }
        };

        int[] conversionResult = ArrayConversion(conversionInput);

        Console.WriteLine("ArrayConversion result: " + string.Join(", ", conversionResult));
    }
}