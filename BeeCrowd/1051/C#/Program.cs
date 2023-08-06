using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1051_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double renda,ajuste,imposto;

            renda = double.Parse(Console.ReadLine());

            if(renda <2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if(renda >2000.00 && renda <=3000.00)
            {
                ajuste = renda - 2000;
                imposto = ajuste * 0.08;
                Console.WriteLine($"R$ {imposto:0.00}");
                
               
            }
            else if (renda > 3000.00 && renda <= 4500.00)
            {
                ajuste = renda - 3000;
                imposto = ajuste * 0.18+80;
                
                Console.WriteLine($"R$ {imposto:0.00}");
            }
            else if (renda > 4500.00)
            {
                ajuste = renda - 4500;
                imposto = ajuste * 0.28+80+270;
                Console.WriteLine($"R$ {imposto:0.00}");
            }
            Console.ReadKey();
        }
    }
}
