using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] posicao;
            int x, y;

            do
            {
                posicao = Console.ReadLine().Split(' ');
                x = int.Parse(posicao[0]);
                y = int.Parse(posicao[1]);

                if(x > 0)
                {
                    if(y > 0)
                    {
                        Console.WriteLine("primeiro");
                    }
                    if(y < 0)
                    {
                        Console.WriteLine("quarto");
                    }
                }
                if(x < 0)
                {
                    if (y > 0)
                    {
                        Console.WriteLine("segundo");
                    }
                    if (y < 0)
                    {
                        Console.WriteLine("terceiro");
                    }
                }
                if(x == 0)
                {
                    break;
                }
                if(y == 0)
                {
                    break;
                }
            }while(x != 0 || y != 0);
            

            Console.Read();
        }
    }
}
