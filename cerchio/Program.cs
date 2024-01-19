using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cerchio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cerchio c= new Cerchio();
            Console.WriteLine("inserire raggio:");
            c.Raggio = Double.Parse(Console.ReadLine());
            Console.WriteLine( "l'area è {0}", c.CalcoloArea());
            Console.WriteLine("il perimetro è {0}", c.CalcoloPerimetro());
            Console.ReadLine();
        }
    }
}
