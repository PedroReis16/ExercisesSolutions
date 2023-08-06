using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1011_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float raio;
            double VOLUME,r;

            raio = float.Parse(Console.ReadLine());

            r = raio * raio * raio;

            VOLUME = (r * 3.14159 *4)  / 3;

            Console.WriteLine($"VOLUME = {VOLUME:0.000}");
            Console.ReadLine();


            
        }
    }
}
