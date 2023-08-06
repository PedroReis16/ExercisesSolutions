using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tentativa = int.Parse(Console.ReadLine());
            string jogada1,jogada2;
            int i = 0;

            while (i < tentativa)
            {
                i++;
                jogada1 = Console.ReadLine();
                jogada2 = Console.ReadLine();

                if (jogada1 == "pedra"&& jogada2=="pedra")
                { 
                    Console.WriteLine("Sem ganhador");
                }
                else if(jogada1 == "papel" && jogada2 == "papel")
                {
                    Console.WriteLine("Ambos venceram");
                }
                else if(jogada1 == "ataque" && jogada2 == "ataque")
                {
                    Console.WriteLine("Aniquilacao mutua");
                }

                else if(jogada1 == "ataque" && jogada2 == "papel")
                {
                    Console.WriteLine("Jogador 1 venceu");
                }
                else if (jogada1 == "papel" && jogada2 == "ataque")
                {
                    Console.WriteLine("Jogador 2 venceu");
                }

                else if(jogada1 == "ataque" && jogada2 == "pedra")
                {
                    Console.WriteLine("Jogador 1 venceu");
                }
                else if (jogada1 == "pedra" && jogada2 == "ataque")
                {
                    Console.WriteLine("Jogador 2 venceu");
                }

                else if (jogada1 == "pedra" && jogada2 == "papel")
                {
                    Console.WriteLine("Jogador 1 venceu");
                }
                else if (jogada1 == "papel" && jogada2 == "pedra")
                {
                    Console.WriteLine("Jogador 2 venceu");
                }
            }
            Console.Read();
        }
    }
}
