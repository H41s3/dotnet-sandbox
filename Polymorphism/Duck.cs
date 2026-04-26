using System;

public class Duck : Bird
{
    public double size { get; set; }
    public string kind { get; set; }

    public override string ToString()
    {
        return "A duck named " + base.Name + " is a " + size + " inch " + kind;
    }
}