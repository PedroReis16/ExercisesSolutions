using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,d;
            string[] num;
            d = double.Parse(Console.ReadLine());

            for(int i = 0; i < d; i++)
            {
                num = Console.ReadLine().Split(' ');
                a = double.Parse(num[0]);
                b = double.Parse(num[1]);

                if (b == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    c = a / b;
                    Console.WriteLine($"{c:0.0}");
                }
            
            }

            Console.Read();
        }
    }
}
