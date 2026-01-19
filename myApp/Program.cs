using System;

namespace myApp {
    class Program {
        static void Main() {
            int result1, result4, result5;
            bool result2, result3;
            int x = 10, y = 5;

            // Using Arithmetic Operator
            result1 = x + y;
            Console.WriteLine("Addition: " + result1);

            // Using Relational Operator
            result2 = (x == y);
            Console.WriteLine("Equal to Operator: " + result2);

            bool a = true, b = false;
            // Using Logical Operator
            result3 = a && b;
            Console.WriteLine("Logical AND Operator: " + result3);

            // Using Bitwise Operator
            result4 = x & y;
            Console.WriteLine("Bitwise AND Operator: " + result4);

            // Using Assignment Operator
            int m = 15;

            m += 10;
            Console.WriteLine("Add Assignment Operator: " + m);

            // Using Conditional Operator
            // To find which value is greater
            result5 = x < y ? x : y;
            Console.WriteLine("Result: " + result5);
        }
    }
}

