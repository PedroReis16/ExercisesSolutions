using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1387
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] num;
            int x, y,valor;

            do
            {
                num = Console.ReadLine().Split(' ');
                x = int.Parse(num[0]);
                y = int.Parse(num[1]);

                valor = x + y;

                if(valor > 0)
                {
                    Console.WriteLine(valor);
                }
                if(valor == 0)
                {
                    break;
                }

            }while(x != 0 && y != 0);

            Console.Read();
        }
    }
}
