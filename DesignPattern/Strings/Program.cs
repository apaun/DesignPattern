using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // a b h i j e e t
            // 0 1 2 3 4 5 6 7

            var str = "abhijeet";
            Console.WriteLine(RotateRight(str, 2)); // returns etabhije
            Console.WriteLine(RotateLeft(str, 2)); // returns hijeetab
        }

        private static string RotateLeft(string str, int v)
        {
            return str.Substring(v) + str.Substring(0, v);
        }

        private static string RotateRight(string str, int n)
        {
            //                  8 - 2 = 6                       0 - 6
            return str.Substring(str.Length - n) + str.Substring(0, str.Length - n);

        }
    }
}
