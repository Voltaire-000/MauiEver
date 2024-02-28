using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiEver.Models
{
    // A class that represents a person
    public class Person(string name, int age, string city)
    {
        // Declare the properties for name, age, and city
        public string Name { get; } = name;
        public int Age { get; } = age;
        public string City { get; } = city;

        // Define a method that returns the name of the person
        public string GetName() => Name;

        // Define a method that returns the age of the person
        public int GetAge() => Age;

        // Define a method that returns the city of the person
        public string GetCity() => City;
    }

}
