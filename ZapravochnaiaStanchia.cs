using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AddNewRaschetBenzina
{
    internal class ZapravochnaiaStanchia
    {
        public double V { get; set; }
        public ZapravochnaiaStanchia()
        {
            MessageBox.Show("Заправлено таким объемом -" + V);
        }
    }
}
