using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1036___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]valor=Console.ReadLine().Split(' ');
            double[] numero;
            double a, b, c, delta, x1,x2;

            numero = Array.ConvertAll(valor,double.Parse);

            a = numero[0];
            b = numero[1];
            c = numero[2];

            delta = Math.Pow(b, 2) - 4 * (a) * (c);

            if(2*a <= 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else 
            {
                x1 = ((-b + Math.Sqrt(delta)) / 2 * a) / (100);
                x2 = ((-b - Math.Sqrt(delta)) / 2 * a) / (100);

                Console.WriteLine($"R1 = {x1:0.00000}");
                Console.WriteLine($"R2 = {x2:0.00000}");
            }
            Console.Read();
        }
    }
}
