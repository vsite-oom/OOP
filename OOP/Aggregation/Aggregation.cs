using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Aggregation;

public class Aggregation
{
    public class Address
    {
        public string Street {  get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public Address(string street, string city, string zipCode)
        {
            Street = street;
            City = city;
            PostalCode = zipCode;
        }
    }


    public class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public Person(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public void Display()
        {
            Console.WriteLine("Ime " + Name);
            Console.WriteLine("Address " + Address.Street + " " + Address.City);
        }
    }

    public static void Main()
    {
        Address address = new("Neka Ulica", "Neki Grad", "zip");
        Person person = new("Ime", address);

        person.Display();

    }
}
