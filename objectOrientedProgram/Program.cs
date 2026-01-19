using System;

namespace AnimalSystem
{
    // Base class
    public class Animal
    {
        public string Name { get; set; }
        
        // Constructor
        public Animal(string name)
        {
            this.Name = name;
        }
        
        // Virtual method that can be overridden
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }

    // Derived class
    public class Dog : Animal
    {
        public string Breed { get; set; }
        
        // Constructor calling base class constructor
        public Dog(string name, string breed) : base(name)
        {
            this.Breed = breed;
        }
        
        // Override the virtual method
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }

    static class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the base class
            Animal genericAnimal = new Animal("Generic");
            Console.WriteLine($"Animal name: {genericAnimal.Name}");
            genericAnimal.MakeSound();
            
            // Create an instance of the derived class
            Dog myDog = new Dog("Peanut", "Shih Tzu");
            Console.WriteLine($"\nDog name: {myDog.Name}");
            Console.WriteLine($"Dog breed: {myDog.Breed}");
            myDog.MakeSound();
        }
    }
}
