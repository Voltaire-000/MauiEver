using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MauiEver.Models;
using Newtonsoft.Json;

namespace MauiEver.Services
{
    internal class PeopleService
    {
        private List<Person>? _people;
        public PeopleService()
        { 
            
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/people.json");
            string json = File.ReadAllText(path);

            var settings = new JsonSerializerSettings
            {
                TraceWriter = new ConsoleTraceWriter()
            };

            _people = JsonConvert.DeserializeObject<List<Person>>(json);

            
        }
        public List<Person> GetPeople()
        {
            return _people;
        }


    }
}
