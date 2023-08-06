using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo = int.Parse(Console.ReadLine());
            int hora, minuto, segundo;

            hora = tempo / 3600;
            minuto = (tempo % 3600) / 60;
            segundo = ((tempo % 60) % 60) % 60;

            Console.WriteLine($"{hora}:{minuto}:{segundo}");
            Console.Read();

        }
    }
}
