using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode___66.Plus_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero = Console.ReadLine();
            int[] valor;
            int[] valor2;
            string[] numero1;
            int s;

            numero = numero.Trim(new char[] {'[',']'});
            numero1 = numero.Split(',');
            valor = Array.ConvertAll(numero1, int.Parse);

            //com valor[valor.Lenght - 1] eu consigo acessar qualquer valor do vetor que eu desejar

            s = valor.Length;

            for(int i = s - 1; i >= 0; i--)
            {
                if(valor[i] < 9)
                {
                    valor[i]++;
                    Console.Write(valor[i]);
                }
                valor[i] = 0;
            }

            valor2 = new int[s + 1];
            valor2[0] = 1;

            for(int i=0; i<=valor2.Length; i++)
            {
                Console.WriteLine(valor[2]);
            }

            Console.Read();
        }
    }
}
