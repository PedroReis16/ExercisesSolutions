using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double intervalo = double.Parse(Console.ReadLine()); 

            if(intervalo >= 0 && intervalo <= 25.0000)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if(intervalo >= 25.00001 && intervalo<= 50.0000000)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (intervalo >= 50 && intervalo <= 75.0000000)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (intervalo >= 75 && intervalo <= 100.0000000)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }

            Console.Read();
        }
    }
}
