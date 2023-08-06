using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2764
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split('/');

            Console.WriteLine($"{data[1]}/{data[0]}/{data[2]}");
            Console.WriteLine($"{data[2]}/{data[1]}/{data[0]}");
            Console.WriteLine($"{data[0]}-{data[1]}-{data[2]}");

            Console.Read();
        }
    }
}
