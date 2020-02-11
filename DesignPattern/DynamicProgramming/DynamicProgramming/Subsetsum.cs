using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public static class Subsetsum
    {
        public static bool isSubsetSum(int[] set, int sum, int n)
        {
            if (sum == 0)
                return true;
            if (n == 0)
                return false;
            if (sum > set[n - 1])
                isSubsetSum(set, sum - set[n - 1], n - 1);


            return isSubsetSum(set, sum, n - 1) || isSubsetSum(set, sum - set[n - 1], n - 1);
        }

        public static bool isSubsetSumDp(int[] set, int sum, int n)
        {
            var result = new bool[sum + 1, n + 1];

            for (int i = 0; i <= sum; i++)
            {
                result[i, 0] = false;
            }
            for (int i = 0; i <= n; i++)
            {
                result[0, i] = true;
            }

            for (int i = 1; i <= sum; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (set[j - 1] > i)
                    {
                        result[i, j] = result[i, j - 1];
                    }
                    else if (set[j - 1] <= i)
                    {
                        result[i, j] = result[i, j - 1] || result[i - set[j - 1], j - 1];
                    }
                }
            }

            return result[sum, n];
        }
    }
}
