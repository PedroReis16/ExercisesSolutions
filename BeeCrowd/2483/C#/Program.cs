using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2483
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero ;
            int i=1;

            do
            {
                numero = int.Parse(Console.ReadLine());
            } while (numero < 1 || numero > 10000);

            Console.Write("Feliz nat");
            while(i <= numero)
            {
                i++;
                Console.Write("a");
            }
            Console.Write("l !\n");
            
            Console.Read();
        }
    }
}
