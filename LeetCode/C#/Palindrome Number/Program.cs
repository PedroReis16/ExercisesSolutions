using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode___Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine(IsPalimdrome(numero));

            Console.Read();
        }
        static bool IsPalimdrome(int x)
        {
            int numero = x;
            string palin = Convert.ToString(numero);
            char[] letras = palin.ToCharArray();
            string palavra;
            Array.Reverse(letras);

            palavra = new string(letras);

            if (palavra == palin)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
    }
}
