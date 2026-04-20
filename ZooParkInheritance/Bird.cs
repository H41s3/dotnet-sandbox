namespace ZooParkInheritance
{
    class Bird : Animal
    {
        protected string birdSpecies;
        protected double wingSpan;

        public Bird(string name, string diet, string location,
            double weight, int age, string colour, string birdSpecies, double wingSpan)
            : base(name, diet, location, weight, age, colour)
        {
            this.birdSpecies = birdSpecies;
            this.wingSpan = wingSpan;
        }

        public virtual void fly()
        {
            Console.WriteLine("The bird flies");
        }

        public override void move()
        {
            Console.WriteLine("The bird flaps its wings and moves");
        }
    }
}
