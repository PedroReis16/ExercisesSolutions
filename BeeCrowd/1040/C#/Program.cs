using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1040___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]notas=Console.ReadLine().Split(' ');
            float[] nota;
            float N1,N2, N3,N4,N5;
            float media,recuperação;

            nota = Array.ConvertAll(notas, float.Parse);
            N1 = nota[0];
            N2 = nota[1];
            N3 = nota[2];
            N4 = nota[3];
            

            media = ((N1 * 2) + (N2 * 3) + (N3 * 4) + (N4 * 1)) / 10;

            Console.Clear();
            if(media < 5.0)
            {
                Console.WriteLine($"Media: {media}");
                Console.WriteLine("Aluno reprovado.");
            }
            else if(media >= 5.1 && media <= 6.9)
            {
                Console.WriteLine($"Media: {media}");
                Console.WriteLine("Aluno em exame.");
                Console.Write("Nota do exame: ");
                N5 = float.Parse(Console.ReadLine());

                recuperação = (media + N5) / 2;
                if(recuperação <=4.9)
                {
                    Console.Clear();
                    Console.WriteLine($"Media: {media}");
                    Console.WriteLine("Aluno em exame.");
                    Console.WriteLine($"Nota do exame: {N5}");
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {recuperação}");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Media: {media}");
                    Console.WriteLine("Aluno em exame.");
                    Console.WriteLine($"Nota do exame: {N5}");
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {recuperação}");
                }
            }
            else
            {
                Console.WriteLine($"Media: {media}");
                Console.WriteLine("Aluno aprovado.");
            }
            Console.ReadKey();
        }
    }
}
