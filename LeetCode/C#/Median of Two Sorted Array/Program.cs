using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code___Median_of_Two_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vetor1, vetor2;
            vetor1 = Console.ReadLine();
            vetor2 = Console.ReadLine();

            int[] num1 = Array.ConvertAll(vetor1.Split(','), int.Parse);
            int[] num2 = Array.ConvertAll(vetor2.Split(','), int.Parse);

            double resultado=FindMedianSortedArrays(num1, num2);

            Console.WriteLine($"{resultado:0.0000}");


            Console.Read();
        }
        public static double FindMedianSortedArrays(int[] num1, int[] num2)
        {
            List<int> vetores = new List<int>(num1.Length + num2.Length);
            int meio;
            double media;

            vetores.AddRange(num1);
            vetores.AddRange(num2);

            vetores.Sort();

            if (vetores.Count % 2 ==0)
            {
                meio = (vetores.Count / 2)-1;
                int meio2 = meio+1;

                double soma = vetores[meio] + vetores[meio2];

                media = soma / 2;
            }
            else
            {
                int quant = vetores.Count;

                media = vetores[quant/2];
                
            }
            return media;
        }
    }
}
