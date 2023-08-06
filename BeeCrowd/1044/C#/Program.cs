using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] multiplos;
            int[] valores;
            int n1, n2,divisão;

            multiplos = Console.ReadLine().Split(' ');
            
            valores = Array.ConvertAll(multiplos, int.Parse);
            n1 = valores[0];
            n2 = valores[1];

            divisão = n2 % n1;
            if(divisão != 0)
            {
                Console.WriteLine("Nao sao multiplos");
            }
            else
            {
                Console.WriteLine("Sao multiplos");
            }
            Console.ReadLine();
        }
    }
}
