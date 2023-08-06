using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] p1 = Console.ReadLine().Split(' ');
            string[] p2 = Console.ReadLine().Split(' ');
            double[] p12;
            double[] p22;
            double x1, x2, y1, y2, sub, sub1, elev, elev1, soma, raiz;

            p12 = Array.ConvertAll(p1, double.Parse);
            p22 = Array.ConvertAll(p2, double.Parse);

            x1 = p12[0];
            x2 = p22[0];
            y1 = p12[1];
            y2 = p22[1];

            sub = x2 - x1;
            sub1 = y2 - y1;

            elev = Math.Pow(sub, 2);
            elev1 = Math.Pow(sub1, 2);

            soma = elev + elev1;

            raiz = Math.Sqrt(soma);

            Console.Clear();
            Console.WriteLine($"{raiz:0.0000}");
            Console.Read();

        }
    }
}
