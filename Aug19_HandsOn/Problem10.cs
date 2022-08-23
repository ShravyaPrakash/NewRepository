
using System;

public class Problem10
{
    public static void Main()
    {
        int num, r, sum = 0, t;

        Console.Write("\n\n");


        Console.Write("input a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (t = num; t != 0; t = t / 10)
        {
            r = t % 10;
            sum = sum * 10 + r;
        }
        Console.Write("the number in reverse order is : {0} \n", sum);
    }
}