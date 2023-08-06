using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode___Longest_Common_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = Console.ReadLine().Split(',');
            string retorno = Volta(palavras);

            Console.WriteLine(retorno);

            Console.Read();
        }

        public static string Volta(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }

            int strsLength = strs[0].Length;

            for(int i = 1; i < strs.Length; i++)
            {
                if (strs.Length > strs[i].Length)
                {
                    strsLength = strs[i].Length;
                }
            }

            string rep = "";

            for(int i = 0; i < strsLength; i++)
            {
                char target = strs[0][i];

                for(int k = 1; k < strs.Length; k++)
                {
                    if (strs[k][i] != target)
                    {
                        return rep;
                    }
                }
                rep += target;
            }
            return rep;
        }
    }
}
