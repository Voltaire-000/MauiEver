using MauiEver.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiEver.Services
{
    public class ReactantService
    {
        public List<Reactant>? ReactantList { get; set; }

        public ReactantService() 
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/shortThermo.json");
            string json = File.ReadAllText(path);
            JsonSerializerSettings settings = new()
            {
                TraceWriter = new ConsoleTraceWriter()
            };

            ReactantList = JsonConvert.DeserializeObject<List<Reactant>>(json, settings);
        }
        public List<Reactant> GetReactants()
        {
            return ReactantList ?? new List<Reactant>();
        }
    }
}
