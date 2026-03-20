using System;

class Employee
{
    // Instance Variables
    private String name;
    private double salary;

    // Constructor
    public Employee(string employeeName, double currentSalary)
    {
        this.name = employeeName;
        this.salary = currentSalary;
    }

    // Accessor Methods
    public String getName()
    {
        return this.name;
    }

    public String getSalary()
    {
        return this.salary.ToString("C");
    }

    // Raise salary by a given percentage
    public void raiseSalary(double percentage)
    {
        this.salary += this.salary * (percentage / 100.0);
        Console.WriteLine(this.name + "'s salary raised by " + percentage +
                          "%. New salary: " + getSalary());
    }

    // Tax method using Australian tax brackets
    public String Tax()
    {
        double tax = 0.0;

        if (salary <= 18200)
        {
            tax = 0.0;
        }
        else if (salary <= 37000)
        {
            tax = (salary - 18200) * 0.19;
        }
        else if (salary <= 90000)
        {
            tax = 3572 + (salary - 37000) * 0.325;
        }
        else if (salary <= 180000)
        {
            tax = 20797 + (salary - 90000) * 0.37;
        }
        else
        {
            tax = 54096 + (salary - 180000) * 0.45;
        }

        return tax.ToString("C");
    }
}
