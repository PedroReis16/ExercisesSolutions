using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars___If_you_can_t_sleep__just_count_sheep__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ovelha;
            string sonho;

            do
            {
                Console.Clear();
                ovelha = int.Parse(Console.ReadLine());
            }while(ovelha < 0);

            Console.Clear();
            for (int i = 1; i <= ovelha; i++)
            {
                sonho = i + " sheep...";
                Console.Write(sonho);
            }

            Console.ReadLine();
        }
    }
}
