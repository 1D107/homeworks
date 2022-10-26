using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class ObjetoscSzescianu
    {
        public static double ObjSze()
        {
            Console.WriteLine("Wpisz długość krawędzi");
            double a = double.Parse(Console.ReadLine());
            return Math.Pow(a,3);
        }
    }
}
