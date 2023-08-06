using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valor = Console.ReadLine().Split(' ');
            int[] valor1;
            int a, b, c, d;
            int soma, soma1;

            valor1=Array.ConvertAll(valor,int.Parse);
            a = valor1[0];
            b = valor1[1];
            c = valor1[2];
            d = valor1[3];

            soma = c + d;
            soma1 = a + b;
            Console.Clear();

            if(b>c && d>a && soma >soma1 && c>0 && d>0 && a%2==0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

            Console.Read();
            
        }
    }
}
