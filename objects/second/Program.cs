using System;

namespace MyApp
{
    public class House
    {
        public string Color { get; set; } = string.Empty;
        public int Rooms { get; set; } = 0;
        public bool HasGarage { get; set; } = false;

        public House(string color, int rooms, bool hasGarage)
        {
            Color = color;
            Rooms = rooms;
            HasGarage = hasGarage
        }

        public void Describe()
        {
            Console.WriteLine($"I am a {Color} house with {Rooms} rooms!");

            if (HasGarage)
                Console.WriteLine("And I have a garage! 🚗");
            else
                Console.WriteLine("No garage though 😅");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var house1 = new House("Red", 3, true);
            var house2 = new House("Blue", 5, false);

            house1.Describe();
            Console.WriteLine("---");
            house2.Describe();
        }
    }
}
