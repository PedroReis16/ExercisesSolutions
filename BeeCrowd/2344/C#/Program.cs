using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2344
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int letra = int.Parse(Console.ReadLine());

            if (letra == 0)
            {
                Console.WriteLine("E");
            }
            else if (letra > 0 && letra <= 35) 
            {
                Console.WriteLine("D");
            }
            else if (letra > 35 && letra <= 60)
            {
                Console.WriteLine("C");
            }
            else if(letra > 60 && letra <= 85)
            {
                Console.WriteLine("B");
            }
            else 
            {
                Console.WriteLine("A");
            }
            Console.ReadKey();
        }
    }
}
