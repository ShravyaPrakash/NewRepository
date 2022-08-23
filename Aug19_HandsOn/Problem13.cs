
using System;

public class Problem13
{
    public static void Main()
    {
        int num1, rem1;
        Console.Write("input an integer : ");
        num1 = Convert.ToInt32(Console.ReadLine());
        rem1 = num1 % 2;
        if (num1 == 0)
            Console.WriteLine("{0} is zero\n", num1);
        if (rem1 == 0)
            Console.WriteLine("{0} is an even integer.\n", num1);
        if (rem1 != 0)
            Console.WriteLine("{0} is an odd integer.\n", num1);
        if (num1 % 10 == 0)
            Console.WriteLine("{0} is a multiple of 10\n", num1);
        if (num1 > 100)
            Console.WriteLine("{0} is greater than 100\n", num1);

    }
}