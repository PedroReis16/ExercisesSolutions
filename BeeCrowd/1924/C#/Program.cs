using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1924
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] curso=new string[100];

            for (int i = 0; i < num; i++)
            {
                curso[i] = Console.ReadLine();
            }
            Console.WriteLine("Ciencia da Computacao");

            Console.ReadKey();
        }
    }
}
