using System;

class Car
{
    // Instance Variables
    private double mpg;          // fuel efficiency in miles per gallon
    private double fuel;         // fuel in tank (litres)
    private double totalMiles;   // total miles driven

    // Constant: cost of fuel in dollars per litre
    private const double FUEL_COST_PER_LITRE = 1.385;

    // Constructor
    public Car(double mpg)
    {
        this.mpg = mpg;
        this.fuel = 0.0;
        this.totalMiles = 0.0;
    }

    // Accessor Methods
    public double getFuel()
    {
        return this.fuel;
    }

    public double getTotalMiles()
    {
        return this.totalMiles;
    }

    // Mutator Methods
    public void setTotalMiles(double miles)
    {
        this.totalMiles = miles;
    }

    // Returns the cost of fuel as a formatted currency string
    public String printFuelCost()
    {
        return calcCost(this.fuel).ToString("C");
    }

    // Calculates and adds fuel to the tank; displays cost of fill
    public void addFuel(double litres)
    {
        this.fuel += litres;
        double cost = calcCost(litres);
        Console.WriteLine("Added " + litres + " litres. Cost: " +
                          cost.ToString("C") + ". Fuel in tank: " +
                          this.fuel.ToString("F2") + " litres.");
    }

    // Calculates cost of a given amount of fuel in litres
    public double calcCost(double litres)
    {
        return litres * FUEL_COST_PER_LITRE;
    }

    // Converts gallons to litres (1 gallon = 4.546 litres)
    public double convertToLitres(double gallons)
    {
        return gallons * 4.546;
    }

    // Simulates driving the car for a given number of miles
    public void drive(double miles)
    {
        // Update total miles
        this.totalMiles += miles;

        // Calculate fuel used: distance / mpg = gallons used
        double gallonsUsed = miles / this.mpg;
        double litresUsed = convertToLitres(gallonsUsed);

        // Deduct fuel from tank
        this.fuel -= litresUsed;

        double journeyCost = calcCost(litresUsed);
        Console.WriteLine("Drove " + miles + " miles. Journey cost: " +
                          journeyCost.ToString("C") +
                          ". Fuel remaining: " + this.fuel.ToString("F2") +
                          " litres. Total miles: " + this.totalMiles);
    }
}
