using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3126
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()),b=0;
            string[] num=Console.ReadLine().Split(' ');
            int[] n;

            n = Array.ConvertAll(num, int.Parse);

            Array.ForEach(n, i => b += i);

            Console.WriteLine(b);

            Console.Read();
        }
    }
}
