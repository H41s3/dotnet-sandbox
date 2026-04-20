namespace ZooPark
{
    class ZooPark
    {
        static void Main(string[] args)
        {
            Animal williamWolf = new Animal("William the Wolf", "Meat", "Dog Village", 50.6, 9, "Grey");
            Animal tonyTiger = new Animal("Tony the Tiger", "Meat", "Cat Land", 110.0, 6, "Orange and White");
            Animal edgarEagle = new Animal("Edgar the Eagle", "Fish", "Bird Mania", 20.0, 15, "Black");

            Console.WriteLine("Part 1: Animals without inheritance\n");

            williamWolf.eat();
            williamWolf.makeNoise();
            williamWolf.makeWolfNoise();

            tonyTiger.eat();
            tonyTiger.makeNoise();
            tonyTiger.makeLionNoise(); // Wolf can call this too — that's the problem!

            edgarEagle.eat();
            edgarEagle.makeNoise();
            edgarEagle.makeEagleNoise();

            Console.ReadLine();
        }
    }
}
