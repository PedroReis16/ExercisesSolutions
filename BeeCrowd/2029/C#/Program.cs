using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2029_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double volume, diametro, altura, area,raio, pi = 3.14;

            while (true)
            {
                do
                {
                    volume = double.Parse(Console.ReadLine());
                } while (volume <= 1.00 || volume >= 10000.00);
                do
                {
                    diametro = double.Parse(Console.ReadLine());

                } while (diametro <= 1.00 || diametro >= 100.00);

                raio = diametro / 2;


                area = pi * Math.Pow(raio,2);
                altura = volume / area;

                Console.WriteLine($"ALTURA = {altura:0.00}");
                Console.WriteLine($"AREA = {area:0.00}"+"\n");

            }
        }
    }
}
