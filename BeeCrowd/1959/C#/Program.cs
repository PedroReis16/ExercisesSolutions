using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1959
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] opa = Console.ReadLine().Split(' ');
            int[] aba = Array.ConvertAll(opa, int.Parse);

            Console.WriteLine(aba[0] * aba[1]);

            Console.Read();
        }
    }
}
