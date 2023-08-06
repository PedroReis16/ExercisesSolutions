using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1040___tentativa_sem_vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] nota = new float[5];
            float media, mf, x, y1, y2, y3, y4;

            Console.Write("Insira a primeira nota: ");
            y1 = float.Parse(Console.ReadLine());
            Console.Write("Insira a segunda nota: ");
            y2 = float.Parse(Console.ReadLine());
            Console.Write("Insira a terceira nota: ");
            y3 = float.Parse(Console.ReadLine());
            Console.Write("Insira a quarta nota: ");
            y4 = float.Parse(Console.ReadLine());

            Console.Clear();

            media = ((y1 * 2) + (y2 * 3) + (y3 * 4) + (y4 * 1)) / 10;

            if (media >= 7.0)
            {
                Console.WriteLine($"Media: {media:0.0}");
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine($"Media: {media:0.0}");
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine($"Media: {media: 0.0}");
                Console.WriteLine("Aluno em exame.");

                Console.Write("Insira a nota do exame: ");
                x = float.Parse(Console.ReadLine());
                Console.Clear();

                mf = (media + x) / 2;
                if (mf >= 5.0)
                {
                    Console.WriteLine($"Media: {media:0.0}");
                    Console.WriteLine("Aluno em exame");
                    Console.WriteLine($"Nota do exame: {x}");
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {mf}");
                }
                else
                {
                    Console.WriteLine($"Media: {media:0.0}");
                    Console.WriteLine("Aluno em exame.");
                    Console.WriteLine($"Nota do exame: {x}");
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {mf}");
                }
            }

            Console.ReadKey();
        }
    }
}
