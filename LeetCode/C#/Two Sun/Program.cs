using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code___Two_Sun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(',');
            int[] num;
            int meta=int.Parse(Console.ReadLine()),soma;
            string saida;
            num = Array.ConvertAll(numeros, int.Parse);

            for(int i = 0; i < numeros.Length; i++)
            {
                soma = num[i] + num[i + 1];

                if (soma == meta)
                {
                    saida = $"{i},{i + 1}";
                    Console.WriteLine(saida);
                    break;
                }
                else
                {
                    continue;
                }
            }


            Console.Read();
        }
    }
}
