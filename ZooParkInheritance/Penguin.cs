namespace ZooParkInheritance
{
    class Penguin : Bird
    {
        public Penguin(string name, string diet, string location,
            double weight, int age, string colour, string birdSpecies, double wingSpan)
            : base(name, diet, location, weight, age, colour, birdSpecies, wingSpan) { }

        public override void makeNoise()
        {
            Console.WriteLine("SQUAWK!");
        }

        public override void eat()
        {
            Console.WriteLine("I eat 2lbs of fish");
        }

        public override void fly()
        {
            Console.WriteLine("Penguins cannot fly, but I can swim!");
        }

        public override void move()
        {
            Console.WriteLine("The penguin waddles along the ice");
        }
    }
}
