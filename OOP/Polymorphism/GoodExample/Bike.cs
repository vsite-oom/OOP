using OOP.Polymorphism.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism.GoodExample
{
    public class Bike : Vehicle
    {

        public Bike(string brand, string model, int year) : base(brand,model,year)
        {
           
        }

        public override void Start() => Console.WriteLine("Bike started");
        public override void Stop() => Console.WriteLine("Bike stopped");
        public override void Drive() => Console.WriteLine("Bike is driving");
        public void Wheelie() => Console.WriteLine("Bike is doing wheelie...");
    }
}
