using System;

// SIT232 - Practical Task 1.2
// Task 5: Rewriting while loops as equivalent for loops

class ForLoopRewrite
{
    static void Main(string[] args)
    {
        // =============================================
        // FRAGMENT 1 - ORIGINAL (while version)
        // Accumulates sum, stopping when sum exceeds 350
        // j starts at -5 and increases by 5 each iteration
        // =============================================

        // NOTE: This one is condition-driven (sum <= 350), not count-driven.
        // A for loop CAN be used, but while is more natural here.
        // We convert it faithfully anyway.

        Console.WriteLine("=== Fragment 1: While → For ===");

        int sum = 0;
        int j = -5;

        // For loop: init=j=-5, condition=sum<=350, update=j+=5
        // We update j in the for header and sum inside the body
        for (; sum <= 350; j += 5)
        {
            sum += j;
        }

        Console.WriteLine("Final sum: " + sum);
        Console.WriteLine("Final j:   " + j);

        // =============================================
        // FRAGMENT 2 - ORIGINAL (while version)
        // Prints multiples of 5 from 0 to 495
        // =============================================
        Console.WriteLine("\n=== Fragment 2: While → For ===");

        // Clean, readable for loop — init x=0, run while x<500, step x+=5
        for (int x = 0; x < 500; x = x + 5)
        {
            Console.WriteLine(x);
        }
    }
}
