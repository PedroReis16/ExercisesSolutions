using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code___Remove_duplicate_from_sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]vetor=Console.ReadLine().Split(',');
            int[] num1 = Array.ConvertAll(vetor, int.Parse);

           int resposta = RemoveDuplicates(num1);
            Console.WriteLine("\n"+resposta);
            Console.Read();
        }
        public static int RemoveDuplicates(int[] nums)
        {
            int saida;
            List<int>num = new List<int>();
            num.AddRange(nums);

            for(int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    num.Remove(nums[i]);
                }
            }
            for(int i = 0; i < num.Count; i++)
            {
                nums[i] = num[i];
                if (i == num.Count - 1)
                {
                    Console.Write(nums[i]);
                }
                else
                {
                    Console.Write(nums[i] + ",");
                }
            }
            saida = num.Count;
            
            return saida;
        }
    }
}
