using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1786_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cpf;
            char[] opa;
            int[] num;
            int d1,d2;
            while (true)
            {
                do
                {
                    
                    cpf = Console.ReadLine();
                    Console.Clear();
                } while (cpf.Length != 9);

                opa = cpf.ToCharArray();

                num = Array.ConvertAll(opa, Convert.ToInt32);

                for (int i = 0; i < num.Length; i++)
                {
                    num[i] = num[i] - 48;
                }

                d1 = num[0] * 1 + num[1] * 2 + num[2] * 3 + num[3] * 4 + num[4] * 5 + num[5] * 6 + num[6] * 7 + num[7] * 8 + num[8] * 9;

                if (d1 % 11 < 10)
                {
                    d1 = d1 % 11;
                }
                else
                {
                    d1 = 0;
                }

                d2 = num[0] * 9 + num[1] * 8 + num[2] * 7 + num[3] * 6 + num[4] * 5 + num[5] * 4 + num[6] * 3 + num[7] * 2 + num[8] * 1;

                if (d2 % 11 < 10)
                {
                    d2 = d2 % 11;
                }
                else
                {
                    d2 = 0;
                }

                Console.WriteLine($"{num[0]}{num[1]}{num[2]}.{num[3]}{num[4]}{num[5]}.{num[6]}{num[7]}{num[8]}-{d1}{d2}");
            }
        }
    }
}
