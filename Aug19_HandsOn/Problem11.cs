
using System;

public class Problem11
{
    public static void Main()
    {
        int i, sum = 0;


        Console.Write("numbers between 100 and 200 : \n");
        for (i = 101; i < 200; i++)
        {
            Console.Write("{0}  ", i);
            sum += i;
        }
        Console.Write("\n\nthe sum : {0} \n", sum);
    }
}