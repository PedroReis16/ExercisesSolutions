using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float gasolina, velociadade, tempo;

            Console.Write("Insira o tempo de viagem: ");
            tempo = float.Parse(Console.ReadLine());
            Console.Write("Insira a velocidade média da viagem: ");
            velociadade = float.Parse(Console.ReadLine());

            gasolina = (tempo * velociadade) / 12;

            Console.WriteLine($"{gasolina:0.000}");
            Console.ReadKey();

        }
    }
}
