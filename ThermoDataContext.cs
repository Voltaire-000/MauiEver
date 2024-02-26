using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MauiEver
{
    public class ThermoDataContext
    {
        //[Newtonsoft.Json.JsonIgnore]
        //public string Thermo { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        public ThermoDataContext thermo { get; set; }
        [JsonPropertyName("reactant")]
        public required string Reactant { get; set; }
        [JsonPropertyName("description")]
        public required string Description { get; set; }
        [JsonPropertyName("t_intervals")]
        public int TIntervals { get; set; }
        [JsonPropertyName("id_code")]
        public required string IdCode { get; set; }
        [JsonPropertyName("chemicalFormula")]
        public required Dictionary<string, double> ChemicalFormula { get; set; }
        [JsonPropertyName("gaseous")]
        public bool Gaseous { get; set; }
        [JsonPropertyName("molecularWeight")]
        public double MolecularWeight { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        public double HeatOfFormation { get; set; }
        [JsonPropertyName("temperatureRange")]
        public required Dictionary<string, Range> TemperatureRange { get; set; }
    }

    public class Range
    {
        public required List<double> TemperatureRange { get; set; }
        public int NumberOfCoefficients { get; set; }
        public required List<double> TExponents { get; set; }
        public double Jmol { get; set; }
        public required List<double> Coefficients { get; set; }
        public required List<double> IntegrationConstants { get; set; }
    }
}
