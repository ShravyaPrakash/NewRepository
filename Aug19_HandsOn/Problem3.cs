
using System;

public class Problem3
{
    public static void Main()
    {
        char c1, c2;

        Console.WriteLine("enter the first character : ");
        c1 = Console.ReadLine()[0];

        Console.WriteLine("enter the second character : ");
        c2 = Console.ReadLine()[0];

        if (c1 == c2)
            Console.WriteLine("both characters are equal");
        else
            Console.WriteLine("characters are not equal");
    }
}