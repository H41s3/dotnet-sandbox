using System;

public class Bird
{
    public string Name { get; set; }

    public Bird() { }

    public virtual void fly()
    {
        Console.WriteLine("Flap, Flap, Flap");
    }

    public override string ToString()
    {
        return "A bird called " + Name;
    }
}