using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1045
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]valor=Console.ReadLine().Split(' ');
            float[] ponto;
            float a,b,c;

            ponto = Array.ConvertAll(valor, float.Parse);

            a = ponto[0];
            b = ponto[1];
            c = ponto[2];

            if (b >= a + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if(c*c == a * a + b * b)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if(c*c > a * a + b * b)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");

                if(a == b && b == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                if(a == b || a == c || b == c)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
            else if(a*a < c * c + b * b)
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");

                if (a == b && a == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
           

            Console.Read();
        }
    }
}
