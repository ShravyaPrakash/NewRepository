
using System;

public class Problem8
{
    public static void Main()
    {
        Console.WriteLine("enter a number");
        int x = Int32.Parse(Console.ReadLine());
        Console.WriteLine("{0}{0}{0}", x);

        Console.WriteLine("{0} {0}", x);

        Console.WriteLine("{0} {0}", x);

        Console.WriteLine("{0} {0}", x);

        Console.WriteLine("{0}{0}{0}", x);
    }
}