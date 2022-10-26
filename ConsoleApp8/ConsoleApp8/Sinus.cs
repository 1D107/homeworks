using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Sinus
    {
        public static double Sin()
        {
            Console.WriteLine("Wpisz trzy boki swojego trójkąta, najpierw przyprostokątna nieprzyległa do kąta, potem następna przyprostokątna, na końcu przeciwprostokątną");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            return a/c;
        }
    }
}
