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
            int[,] t = new int[coin.Length + 1, value + 1];

            for (int i = 0; i <= coin.Length; i++)
            {
                for (int j = 0; j <= value; j++)
                {
                    if (i == 0 || j == 0)
                        t[i, j] = 0;
                    else if (i == 1)
                    {
                        t[i, j] = j / coin[i - 1];
                    }
                    else if (coin[i - 1] > j)
                    {
                        t[i, j] = t[i - 1, j];
                    }
                    else
                    {
                        t[i, j] = Math.Min(t[i - 1, j], 1 + t[i, j - coin[i - 1]]);
                    }
                }
            }

            return t[coin.Length, value];

        }
    }
}
