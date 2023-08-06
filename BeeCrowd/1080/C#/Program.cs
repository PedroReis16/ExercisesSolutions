using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1080_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int posição, valor, maior;

            for(int i = 0; i< numeros.Length;i++)
            {
                Console.Write("Informe um valor[{0}]: ",i);
                int.Parse(Console.ReadLine());
            }

            maior= numeros[0];
            for(int i = 1; i<numeros.Length;i++)
            {
                if (maior < numeros[i])
                {
                    maior = numeros[i];
                }
                
            }
            

            Console.WriteLine(maior);
            

            Console.Read();
        }
    }
}
