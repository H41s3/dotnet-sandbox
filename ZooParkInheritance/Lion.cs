namespace ZooParkInheritance
{
    class Lion : Feline
    {
        public Lion(string name, string diet, string location,
            double weight, int age, string colour, string species)
            : base(name, diet, location, weight, age, colour, species) { }

        public override void makeNoise()
        {
            Console.WriteLine("ROAAARRR!");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 15lbs of meat");
        }

        public override void move()
        {
            Console.WriteLine("The lion prowls across the savanna");
        }
    }
}
