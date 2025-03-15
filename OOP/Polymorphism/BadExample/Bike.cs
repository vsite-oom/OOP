namespace OOP.Polymorphism.BadExample;
public class Bike : Vehicle
{
    public Bike(string brand, string model, int year) : base(brand, model, year)
    {
    }

    public void Wheelie() => Console.WriteLine("Bike is doing a wheelie...");
}