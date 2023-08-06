using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2763
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cpf = Console.ReadLine();

            Console.WriteLine(cpf.Substring(0, 3));
            Console.WriteLine(cpf.Substring(4, 3));
            Console.WriteLine(cpf.Substring(8, 3));
            Console.WriteLine(cpf.Substring(12, 2));

            Console.Read();
        }
    }
}
