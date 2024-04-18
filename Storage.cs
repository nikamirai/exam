using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNewRaschetBenzina
{
    internal class Storage
    {
        public double V { get; set; }
        public double Zapas { get; set; }
        public double StorageV() 
        {
            double Dostup;
            return Dostup = V - Zapas;    
        }
    }
}
