using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 4, 5, 6, 10, 23, 54 };
            //Console.WriteLine(BinarySearch(arr, 6));

            var dup = new int[] { 1, 1, 2, 2, 3, 4, 4, 4, 4, 4, 5, 6, 8 };
            //Console.WriteLine(FindFirstIndex(dup, 4));
            //Console.WriteLine(FindLastIndex(dup, 4));

            var rotatedArray = new int[] { 4, 5, 6, 8, 9, 0, 1, 2 };
            Console.WriteLine(FindPivotInRotatedArray(rotatedArray));


        }

        private static int FindPivotInRotatedArray(int[] arr)
        {
            int l = 0;
            int r = arr.Length - 1;
            int mid = -1;
            while (l < r)
            {
                mid = l + (r - l) / 2;
                if (arr[mid] > arr[r])
                    l = mid + 1;
                else
                    r = mid;
            }

            return l;

        }

        private static int BinarySearch(int[] arr, int num)
        {
            if (arr.Length == 0)
                return -1;

            int l = 0;
            int r = arr.Length - 1;

            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (arr[mid] == num)
                    return mid;
                else if (arr[mid] > num)
                    r = mid - 1;
                else
                    l = mid + 1;
            }

            return -1;

        }

        private static int FindFirstIndex(int[] arr, int num)
        {
            if (arr.Length == 0)
                return -1;

            int l = 0;
            int r = arr.Length - 1;
            int idx = -1;

            while (l <= r)
            {
                int mid = l + (r - l) / 2;

                if (arr[mid] >= num)
                    r = mid - 1;
                else
                    l = mid + 1;

                if (arr[mid] == num)
                    idx = mid;

            }

            return idx;
        }

        private static int FindLastIndex(int[] arr, int num)
        {
            if (arr.Length == 0)
                return -1;
            int idx = -1;
            int l = 0;
            int r = arr.Length - 1;

            while (l <= r)
            {
                int mid = l + (r - l) / 2;

                if (arr[mid] <= num)
                    l = mid + 1;
                else
                    r = mid - 1;

                if (arr[mid] == num)
                    idx = mid;
            }


            return idx;

        }
    }
}
