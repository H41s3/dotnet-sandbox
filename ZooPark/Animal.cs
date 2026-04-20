namespace ZooPark
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

        public void eat()
        {
            Console.WriteLine(name + " is eating.");
        }

        public void sleep()
        {
            Console.WriteLine(name + " is sleeping.");
        }

        public void makeNoise()
        {
            Console.WriteLine(name + " makes a noise.");
        }

        // Animal-specific noise methods — cluttered but showing the problem
        public void makeLionNoise()
        {
            Console.WriteLine(name + " ROAARRRR!");
        }

        public void makeEagleNoise()
        {
            Console.WriteLine(name + " SCREEEE!");
        }

        public void makeWolfNoise()
        {
            Console.WriteLine(name + " AWOOOO!");
        }

        // Animal-specific eating methods — also cluttered
        public void eatMeat()
        {
            Console.WriteLine(name + " eats meat.");
        }

        public void eatBerries()
        {
            Console.WriteLine(name + " eats berries.");
        }
    }
}
