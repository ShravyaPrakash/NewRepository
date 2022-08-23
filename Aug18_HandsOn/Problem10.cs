using System;
using System.Collections.Generic;


public class Problem10
{
    static void Main(string[] args)
    {
        Console.WriteLine("\ninput first integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("input second integer:");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("check if one is negative and one is positive:");
        Console.WriteLine((x > 0 && y > 0) || (x > 0 && y < 0));
    }
}