using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1173
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] n=new int[11];
            Console.Clear();

            n[0] = num;
            for (int i = 1; i < 11; i++)
            {
                n[i] = n[i - 1] * 2;
            }
            
            for(int i = 0; i < 11; i++)
            {

                Console.WriteLine($"N[{i}]:{n[i]}");
            }

            Console.Read();
        }
    }
}
