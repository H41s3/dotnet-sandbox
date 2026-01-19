using System;

class Microwave
{
    static void Main()
    {
        Console.Write("Enter number of items (1-3): ");
        int items = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter heating time (seconds): ");
        double time = Convert.ToDouble(Console.ReadLine());
        
        if (items == 1)
            Console.WriteLine($"Recommended time: {time} seconds");
        else if (items == 2)
            Console.WriteLine($"Recommended time: {time * 1.5} seconds");
        else if (items == 3)
            Console.WriteLine($"Recommended time: {time * 2} seconds");
        else
            Console.WriteLine("Heating more than three items is not recommended.");
    }
}
