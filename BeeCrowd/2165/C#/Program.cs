using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2165
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tweet;

            tweet = Console.ReadLine();

            if(tweet.Length <= 140)
            {
                Console.WriteLine("\nTWEET");
            }
            else
            {
                Console.WriteLine("\nMUTE");
            }
            Console.ReadLine();
        }
    }
}
