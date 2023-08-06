using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1012_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double[] valor;
            double A, B, C;
            double triangulo, circulo, trapezio, quadrado, retangulo;
            double pi = 3.14159;

            valor = Array.ConvertAll(valores, double.Parse);
            A = valor[0];
            B = valor[1];
            C = valor[2];

            triangulo = (A * C) / 2;
            circulo = pi * Math.Pow(C, 2);
            trapezio = ((A + B) * C) / 2;
            quadrado = Math.Pow(B, 2);
            retangulo = A * B;

            Console.WriteLine($"TRIANGULO: {triangulo:0.000}");
            Console.WriteLine($"CIRCULO: {circulo:0.000}");
            Console.WriteLine($"TRAPEZIO: {trapezio:0.000}");
            Console.WriteLine($"QUADRADO: {quadrado:0.000}");
            Console.WriteLine($"RETANGULO: {retangulo:0.000}");
            
            Console.ReadKey();

        }
    }
}
