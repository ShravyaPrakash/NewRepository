using System;
using System.IO;
using System.Text;

    class Problem1
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int min;
            int max;

            Console.Write("enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
                max = a;
            else
                max = b;
            if (a < b)
                min = a;
            else
                min = b;

            Console.WriteLine("using if-else...");
        Console.WriteLine("minimum number = {0}", min);
        Console.WriteLine("maximum number = {0}", max);

            max = (a > b) ? a : b;
            min = (a < b) ? a : b;
        Console.WriteLine("using ternary operator...");
        Console.WriteLine("minimum number = {0}", min);
        Console.WriteLine("maximum number = {0}", max);
            Console.ReadLine();
        }
    }
