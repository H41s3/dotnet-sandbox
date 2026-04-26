using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ── Part 2: Bird / Penguin / Duck objects

        Bird bird1 = new Bird();
        Bird bird2 = new Bird();
        bird1.Name = "Feathers";
        bird2.Name = "Polly";
        Console.WriteLine(bird1.ToString());
        bird1.fly();
        Console.WriteLine(bird2.ToString());
        bird2.fly();

        Penguin penguin1 = new Penguin();
        Penguin penguin2 = new Penguin();
        penguin1.Name = "Happy Feet";
        penguin2.Name = "Gloria";
        Console.WriteLine(penguin1.ToString());
        penguin1.fly();
        Console.WriteLine(penguin2.ToString());
        penguin2.fly();

        Duck duck1 = new Duck();
        duck1.Name = "Daffy";
        duck1.size = 15;
        duck1.kind = "Mallard";

        Duck duck2 = new Duck();
        duck2.Name = "Donald";
        duck2.size = 20;
        duck2.kind = "Decoy";

        Console.WriteLine(duck1.ToString());
        Console.WriteLine(duck2.ToString());

        // polymorphic List<Bird> holds Bird, Penguin, and Duck objects
        List<Bird> birds = new List<Bird>();
        birds.Add(bird1);
        birds.Add(bird2);
        birds.Add(penguin1);
        birds.Add(penguin2);
        birds.Add(duck1);
        birds.Add(duck2);
        birds.Add(new Bird { Name = "Birdy" });

        foreach (Bird bird in birds)
        {
            Console.WriteLine(bird);
        }

        // ── Part 3: Covariance via IEnumerable<Bird> ──────────────────────────

        Duck cDuck1 = new Duck();
        cDuck1.Name = "Daffy";
        cDuck1.size = 15;
        cDuck1.kind = "Mallard";

        Duck cDuck2 = new Duck();
        cDuck2.Name = "Donald";
        cDuck2.size = 20;
        cDuck2.kind = "Decoy";

        List<Duck> ducksToAdd = new List<Duck>() { cDuck1, cDuck2 };

        // covariance: a List<Duck> can be assigned to IEnumerable<Bird>
        IEnumerable<Bird> upcastDucks = ducksToAdd;

        List<Bird> allBirds = new List<Bird>();
        allBirds.Add(new Bird() { Name = "Feather" });
        allBirds.AddRange(upcastDucks);

        foreach (Bird bird in allBirds)
        {
            Console.WriteLine(bird);
        }
    }
}