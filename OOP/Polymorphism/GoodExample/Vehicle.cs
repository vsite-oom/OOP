using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism.GoodExample
{
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

        public virtual void Start()
        {
            Console.WriteLine("Vehicle started");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicle stopped");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Vehicle is driving");
        }
    }
}
