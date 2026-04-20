namespace ZooParkInheritance
{
    class Feline : Animal
    {
        private string species;

        public Feline(string name, string diet, string location,
            double weight, int age, string colour, string species)
            : base(name, diet, location, weight, age, colour)
        {
            this.species = species;
        }

        // Felines sleep differently — they curl up
        public override void sleep()
        {
            Console.WriteLine("The feline curls up and sleeps");
        }
    }
}
