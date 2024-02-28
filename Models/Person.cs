using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiEver.Models
{
    // A class that represents a person
    public class Person
    {
        // Declare the properties for name, age, and city
        public string Name { get; }
        public int Age { get; }
        public string City { get; }

        // Define a constructor that takes the name, age, and city as parameters
        public Person(string name, int age, string city)
        {
            // Assign the parameters to the properties
            Name = name;
            Age = age;
            City = city;
        }

        // Define a method that returns the name of the person
        public string GetName() => Name;

        // Define a method that returns the age of the person
        public int GetAge() => Age;

        // Define a method that returns the city of the person
        public string GetCity() => City;
    }

}
