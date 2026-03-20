using System;

class EmployeeProgram
{
    static void Main(string[] args)
    {
        // ── Test 1: Under tax-free threshold
        Employee emp1 = new Employee("Alice Smith", 15000);
        Console.WriteLine("Name: " + emp1.getName());
        Console.WriteLine("Salary: " + emp1.getSalary());
        Console.WriteLine("Tax: " + emp1.Tax());

        // ── Test 2: 19% bracket
        Console.WriteLine();
        Employee emp2 = new Employee("Bob Jones", 30000);
        Console.WriteLine("Name: " + emp2.getName());
        Console.WriteLine("Salary: " + emp2.getSalary());
        Console.WriteLine("Tax: " + emp2.Tax());

        // ── Test 3: 32.5% bracket
        Console.WriteLine();
        Employee emp3 = new Employee("Carol White", 65000);
        Console.WriteLine("Name: " + emp3.getName());
        Console.WriteLine("Salary: " + emp3.getSalary());
        Console.WriteLine("Tax: " + emp3.Tax());
        emp3.raiseSalary(10);   // 10% raise
        Console.WriteLine("Tax after raise: " + emp3.Tax());

        // ── Test 4: 37% bracket
        Console.WriteLine();
        Employee emp4 = new Employee("David Brown", 120000);
        Console.WriteLine("Name: " + emp4.getName());
        Console.WriteLine("Salary: " + emp4.getSalary());
        Console.WriteLine("Tax: " + emp4.Tax());

        // ── Test 5: 45% bracket
        Console.WriteLine();
        Employee emp5 = new Employee("Eva Green", 250000);
        Console.WriteLine("Name: " + emp5.getName());
        Console.WriteLine("Salary: " + emp5.getSalary());
        Console.WriteLine("Tax: " + emp5.Tax());

        Console.ReadLine();
    }
}
