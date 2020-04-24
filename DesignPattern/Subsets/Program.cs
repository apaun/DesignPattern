using System;
using System.Collections.Generic;
using System.Linq;

namespace Subsets
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = PrintSetsDfs(new[] { 1, 2, 3 });
            foreach (var res in result)
            {
                foreach (var i in res)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }

        }

        private static void Dfs(int[] nums, int start, List<int> temp, List<IList<int>> result)
        {
            result.Add(new List<int>(temp));
            for(int i = start; i < nums.Length; i++)
            {
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
