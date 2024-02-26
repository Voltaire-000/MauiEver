using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MauiEver
{
    public class ThermoDTO
    {
        [JsonPropertyName("reactant")]
        public string? Reactant { get; set; }
    }
}
