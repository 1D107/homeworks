using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class ObjetoscOstroslupa
    {
        public static double ObjOstr()
        {
            Console.WriteLine("Wpisz długość krawędzi podstawy i wysokość");
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            return 1/3 * Math.Pow(a, 2) * h;
        }
    }
}
