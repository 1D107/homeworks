using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class PoleRownolegloboku
    {
        public static double PRown()
        {
            Console.WriteLine("Wpisz podstawe i wysokość");
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            return a * h;
        }
    }
}
