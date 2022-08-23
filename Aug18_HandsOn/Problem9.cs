
using System;

public class Problem9
{
    public static void Main()
    {
        Console.WriteLine("enter temperature in celsius:");
        int celsius = Int32.Parse(Console.ReadLine());
        Console.WriteLine("kelvin= {0}", celsius + 273);
        Console.WriteLine("fahrenhit = {0}", celsius * 18 / 10 + 32);
    }
}