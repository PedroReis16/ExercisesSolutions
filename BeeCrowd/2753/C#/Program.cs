using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2753
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 96;
            char j = '`';

            while (i < 122)
            {
                
                while(j<'z')
                {
                    i++;
                    j++;
                    Console.WriteLine($"{i} e {j}");
                }
            }

            Console.Read();
        }
    }
}
