using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            if(numero%2 == 0)
            {
                Console.WriteLine(numero+1);
                Console.WriteLine(numero + 3);
                Console.WriteLine(numero + 5);
                Console.WriteLine(numero + 7);
                Console.WriteLine(numero + 9);
                Console.WriteLine(numero + 11);
            }
            else if(numero%2 > 0)
            {
                Console.WriteLine(numero + 2);
                Console.WriteLine(numero + 4);
                Console.WriteLine(numero + 6);
                Console.WriteLine(numero + 8);
                Console.WriteLine(numero + 10);
                Console.WriteLine(numero + 12);
            }
            Console.ReadKey();
        }
    }
}
