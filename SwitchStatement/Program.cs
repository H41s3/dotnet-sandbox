using System;

class SwitchStatement
{
    static void Main()
    {
        Console.Write("Enter a number (1-9): ");
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int number))
        {
            switch (number)
            {
                case 1: Console.WriteLine("ONE"); break;
                case 2: Console.WriteLine("TWO"); break;
                case 3: Console.WriteLine("THREE"); break;
                case 4: Console.WriteLine("FOUR"); break;
                case 5: Console.WriteLine("FIVE"); break;
                case 6: Console.WriteLine("SIX"); break;
                case 7: Console.WriteLine("SEVEN"); break;
                case 8: Console.WriteLine("EIGHT"); break;
                case 9: Console.WriteLine("NINE"); break;
                default: Console.WriteLine("Error: Number out of range."); break;
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid input.");
        }
    }
}
