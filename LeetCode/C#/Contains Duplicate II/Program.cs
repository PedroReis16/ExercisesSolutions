using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode___Contains_Duplicate_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(',');
            int[] valor = Array.ConvertAll(numeros, int.Parse);
            int verifica = int.Parse(Console.ReadLine());
            bool resposta = ContainsNearbyDuplicate(valor, verifica);

            Console.WriteLine(resposta);
            Console.Read();
        }
        static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            
            Dictionary<int, int> numsDict = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if (!numsDict.ContainsKey(nums[i]))
                {
                    numsDict[nums[i]] = i;
                }
                else
                {
                    if (i - numsDict[nums[i]] <= k)
                    {
                        return true;
                    }
                    else
                    {
                        numsDict[nums[i]] = i;
                    }
                }
            }

            return false;
            
        }

    }
}
