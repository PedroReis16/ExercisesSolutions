using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,j = 0,num;

            do
            {
                i = int.Parse(Console.ReadLine());

            } while (i > 10000 || i < 0);

            while (j < i)
            {
                j++;
                num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    Console.WriteLine("NULL");
                }
                if (num%2 == 0 && num != 0)
                {
                    Console.Write("EVEN");
                    if (num > 0)
                    {
                        Console.WriteLine(" POSITIVE");
                    }
                    if (num < 0)
                    {
                        Console.WriteLine(" NEGATIVE");
                    }
                }
                if (num % 2 != 0)
                {
                    Console.Write("ODD");
                    if (num > 0)
                    {
                        Console.WriteLine(" POSITIVE");
                    }
                    if (num < 0)
                    {
                        Console.WriteLine(" NEGATIVE");
                    }
                }
               
            }

            Console.Read();
        }
    }
}
