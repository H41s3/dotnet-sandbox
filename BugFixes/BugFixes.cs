using System;

// SIT232 - Practical Task 1.2
// Task 4: Finding and fixing buggy code snippets
// Each snippet is shown with its bug explained, then fixed below it

class BugFixes
{
    static void Main(string[] args)
    {
        // =============================================
        // SNIPPET 1: Missing curly braces
        // BUG: No braces around the while body - only product = product*5
        //      is looped. c never increments inside the loop → infinite loop.
        //      Also, product starts at 0 so 0 * 5 = 0 forever (logic bug too).
        // FIX: Add braces AND initialise product to 1 if we want multiplication.
        // =============================================
        int c = 0, product = 1; // changed 0→1 so multiplication makes sense
        while (c <= 5)
        {
            product = product * 5; // now both lines are inside the loop
            c = c + 1;
        }
        Console.WriteLine("Final product: " + product); // 5^6 = 15625

        // =============================================
        // SNIPPET 2: Infinite loop — a and b never meet
        // BUG: a=31 (odd), b starts at 0 and increments by 2 (always even).
        //      An odd number never equals an even number → loop never ends.
        // FIX: Change condition to (a > b) or make b increment by 1.
        // =============================================

        int a = 31, b = 0, sum = 0;
        while (a > b) // fixed: was (a != b), which caused infinite loop
        {
            sum = sum + a;
            b = b + 2;
        }
        Console.WriteLine("Sum: " + sum);

        // =============================================
        // SNIPPET 3: Uninitialised variable
        // BUG: 'total' is declared but never assigned a starting value.
        //      C# won't compile — you can't use an uninitialised local variable.
        // FIX: Initialise total = 0;
        // =============================================

        int x = 1;
        int total = 0; // fixed: was just "int total;" — must initialise!
        while (x <= 10)
        {
            total = total + x;
            x = x + 1;
        }
        Console.WriteLine("Total: " + total); // 55

        // =============================================
        // SNIPPET 4: Variable declared inside the loop (wrong scope)
        // BUG: 'y' is declared inside the while block but the condition
        //      uses 'y' before it exists. Won't compile.
        // FIX: Declare y before the loop.
        // =============================================

        int y = 0; // fixed: moved declaration OUTSIDE the loop
        while (y < 10)
        {
            Console.WriteLine("y: " + y); // fixed: was "y" + y (string concat, not variable)
            y = y + 1;
        }

        // =============================================
        // SNIPPET 5: Loop body never executes
        // BUG: z = 0, condition is (z > 0) — false immediately. Loop never runs.
        // FIX: Change condition to (z >= 0) or start z at a positive value.
        //      Depends on intent; here we assume we want to count down from 5.
        // =============================================

        int z = 5; // fixed: changed starting value so the condition is true
        while (z > 0)
        {
            z = z - 1;
            Console.WriteLine("z: " + z);
        }

        // =============================================
        // SNIPPET 6: Wrong separators in for loop header
        // BUG: for(int count = 1, count < 100, count++) — uses commas.
        //      C# for loops use semicolons to separate the three parts.
        // FIX: Replace commas with semicolons.
        // =============================================

        for (int count = 1; count < 100; count++) // was commas, changed to semicolons
        {
            // printing every iteration would flood the console, so I just show first/last
            if (count == 1 || count == 99)
                Console.WriteLine("Hello (iteration " + count + ")");
        }

        // =============================================
        // SNIPPET 7: Two bugs — wrong variable name case + wrong condition direction
        // BUG 1: Declared "int I" but used "i" — C# is case-sensitive. Won't compile.
        // BUG 2: Condition is i > 10 but i starts at 1 → loop never runs.
        //        Should be i <= 10 to count up to 10.
        // FIX: Lowercase 'i' throughout, fix condition to i <= 10.
        // =============================================

        for (int i = 1; i <= 10; i++) // fixed: capital I→i, >10 changed to <=10
        {
            if (i > 2)
            {
                Console.WriteLine("Flower"); // prints for i = 3..10 (8 times)
            }
        }
    }
}
