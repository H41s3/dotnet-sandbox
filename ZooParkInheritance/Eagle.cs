namespace ZooParkInheritance
{
    class Eagle : Bird
    {
        public Eagle(string name, string diet, string location,
            double weight, int age, string colour, string birdSpecies, double wingSpan)
            : base(name, diet, location, weight, age, colour, birdSpecies, wingSpan) { }

        public override void makeNoise()
        {
            Console.WriteLine("SCREEEE!");
        }

        public override void eat()
        {
            Console.WriteLine("I eat 1lb of fish");
        }

        public override void fly()
        {
            Console.WriteLine("The eagle soars high on the thermals");
        }

        public void layEgg()
        {
            Console.WriteLine("The eagle lays an egg");
        }

        public override void move()
        {
            Console.WriteLine("The eagle swoops down from the sky");
        }
    }
}
