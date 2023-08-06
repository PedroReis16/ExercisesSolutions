using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars___String_repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]palavra=Console.ReadLine().Split(',');
            int numero = int.Parse(palavra[0]);
            string arrumado;

            arrumado = palavra[1].Trim(new Char[] {'"'});

            Console.Clear();
            for(int i = 0; i < numero; i++)
            {
                string nome = arrumado;
                Console.Write(nome);
            }
            Console.ReadKey();
        }
    }
}
