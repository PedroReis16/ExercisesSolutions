using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            float y, consumo;

            x = int.Parse(Console.ReadLine());
            y = float.Parse(Console.ReadLine());

            consumo = x / y;

            Console.WriteLine($"{consumo:0.000} km/l");

            Console.ReadKey();
        }
    }
}
