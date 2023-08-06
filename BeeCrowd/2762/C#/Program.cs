using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2762_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(',');
            string a, b;
            char[] dois;

            a = num[0];
            b = num[1];

            dois = b.ToCharArray();


            if (dois[0] == '0')
            {
                Console.WriteLine($"{dois[1]}{dois[2]}.{a}");
            }
            else
            {
                Console.WriteLine($"{b}.{a}");
            }

            Console.Read();
        }
    }
}
