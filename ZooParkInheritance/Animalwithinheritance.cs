namespace ZooParkInheritance
{
    class Animal
    {
        private string name;
        private string diet;
        private string location;
        private double weight;
        private int age;
        private string colour;

        public Animal(string name, string diet, string location,
            double weight, int age, string colour)
        {
            this.name = name;
            this.diet = diet;
            this.location = location;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
        }

        public virtual void eat()
        {
            Console.WriteLine("An animal eats");
        }

        public virtual void sleep()
        {
            Console.WriteLine("An animal sleeps");
        }

        public virtual void makeNoise()
        {
            Console.WriteLine("An animal makes a noise");
        }

        // Part 3 Step 5: new virtual method all animals share — move()
        public virtual void move()
        {
            Console.WriteLine("An animal moves");
        }
    }
}
