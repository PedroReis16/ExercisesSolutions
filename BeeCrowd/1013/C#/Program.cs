using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1013_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]valor = Console.ReadLine().Split(' ');
            int [] valor1;
            int a, b, c;
            double maiorab, maior;

            valor1=Array.ConvertAll(valor,int.Parse);

            a = valor1[0];
            b = valor1[1];
            c = valor1[2];

            maiorab = (a + b+Math.Abs(a-b)) / 2;
            maior = (maiorab + c + Math.Abs(maiorab - c)) / 2;

            Console.Clear();
            Console.WriteLine($"{maior} eh o maior");

            Console.Read();

        }
    }
}
