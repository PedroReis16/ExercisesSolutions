using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code___Remove_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]numeros=Console.ReadLine().Split(',');
            int valor = int.Parse(Console.ReadLine());

            int saida = RemoveElement(Array.ConvertAll(numeros, int.Parse), valor);

            Console.Read();
        }
        public static int RemoveElement(int[]nums,int val)
        {
            int resultado;
            List<int> list = new List<int>();

            list.AddRange(nums);

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    list.Remove(nums[i]);
                }
            }
            list.Sort();

            for(int i=0;i<list.Count;i++)
            {
                nums[i] = list[i];
            }
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            return resultado=list.Count;
        }
    }
}
