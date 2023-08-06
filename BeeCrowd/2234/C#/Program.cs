using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2234
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]informações=Console.ReadLine().Split(' ');
            float[] kd;
            float porcentagem;

            kd=Array.ConvertAll(informações,float.Parse);
            porcentagem = kd[0] / kd[1];

            Console.WriteLine($"{porcentagem:0.00}");
            Console.ReadLine();

        }
    }
}
