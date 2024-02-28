using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiEver.Models
{
    internal class Person
    {
        // declare the fields for name. age, city
        private string name;
        private int age;
        private string city;

        //public string Name { get { return name; } }

        // define constructor
        public Person(string name, int age, string city)
        {
            // assign the parameters to the fields
            this.name = name;
            this.age = age;
            this.city = city;
        }
        // define method that returns the name of the person
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        public string GetCity()
        {
            return city;
        }
    }
}
