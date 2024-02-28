using MauiEver.Models;
using Newtonsoft.Json;

namespace MauiEver.Services
{
    public class PeopleService
    {
        public List<Person>? _people;
        public PeopleService()
        { 
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/people.json");
            string json = File.ReadAllText(path);
            JsonSerializerSettings settings = new()
            {
                TraceWriter = new ConsoleTraceWriter()
            };

            _people = JsonConvert.DeserializeObject<List<Person>>(json, settings);

        }
        public List<Person> GetPeople()
        {
            return _people ?? new List<Person>();
        }
    }
}
