namespace OOP.Inheritance.GoodExample;
public class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public void Start() => Console.WriteLine("Vehicle started...");

    public void Stop() => Console.WriteLine("Vehicle stopped...");

    public void Drive() => Console.WriteLine("Vehicle is driving...");
}