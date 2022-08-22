using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

    internal class Problem15
    {
    public static void Main(string[] args)
    {
        int[] arr = new int[] { 10, 5, 3, 4, 3, 5, 6 };
        printFirstRepeating(arr);
    }
        public static void printFirstRepeating(int[] arr)
        {
            int min = -1;

            // Creates an empty hashset
            HashSet<int> set = new HashSet<int>();

            // Traverse the input array from right to left
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                // If element is already in hash set, update min
                if (set.Contains(arr[i]))
                {
                    min = i;
                }

                else // Else add element to hash set
                {
                    set.Add(arr[i]);
                }

            }

            // Print the result
            if (min != -1)
            {
                Console.WriteLine("The first repeating element is " + arr[min]);
            }
            else
            {
                Console.WriteLine("There are no repeating elements");
            }
            Console.ReadLine();

        }


    }
    
