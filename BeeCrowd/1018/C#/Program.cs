using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1018___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dinheiro = int.Parse(Console.ReadLine());
            int cem, cinquenta, vinte, dez, cinco, dois, um;

            cem = dinheiro / 100;
            cinquenta = (dinheiro % 100) / 50;
            vinte = ((dinheiro % 100)%50) / 20;
            dez = (((dinheiro % 100)%50)%20) / 10;
            cinco = ((((dinheiro % 100)%50)%20)%10)/5;
            dois = (((((dinheiro % 100)%50)%20)%10)%5)/2;
            um = (((((dinheiro % 100) % 50) % 20) % 10) % 5) % 2;

            Console.Clear();
            Console.WriteLine(dinheiro);
            Console.WriteLine($"{cem} nota(s) de R$ 100,00");
            Console.WriteLine($"{cinquenta} nota(s) de R$ 50,00");
            Console.WriteLine($"{vinte} nota(s) de R$ 20,00");
            Console.WriteLine($"{dez} nota(s) de R$ 10,00");
            Console.WriteLine($"{cinco} nota(s) de R$ 5,00");
            Console.WriteLine($"{dois} nota(s) de R$ 2,00");
            Console.WriteLine($"{um} nota(s) de R$ 1,00");

            Console.Read();



        }
    }
}
