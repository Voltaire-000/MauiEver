using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiEver
{
    public class thermo
    {
        public required string reactant { get; set; }
        public required string description { get; set; }

        public int t_intervals { get; set; }
        public required string id_code { get; set; }
        public required Dictionary<string, double> chemicalFormula { get; set; }
        public bool gaseous { get; set; }
        public double molecularWeight { get; set; }
        public double heatOfFormation { get; set; }
        public required Dictionary<string, Range> temperatureRange { get; set; }
    }

    public class Range
    {
        public required List<double> temperatureRange { get; set; }
        public int numberOfCoefficients { get; set; }
        public required List<double> tExponents { get; set; }
        //public double Jmol { get; set; }
        public required List<double> coefficients { get; set; }
        public required List<double> integrationConstants { get; set; }
    }
}
