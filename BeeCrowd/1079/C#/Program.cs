using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            int u = 0;
            string[] notas;
            double[] num;
            double media;

            while (u < i)
            {
                u++;

                notas = Console.ReadLine().Split(' ');

                num = Array.ConvertAll(notas, double.Parse);

                media = (num[0] * 2 + num[1] * 3 + num[2] * 5) / 10;


                Console.WriteLine($"{media: 0.0}");
            }
            Console.Read();
        }
    }
}
