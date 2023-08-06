using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1259
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tentativas = int.Parse(Console.ReadLine());
            int[] valores = new int[tentativas];
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();
            int i = 0;


            for (i = 0; i < tentativas; i++)
            {
                valores[i] = int.Parse(Console.ReadLine());
                
                if (valores[i] % 2 == 0)
                {
                    pares.Add(valores[i]);
                }
                else if (valores[i] % 2 != 0)
                {
                    impares.Add(valores[i]);
                }
            }

            pares.Sort();
            impares.Sort();
            Console.Clear();

            foreach(var t in pares)
            {
                Console.WriteLine(t);
            }
            for(int o = impares.Count-1; o >=0; o--)
            {
                Console.WriteLine(impares[o]);
            }
            Console.ReadLine();
        }
    }
}
