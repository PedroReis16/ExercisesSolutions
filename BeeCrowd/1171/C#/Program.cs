using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1171
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teste = int.Parse(Console.ReadLine());
            int i = 0,f=0;
            int[] numeros=new int[teste];

            
            for(int j = 0; j < numeros.Length; j++)
            {
                numeros[j] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numeros);
            List<int> valores = numeros.ToList();

            var result = numeros.GroupBy(x => x);

            foreach(var t in result)
            {
                Console.WriteLine($"{t.Key} aparece {t.Count()} vez(es)");
            }

            Console.Read();
        }
    }
}
