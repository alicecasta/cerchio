using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            c.Raggio = double.Parse(Console.ReadLine());
            Cerchio s= Cerchio.Parse(c.ToString());
            Console.WriteLine("il cerchio ha raggio {0}", s);

            //Console.WriteLine( "l'area è {0}", c.CalcoloArea());
            //Console.WriteLine("il perimetro è {0}", c.CalcoloPerimetro());
            Console.ReadLine();
        }
    }
}
