using System;
using System.IO;
using System.Text;


    class Problem2
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int large;
        Console.Write("enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter third number : ");
            c = Convert.ToInt32(Console.ReadLine());
        if (a > b && a > c)
                large = a;
            else if (b > a && b > c)
                large = b;
            else large = c;

        Console.WriteLine("using if-else...");
        Console.WriteLine("largest number is {0}", large);
            large = (a > b && a > c) ? a : (b > a && b > c) ? b : c;
        Console.WriteLine("using ternary operator...");
        Console.WriteLine("largest number is {0}", large);

            Console.ReadLine();
        }
    }
