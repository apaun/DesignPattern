using System;
using System.Collections.Generic;
using System.Linq;

namespace Subsets
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = PrintSets(new[] {1, 2, 3});
            foreach (var res in result)
            {
                foreach (var i in res)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }

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
