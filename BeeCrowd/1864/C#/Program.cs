using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1864
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "LIFE IS NOT A PROBLEM TO BE SOLVED";
            char[] caracter = frase.ToCharArray();
            int num;

            do
            {
                num = int.Parse(Console.ReadLine());
            } while (num < 0 || num > 34);

            for (int i = 0; i < num; i++)
            {
                Console.Write(frase[i]);
            }
            Console.Write("\n");

            Console.ReadLine();
        }
    }
}
