using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario,reajuste;

            salario = double.Parse(Console.ReadLine());

            if (salario <= 400.00)
            {
                reajuste = salario * 0.15;
                Console.WriteLine($"Novo salario: {reajuste+salario:0.00}");
                Console.WriteLine($"Reajuste ganho: {reajuste:0.00}");
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                reajuste = salario * 0.12;
                Console.WriteLine($"Novo salario: {reajuste + salario:0.00}");
                Console.WriteLine($"Reajuste ganho: {reajuste:0.00}");
                Console.WriteLine("Em percentual: 12 %");
            }
            else if(salario > 800.00 && salario<=1200.00)
            {
                reajuste = salario * 0.10;
                Console.WriteLine($"Novo salario: {reajuste + salario:0.00}");
                Console.WriteLine($"Reajuste ganho: {reajuste:0.00}");
                Console.WriteLine("Em percentual: 10 %");
            }
            else if(salario>1200.00&&salario<=2000.00)
            {
                reajuste = salario * 0.07;
                Console.WriteLine($"Novo salario: {reajuste + salario:0.00}");
                Console.WriteLine($"Reajuste ganho: {reajuste:0.00}");
                Console.WriteLine("Em percentual: 7 %");
            }
            else
            {
                reajuste = salario * 0.04;
                Console.WriteLine($"Novo salario: {reajuste + salario:0.00}");
                Console.WriteLine($"Reajuste ganho: {reajuste:0.00}");
                Console.WriteLine("Em percentual: 4 %");
            }
            Console.ReadKey();
        }
    }
}
