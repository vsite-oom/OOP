namespace OOP.Polymorphism.BadExample;
public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    public Car(string brand, string model, int year) : base(brand, model, year)
    {
    }
}
