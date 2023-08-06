using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problema_1154
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> idade = new List<int>();
            

            do
            {
                idade.Add(int.Parse(Console.ReadLine()));

            } while (idade.All(x => x >= 0));

            idade.RemoveAt(idade.Count - 1);

            Console.WriteLine($"{idade.Average():0.00}");

            Console.Read();
        }
    }
}
