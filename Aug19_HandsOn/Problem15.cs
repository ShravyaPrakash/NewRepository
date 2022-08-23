using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Problem15
    {
        static void Main()
        {
            int i = 0, j = 25;
            while (i <= j)
            {
                Console.WriteLine($"i = {i} and j = {j}");
                i++;
                j--;
            }
            Console.WriteLine("crossed over");
            Console.ReadLine();

        }
    }
