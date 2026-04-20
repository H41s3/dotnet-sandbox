namespace ZooParkInheritance
{
    class Tiger : Feline
    {
        private string colourStripes;

        public Tiger(string name, string diet, string location,
            double weight, int age, string colour, string species, string colourStripes)
            : base(name, diet, location, weight, age, colour, species)
        {
            this.colourStripes = colourStripes;
        }

        public override void makeNoise()
        {
            Console.WriteLine("ROAARRRRRRRRRR");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 20lbs of meat");
        }

        public override void move()
        {
            Console.WriteLine("The tiger stalks through the grass");
        }
    }
}
