using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1113
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] num;
            int x, y;

            do
            {
                num = Console.ReadLine().Split(' ');
                x = int.Parse(num[0]);
                y = int.Parse(num[1]);

                if(x > y)
                {
                    Console.WriteLine("Decrescente");
                }
                if(y > x)
                {
                    Console.WriteLine("Crescente");
                }
                if(x == y)
                {
                    break;
                }

            }while(x!=y);
        }
    }
}
