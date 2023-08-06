using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1042_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int[] valor = Array.ConvertAll(vet, int.Parse);
            
            Array.Sort(valor);

            for(int i = 0; i < valor.Length; i++)
            {
                Console.WriteLine(valor[i]);
            }

            Console.WriteLine($"\n{ vet[0]}");
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);

            Console.Read();

        }
    }
}
