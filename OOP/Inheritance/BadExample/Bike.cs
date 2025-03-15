namespace OOP.Inheritance.BadExample;

class Bike
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Bike(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public void Start()
    {
        Console.WriteLine("Bike started");
    }

    public void Stop()
    {
        Console.WriteLine("Bike stopped");
    }

    public void Drive()
    {
        Console.WriteLine("Bike is driving");
    }
}
