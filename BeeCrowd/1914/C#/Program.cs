using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1914
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teste = int.Parse(Console.ReadLine());
            string[] nome,numeros;
            int[] valor;
            int i = 0,soma;

            while (i < teste)
            {
                i++;

                nome = Console.ReadLine().Split(' ');
                numeros = Console.ReadLine().Split(' ');

                valor = Array.ConvertAll(numeros, int.Parse);

                soma = valor[0] + valor[1];

                if(soma%2==0 && nome[1] == "PAR")
                {
                    Console.WriteLine(nome[0]);
                }
                else if(soma%2==0 && nome[3] == "PAR")
                {
                    Console.WriteLine(nome[2]);
                }
                else if (soma % 2 != 0 && nome[1] == "IMPAR")
                {
                    Console.WriteLine(nome[0]);
                }
                else if (soma % 2 != 0 && nome[3] == "IMPAR")
                {
                    Console.WriteLine(nome[2]);
                }
            }
            Console.Read();
        }
    }
}
