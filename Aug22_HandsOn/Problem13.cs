using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Problem13
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 5, 200, 22, 2244, 213, 111 };
            Console.WriteLine("Number greater than 100: ");
            foreach (int i in arr)
            {
                if (i > 100)
                {

                    Console.WriteLine(i);
                }
            }
        }
    }
