using namespace;

public class Car
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public Car(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public void Describe() => Console.WriteLine($"{Brand} goes {Speed} mph!");
}

// Usage
var car1 = new Car("Toyota", 120);
    var car2 = new Car("Ferrari", 220);

car1.Describe(); // Toyota goes 120 mph!
car2.Describe(); // Ferrari goes 220 mph! 🏎️
