using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars___Square_n__Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero;
            string numero2;
            string numero3;
            string[] numero4;
            double[] numero5;
            double resultado;

            numero = Console.ReadLine();
            //1,2,2]
            numero2 = numero.Remove(0, 1);
            numero3 = numero.Remove(8, 1);
            numero3 = numero3.Remove(3, 1);
            numero3 = numero3.Remove(5, 1);
            numero4 = numero3.Split(',');

            numero5 = Array.ConvertAll(numero4, double.Parse);

            resultado = Math.Pow(numero[0], 2) + Math.Pow(numero[1], 2) + Math.Pow(numero[3], 2);
            Console.WriteLine(resultado);
            Console.ReadKey();

        }
    }
}
