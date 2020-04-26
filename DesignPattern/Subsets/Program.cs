using System;
using System.Collections.Generic;
using System.Linq;

namespace Subsets
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = PrintSetsDfs(new[] {1, 1, 2, 3 });

            //Print(result);

            Print(Permute(new[] { 1, 1, 2, 3 }));


        }

        private static void Print(IList<IList<int>> list)
        {
            foreach (var res in list)
            {
                foreach (var i in res)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }
        }

        private static List<IList<int>> Permute(int[] nums)
        {
            var res = new List<IList<int>>();
            Permute(nums, 0, res);
            return res;
        }

        private static void Permute(int[] nums, int l, List<IList<int>> result)
        {
            if(l == nums.Length - 1)
            {
                result.Add(new List<int>(nums));
            }
            else
            {
                for(int i = l; i < nums.Length; i++)
                {
                    if(ShouldSwap(nums, l, i))
                    {
                        int temp = nums[i];
                        nums[i] = nums[l];
                        nums[l] = temp;
                        Permute(nums, l + 1, result);
                        temp = nums[i];
                        nums[i] = nums[l];
                        nums[l] = temp;
                    }
                   

                }
            }
        }

        private static bool ShouldSwap(int[] nums, int l, int i)
        {
            for(int a = l; a < i; a++)
            {
                if (nums[a] == nums[i])
                    return false;
            }

            return true;
        }

        private static void Dfs(int[] nums, int start, List<int> temp, List<IList<int>> result)
        {
            result.Add(new List<int>(temp));
            for(int i = start; i < nums.Length; i++)
            {
                if (i > start && nums[i] == nums[i - 1])
                    continue;

                temp.Add(nums[i]);
                Dfs(nums, i + 1, temp, result);
                temp.RemoveAt(temp.Count - 1);
            }
        }

        private static List<IList<int>> PrintSetsDfs(int[] set)
        {
            var result = new List<IList<int>>();
            Dfs(set, 0, new List<int>(), result);
            return result;
        }

        private static List<List<int>> PrintSets(int[] set)
        {
            var result = new List<List<int>>();
            for (int i = 0; i < Math.Pow(2, set.Length); i++)
            {
                var temp = new List<int>();
                for (int j = 0; j < set.Length; j++)
                {
                    if ((i & (1 << j)) > 0)
                    {
                        temp.Add(set[j]);
                    }
                }

                result.Add(temp);
            }

            return result;
        }
    }


}
