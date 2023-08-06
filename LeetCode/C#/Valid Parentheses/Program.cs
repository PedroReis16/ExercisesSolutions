using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode___Valid_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] confirmando = s.ToCharArray();
            bool valido;

            for(int i = 0; i < s.Length; i++)
            {
                if (confirmando[i] == '(' && confirmando[i + 1] == ')')
                {
                    valido = true;

                    Console.WriteLine(valido);
                    break;
                }
                else if(confirmando[i] != '(' && confirmando[i + 1] != ')')
                {
                    valido = false;
                    Console.WriteLine(valido);
                    break;
                }
                
            }
            Console.Read();
        }
    }
}
