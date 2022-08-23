
using System;

public class Problem3
{
    public static void Main()
    {
        Console.Write("enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
        Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
    }
}