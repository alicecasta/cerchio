using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cerchio
{
    internal class Cerchio
    {
        public Cerchio()
        {
        }

        public Cerchio(double raggio)
        {
            this.Raggio = raggio;
        }

        public double Raggio { get; set; } 
        public double CalcoloArea()
        {
            return ((Raggio * Raggio * Math.PI));
        }
        public double CalcoloPerimetro()
        {
            return (Raggio * Math.PI * 2);
        }
    }
}
