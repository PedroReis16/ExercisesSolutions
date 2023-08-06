using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1078
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            numero = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {numero} = {numero * i}");
            }
            Console.ReadKey();
        }
    }
}
