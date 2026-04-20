namespace ZooParkInheritance
{
    class ZooPark
    {
        static void Main(string[] args)
        {
            Tiger tonyTiger      = new Tiger("Tony the Tiger", "Meat", "Cat Land", 110, 6, "Orange and White", "Siberian", "White");
            Wolf williamWolf     = new Wolf("William the Wolf", "Meat", "Dog Village", 50.6, 9, "Grey");
            Eagle edgarEagle     = new Eagle("Edgar the Eagle", "Fish", "Bird Mania", 20, 15, "Black", "Harpy", 98.5);
            Lion leonieLion      = new Lion("Leonie the Lion", "Meat", "Savanna Enclosure", 180, 5, "Tawny", "African");
            Penguin pennyPenguin = new Penguin("Penny the Penguin", "Fish", "Polar Zone", 30, 3, "Black and White", "Emperor", 60.0);
            Animal baseAnimal    = new Animal("Animal Name", "Animal Diet", "Animal Location", 0.0, 0, "Animal Colour");

            Console.WriteLine("=== makeNoise() ===");
            tonyTiger.makeNoise();
            williamWolf.makeNoise();
            edgarEagle.makeNoise();
            pennyPenguin.makeNoise();
            leonieLion.makeNoise();
            baseAnimal.makeNoise();

            Console.WriteLine("\n=== eat() ===");
            tonyTiger.eat();
            williamWolf.eat();
            edgarEagle.eat();
            pennyPenguin.eat();
            leonieLion.eat();
            baseAnimal.eat();

            Console.WriteLine("\n=== sleep() — Feline overrides, others use base ===");
            baseAnimal.sleep();
            tonyTiger.sleep();
            leonieLion.sleep();
            williamWolf.sleep();
            edgarEagle.sleep();

            Console.WriteLine("\n=== move() ===");
            tonyTiger.move();
            williamWolf.move();
            edgarEagle.move();
            pennyPenguin.move();
            leonieLion.move();

            Console.WriteLine("\n=== Eagle-specific methods ===");
            edgarEagle.layEgg();
            edgarEagle.fly();

            Console.WriteLine("\n=== Penguin fly override ===");
            pennyPenguin.fly();

            Console.ReadLine();
        }
    }
}
