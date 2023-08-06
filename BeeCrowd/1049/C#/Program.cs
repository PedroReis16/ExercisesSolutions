using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string esqueleto, tipo, alimento;

            esqueleto = Console.ReadLine();
            tipo = Console.ReadLine();
            alimento = Console.ReadLine();

            if(esqueleto == "vertebrado")
            {
                if(tipo == "ave")
                {
                    if(alimento == "carnivoro")
                    {
                        Console.Clear();
                        Console.WriteLine("aguia");
                    }
                    if(alimento == "onivoro")
                    {
                        Console.Clear();
                        Console.WriteLine("pomba");
                    }
                }
                if(tipo == "mamifero")
                {
                    if (alimento == "onivoro")
                    {
                        Console.Clear();
                        Console.WriteLine("homem");
                    }
                    if (alimento == "herbivoro")
                    {
                        Console.Clear();
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (esqueleto == "invertebrado")
            {
                if (tipo == "inseto")
                {
                    if(alimento=="hematofago")
                    {
                        Console.Clear();
                        Console.WriteLine("pulga");
                    }
                    if (alimento == "herbivoro")
                    {
                        Console.Clear();
                        Console.WriteLine("lagarta");
                    }
                }
                if(tipo == "anelideo")
                {
                    if( alimento == "hematofago")
                    {
                        Console.Clear();
                        Console.WriteLine("sanguessuga");
                    }
                    if( alimento == "onivoro")
                    {
                        Console.Clear();
                        Console.WriteLine("minhoca");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
