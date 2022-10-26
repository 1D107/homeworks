using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class ObjetoscStozka
    {
        public static double ObjStoz()
        {
            Console.WriteLine("Wpisz promień podstawy i wysokość");
            double r = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            return (Math.PI * Math.Pow(r, 2) * h)/3;
        }
    }
}
