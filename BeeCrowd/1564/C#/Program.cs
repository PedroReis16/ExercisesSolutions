using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1564
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int reclamação;

            reclamação = int.Parse(Console.ReadLine());

            if(reclamação != 0)
            {
                Console.WriteLine("vai ter duas!");
            }
            else 
            {
                Console.WriteLine("vai ter copa!");
            }
            Console.ReadKey();
        }
    }
}
