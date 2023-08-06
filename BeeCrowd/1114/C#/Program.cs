using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1114
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha;
            do
            {
                senha = int.Parse(Console.ReadLine());

                if(senha != 2002)
                {
                    Console.WriteLine("Senha Invalida");
                }
                else
                {
                    Console.WriteLine("Acesso Permitido");
                }

            } while (senha != 2002);

            Console.Read();
        }
    }
}
