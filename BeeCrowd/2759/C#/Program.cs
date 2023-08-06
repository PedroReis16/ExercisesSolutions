using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2759
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] val = new string[3];

            for(int i = 0; i < val.Length; i++)
            {
                val[i] = Console.ReadLine();
            }

            Console.WriteLine($"A = {val[0]}, B = {val[1]}, C = {val[2]}");
            Console.WriteLine($"A = {val[1]}, B = {val[2]}, C = {val[0]}");
            Console.WriteLine($"A = {val[2]}, B = {val[0]}, C = {val[1]}");

            Console.Read();
        }
    }
}
