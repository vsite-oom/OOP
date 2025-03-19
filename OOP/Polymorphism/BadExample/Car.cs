﻿namespace OOP.Polymorphism.BadExample;
public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public void Start() => Console.WriteLine("Car started...");

    public void Stop() => Console.WriteLine("Car stopped...");

    public void Drive() => Console.WriteLine("Car is driving...");
}