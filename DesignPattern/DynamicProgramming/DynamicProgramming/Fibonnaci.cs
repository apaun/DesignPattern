using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public static class Fibonnaci
    {
        public static int GetFibonnaci(int number)
        {
            var memo = new int[number + 1];

            memo[0] = 1;
            memo[1] = 1;

            for (int i = 2; i <= number + 1; i++)
            {
                memo[i] = memo[i - 1] + memo[i - 2];
            }
           
            return memo[number + 1];
        }
    }
}
