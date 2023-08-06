using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars___Are_You_Playing_Banjo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            char[] letra = nome.ToCharArray();
            char primero;
            

            primero = letra[0];

            if(primero == 'R' || primero == 'r')
            {
                Console.Clear();
                Console.WriteLine(nome + " plays banjo");
            }
            else
            {
                Console.Clear();
                Console.WriteLine(nome + " does not play banjo");
            }
            Console.ReadKey();

        }
    }
}
