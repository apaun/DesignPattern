using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class CoinChange
    {
        public static long CalculateMaxWays(List<int> coin, int value)
        {
            var coin1 = new List<int>() { 2, 3, 5};
            coin.Sort();
            long[,] t = new long[coin.Count + 1, value + 1];

            for (int i = 0; i <= coin.Count; i++)
            {
                t[i, 0] = 1;
            }

            for (int i = 1; i <= value; i++)
            {
                t[0, 1] = 0;
            }

            for (int i = 1; i <= value; i++)
            {
                t[1, i] = i % coin[1] == 0 ? 1 : 0;
            }

            for (int i = 1; i <= coin.Count; i++)
            {
                for (int j = 0; j <= value; j++)
                {
                    if (coin[i - 1] > j)
                    {
                        t[i, j] = t[i - 1, j];
                    }
                    else
                    {
                        t[i, j] = t[i - 1, j] + t[i, j - coin[i - 1]];
                    }
                }
            }

            return t[coin.Count, value];
        }

        public static int CalculateChange(int[] coin, int value)
        {

            Array.Sort(coin);

            int[] dp = new int[value + 1];
            dp[0] = 0;

            for(int i = 1; i <= value; i++)
            {
                dp[i] = int.MaxValue;
                for(int j = 0; j < coin.Length; j++)
                {
                    var pre = i - coin[j];
                    if(pre >= 0 && dp[pre] != int.MaxValue)
                    {
                        dp[i] = Math.Min(dp[i], dp[pre] + 1);
                    }
                }
            }


            return dp[value] == int.MaxValue ? -1 : dp[value];

        }
    }
}