class Overloading
{
    static void Main(string[] args)
    {
        methodToBeOverloaded("Emilio");
        methodToBeOverloaded("Emilio", 21);
        Console.ReadLine();
    }

    public static void methodToBeOverloaded(string name)
    {
        Console.WriteLine("Name: " + name);
    }

    public static void methodToBeOverloaded(string name, int age)
    {
        Console.WriteLine("Name: " + name + "\nAge: " + age);
    }
}
