using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1180
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string posicoes = Console.ReadLine();
            string[] vetor = Console.ReadLine().Split(' ');
            int[] numeros = Array.ConvertAll(vetor, int.Parse);
            int[] ordem = Array.ConvertAll(vetor, int.Parse);
            int local;

            Array.Sort(numeros);

            Console.WriteLine($"Menor valor: {numeros[0]}");

            local = Array.IndexOf(ordem, numeros[0]);
            Console.WriteLine($"Posicao: {local}");

            Console.Read();
        }
    }
}
