using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars___Return_Negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, multiplo;

            numero = int.Parse(Console.ReadLine());

            multiplo = numero * -1;

            Console.WriteLine(multiplo);
            Console.ReadLine();
        }
    }
}
