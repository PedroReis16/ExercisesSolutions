using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode___Two_Sum__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numero = Console.ReadLine().Split(',');
            int[] valor = Array.ConvertAll(numero, int.Parse);
            int meta = int.Parse(Console.ReadLine());
            int[] nums = TwoSum(valor, meta);

            Console.WriteLine(nums[0]);
            Console.WriteLine(nums[1]);

            Console.Read();
        }
        static int[] TwoSum(int[] nums,int target)
        {
            Dictionary<int, int> tempDectionary = new Dictionary<int, int>();
            int[] num = nums;

            for (int i = 0; i < num.Length; i++)
            {
                int complement = target - num[i];

                if (tempDectionary.ContainsKey(complement))
                {
                    return new int[] { tempDectionary[complement], i };
                }
                else
                {
                    tempDectionary[num[i]] = i;
                }
            }
            return null;
        }
    }
}
