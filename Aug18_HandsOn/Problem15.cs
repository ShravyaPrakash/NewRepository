
using System;

class Problem15
{
    public static void Main(string[] args)
    {
        Console.WriteLine("please enter dollars:");
        double dollars = Convert.ToDouble(Console.ReadLine());
        double rupees = dollars * 64;
        Console.WriteLine(rupees + " rupees");
    }
}