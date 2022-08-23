
using System;

public class Problem5
{
    public static void Main()
    {
        int first, second;

        Console.WriteLine("enter the first number : ");
        first = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter the second number : ");
        second = Convert.ToInt32(Console.ReadLine());

        if (first > second)
        {
            Console.WriteLine("first number is biggest");
        }
        else
        {
            Console.WriteLine("second number is biggest");
        }
    }
}