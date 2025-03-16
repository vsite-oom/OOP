using OOP.Inheritance.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance.GoodExample
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string brand, string model, int year) : base(brand, model, year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

    }
}
