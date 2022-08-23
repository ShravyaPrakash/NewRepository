
using System;

    internal class Problem6
    {
        private static void Main(string[] args)
        {
            int year;

            Console.Write("input the year ");

            year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("the entered year {0} is a leap year", year);
            }
            else
            {
                Console.WriteLine("the entered year {0} is not a leap year", year);
            }
            Console.ReadLine();
        }
    }
