using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode___Roman_to_Interger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string romano = Console.ReadLine();
            char[] valores = romano.ToCharArray();
            int um=0, cinco = 0, dez = 0, cinquenta = 0, cem = 0, quinhentos = 0, mil = 0;
            int soma;

            for(int i =0;i<romano.Length;i++)
            {
                
                if (valores[i] == 'I' || valores[i] == 'i')
                {
                    um++;
                }
                else if(valores[i] == 'V' || valores[i] == 'v')
                {
                    cinco++;
                }
                else if (valores[i] == 'X' || valores[i] == 'x')
                {
                    dez++;
                }
                else if (valores[i] == 'L' || valores[i] == 'l')
                {
                    cinquenta++;
                }
                else if (valores[i] == 'C' || valores[i] == 'c')
                {
                    cem++;
                }
                else if (valores[i] == 'D' || valores[i] == 'd')
                {
                    quinhentos++;
                }
                else if (valores[i] == 'M' || valores[i] == 'm')
                {
                    mil++;
                }

                
            }

            int quatro = 0, nove = 0, quarenta = 0, noventa = 0, quatrocentos = 0, novecentos = 0;

            for (int i = 1; i < romano.Length; i++)
            {
                if (valores[i] == 'V' && valores[i - 1] == 'I'  || valores[i] == 'v' && valores[i - 1] == 'i' )
                {
                    um--;
                    cinco--;
                    quatro++;
                }
                else if (valores[i] == 'X' && valores[i - 1] == 'I' || valores[i] == 'x' && valores[i - 1] == 'i' )
                {
                    um--;
                    dez--;
                    nove++;
                }
                else if (valores[i] == 'L' && valores[i - 1] == 'X'  || valores[i] == 'l' && valores[i - 1] == 'x' )
                {
                    dez--;
                    cinquenta--;
                    quarenta++;
                }
                else if (valores[i] == 'C' && valores[i - 1] == 'X'  || valores[i] == 'c' && valores[i - 1] == 'x' )
                {
                    dez--;
                    cem--;
                    noventa++;
                }
                else if (valores[i] == 'D' && valores[i - 1] == 'C'  || valores[i] == 'd' && valores[i - 1] == 'c' )
                {
                    cem--;
                    quinhentos--;
                    quatrocentos++;
                }
                else if (valores[i] == 'M' && valores[i - 1] == 'C'  || valores[i] == 'm' && valores[i - 1] == 'c' )
                {
                    cem--;
                    mil--;
                    novecentos++;
                }
            }
            soma = (1 * um) + (5 * cinco) + (10 * dez) + (50 * cinquenta) + (100 * cem) + (500 * quinhentos) + (1000 * mil)
                +(4*quatro)+(9*nove)+(40*quarenta)+(90*noventa)+(400*quatrocentos)+(900*novecentos);

            
            Console.Read();
        }
    }
}
