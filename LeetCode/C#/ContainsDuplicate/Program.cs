using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode___ContainsDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valor = Console.ReadLine().Split(',');
            int[] numeros=Array.ConvertAll(valor,int.Parse);
            bool verdade = ConstainsDuplicate(numeros);

            Console.WriteLine(verdade);
            Console.ReadKey();
        }
        static bool ConstainsDuplicate(int[] num)
        {
            List<int> lista = num.ToList();
            int repetido = 0;
            bool verdade;
            var duplicado = lista.GroupBy(x => x);

            foreach(var i in duplicado)
            {
                if (i.Count() != 1)
                {
                    repetido++;
                }
                else 
                {
                    continue;
                }

            }
            
            if (repetido == 0)
            {
                verdade = false;
            }
            else
            {
                verdade = true;
            }

            return verdade;
        }

    }
}
