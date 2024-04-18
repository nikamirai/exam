using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNewRaschetBenzina
{
    internal class Toplivo
    {
        public double V { get; set; }
        public double P { get; set; }

        public double Mass(string V , string P) 
        {
            double mass;
            return mass = Convert.ToDouble(V) * Convert.ToDouble(P);
        }
    }
}
