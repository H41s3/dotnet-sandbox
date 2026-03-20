using System;

class CarProgram
{
    static void Main(string[] args)
    {
        // Create a car with 40 mpg fuel efficiency
        Car myCar = new Car(40.0);

        // Test getFuel and getTotalMiles on a new car (should be 0)
        Console.WriteLine("New Car");
        Console.WriteLine("Fuel in tank: " + myCar.getFuel() + " litres");
        Console.WriteLine("Total miles driven: " + myCar.getTotalMiles());

        // Test addFuel
        Console.WriteLine("\nAdding Fuel");
        myCar.addFuel(30.0);    // add 30 litres
        myCar.addFuel(10.0);    // add another 10 litres

        // Test printFuelCost (cost of all fuel currently in tank)
        Console.WriteLine("\nTotal value of fuel in tank: " + myCar.printFuelCost());

        // Test setTotalMiles
        myCar.setTotalMiles(1000);
        Console.WriteLine("Total miles (after manual set): " + myCar.getTotalMiles());

        // Test drive
        Console.WriteLine("\nDriving");
        myCar.drive(50);    // drive 50 miles
        myCar.drive(100);   // drive 100 miles
        myCar.drive(30);    // drive 30 miles

        // Final state
        Console.WriteLine("\nFinal State");
        Console.WriteLine("Fuel remaining: " + myCar.getFuel().ToString("F2") + " litres");
        Console.WriteLine("Total miles: " + myCar.getTotalMiles());
        Console.WriteLine("Current fuel value: " + myCar.printFuelCost());

        Console.ReadLine();
    }
}
