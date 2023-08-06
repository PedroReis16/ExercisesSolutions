using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1041
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]ponto=Console.ReadLine().Split(' ');
            float[] coord;
            float x,y;

            coord = Array.ConvertAll(ponto, float.Parse);

            x = coord[0];
            y = coord[1];

            if(x < 0 && x > 0)
            {
                Console.WriteLine("Q2");
            }
            else if(x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if(x>0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if(x>0 && y <0)
            {
                Console.WriteLine("Q4");
            }
            else if(x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }

            Console.Read();
        }
    }
}
