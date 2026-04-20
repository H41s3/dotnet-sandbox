namespace ZooParkInheritance
{
    class Wolf : Animal
    {
        public Wolf(string name, string diet, string location,
            double weight, int age, string colour)
            : base(name, diet, location, weight, age, colour) { }

        public override void eat()
        {
            Console.WriteLine("I can eat 10lbs of meat");
        }

        public override void makeNoise()
        {
            Console.WriteLine("AWOOOOOO!");
        }

        public override void move()
        {
            Console.WriteLine("The wolf sprints through the forest");
        }
    }
}
