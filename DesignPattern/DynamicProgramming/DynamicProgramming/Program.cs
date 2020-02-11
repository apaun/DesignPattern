using System;

namespace DynamicProgramming
{
    class Program
    {

        static void Main(string[] args)
        {
            var set = new[] {3, 34, 4, 12, 5, 2};
            for (int i = 0; i < 100; i++)
            {
                var sum = i;
                Console.WriteLine($"Sum : {sum}");
                Console.WriteLine($"Subset sum  : {Subsetsum.isSubsetSum(set, sum, set.Length)}");
                Console.WriteLine($"Subset sum DP  : {Subsetsum.isSubsetSumDp(set, sum, set.Length)}");
            }

            //int data = 9;
            //Console.WriteLine($"Fibonnci {data} : " + Fibonnaci.GetFibonnaci(data));
            //int[] coin = { 5, 37, 8, 39, 33, 17, 22, 32, 13, 7, 10, 35, 40, 2, 43, 49, 46, 19, 41, 1, 12, 11, 28 };
            //int value = 166;
            //Console.WriteLine($"Max ways Coin Change : {CoinChange.CalculateMaxWays(coin.ToList(), value)}");
            //Console.WriteLine($"Coin Change : {CoinChange.CalculateChange(coin, value)}");
        }
    }
}
