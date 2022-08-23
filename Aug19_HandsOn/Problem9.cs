
using System;

public class Problem9
{
    public static void Main()
    {
        int i, n, sum = 0;
        Console.Write("\n\n");

        Console.Write("input number of terms : ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nthe odd numbers are :");
        for (i = 1; i <= n; i++)
        {
            Console.Write("{0} ", 2 * i - 1);
            sum += 2 * i - 1;
        }
        Console.Write("\nthe sum of odd natural number upto {0} terms : {1} \n", n, sum);
    }
}