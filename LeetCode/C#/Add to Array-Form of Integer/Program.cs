using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode___Add_to_Array_Form_of_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(',');
            int[] numeros = Array.ConvertAll(valores, int.Parse);
            int extra = int.Parse(Console.ReadLine());
            IList<int> soma = AddToArrayForm(numeros, extra);
            
            foreach(var i in soma)
            {
                Console.WriteLine(i);
            }
                       
            Console.Read();

        }
        static IList<int> AddToArrayForm(int[]num,int k)
        {
            List<int> numero = new List<int>();

            foreach(var i in num)
            {
                numero.Add(i);
            }
            List<string> valor = numero.ConvertAll<string>(x => x.ToString());

            List<char> opa = new List<char>();

            foreach(var i in valor)
            {
                opa.Add(Convert.ToChar(i));
            }

            string convert = "";
            foreach(var i in opa)
            {
                convert = convert + i;
            }

            Decimal number = Convert.ToDecimal(convert);
            number = number + k;


            string reconvertendo = number.ToString();

            List<char> caracter = new List<char>();

            caracter.AddRange(reconvertendo);
            List<string> aoba = new List<string>();

            foreach(var i in caracter)
            {
                aoba.Add(i.ToString());
            }

            List<int> final = new List<int>();

            foreach(var i in aoba)
            {
                
                final.Add(int.Parse(i));

            }
            
            return final;
        }
    }
}
