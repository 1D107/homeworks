using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class PedFotonu
    {
        public static double PedFot()
        {
            Console.WriteLine("pisz stałą Plancka i długość fali");
            double gamma = double.Parse(Console.ReadLine());
            return (double)double.Parse(Console.ReadLine()) / gamma;
        }
    }
}
