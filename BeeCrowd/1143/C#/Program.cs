using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1143
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int[,] matriz=new int[numero,3];
            int soma;

            for(int i = 0; i < numero; i++)
            {
                soma = i+1;
                for (int j = 0; j < 3; j++)
                {
                        if (j == 0)
                        {
                            matriz[i, j] = soma;
                        }
                        if (j == 1)
                        {
                            matriz[i, j] = soma * soma;
                        }
                        if (j == 2)
                        {
                            matriz[i, j] = soma * soma * soma;
                        }
                    
                }
            }

            for(int i = 0; i < numero; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                    if (j == 1)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                    if (j == 2)
                    {
                        Console.Write(matriz[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
