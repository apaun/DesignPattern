using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 2, 6, 7, 1, 4, 8, 9, 5, 3 };
            Print(arr);
            //BubbleSort(arr);
            //SelectionSort(arr);
            //InsertionSort(arr);
            //QuickSort(arr, 0, arr.Length - 1);
            MergeSort(arr, 0, arr.Length - 1);
            Print(arr);
        }

        private static void Merge(int[] arr, int l, int m, int r)
        {
            int i = 0, j = 0, k = 0;
            int l1 = m - l + 1;
            int l2 = r - m;

            var arr1 = new int[l1];
            var arr2 = new int[l2];

            for(i = 0; i < l1; i++)
            {
                arr1[i] = arr[i + l];
            }

            for (i = 0; i < l2; i++)
            {
                arr2[i] = arr[i + m + 1];
            }

            i = 0;
            j = 0;
            k = l;
            while(i < l1 && j < l2)
            {
                if (arr1[i] < arr2[j])
                    arr[k++] = arr1[i++];
                else
                    arr[k++] = arr2[j++];
            }

            while(i < l1)
            {
                arr[k++] = arr1[i++];
            }

            while (j < l2)
            {
                arr[k++] = arr2[j++];
            }

        }

        private static void MergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int mid = l + (r - l) / 2;
                MergeSort(arr, l, mid);
                MergeSort(arr, mid + 1, r);
                Merge(arr, l, mid, r);
            }
           
        }

        private static void QuickSort(int[] arr, int l, int r)
        {
            if(l < r)
            {
                int pi = PartitionIndex(arr, l, r);
                QuickSort(arr, l, pi - 1);
                QuickSort(arr, pi + 1, r);
            }
        }

        private static int PartitionIndex(int[] arr, int l, int r)
        {
            int pivot = arr[r];
            int i = l;
            int j = 0;

            for (j = l; j < r; j++)
            {
                if (arr[j] < pivot)
                {
                    Swap(ref arr[j], ref arr[i]);
                    i++;
                }
            }

            Swap(ref arr[i], ref arr[r]);

            return i;
        }


        private static void InsertionSort(int[] arr)
        {
            int i = 0, j = 0, key = 0;

            for (i = 1; i < arr.Length; i++)
            {
                j = i - 1;
                key = arr[i];

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        private static void SelectionSort(int[] arr)
        {
            int i = 0, j = 0, min = 0;

            for (i = 0; i < arr.Length; i++)
            {
                min = i;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }

                Swap(ref arr[min], ref arr[i]);
            }
        }

        private static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        private static void Print(int[] arr)
        {
            foreach (var a in arr)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
