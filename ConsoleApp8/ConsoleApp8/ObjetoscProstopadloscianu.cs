using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class ObjetoscProstopadloscianu
    {
        public static double ObjProst()
        {
            Console.WriteLine("Wpisz najpierw obie długości krawędzi podstawy a potem  wysokość");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            return a * b * h;
        }
    }
}
