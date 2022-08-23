
using System;

public class Problem7
{
    public static void Main()
    {
        int num;

        Console.WriteLine("enter a digit: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.Write(num);
        Console.Write(" ");
        Console.Write(num);
        Console.Write(" ");
        Console.Write(num);
        Console.Write(" ");
        Console.Write(num);
        Console.WriteLine();

        Console.Write(num);
        Console.Write(num);
        Console.Write(num);
        Console.WriteLine(num);
        Console.WriteLine();
        Console.WriteLine("{0} {0} {0} {0}", num);


        Console.WriteLine("{0}{0}{0}{0}", num);
    }
}