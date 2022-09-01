using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 41, 3, 12, 57, 13, 69, 23, 56 };
            Selectionsort(arr);
            Console.Read();

        }
        static void Selectionsort(int[] arr)
        {
            int MinIndex, i, j;
            int len = arr.Length - 1;
            for (i = 0; i < len; i++)
            {
                MinIndex = i;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[MinIndex])
                    {
                        MinIndex = j;
                    }
                }
                if (MinIndex != i)
                {
                    int temp = arr[MinIndex];
                    arr[MinIndex] = arr[i];
                    arr[i] = temp;
                }
            }

            Console.WriteLine("------------Sorted--------");
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k]);
            }

        }
    }
