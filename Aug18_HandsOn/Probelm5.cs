
using System;

public class Problem5
{
    public static void Main()
    {
        int number1, number2, number3;

        Console.Write("enter first number - ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter second number - ");
        number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter third number - ");
        number3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("result of specified numbers {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n",
            number1, number2, number3, ((number1 + number2) * number3), (number1 * number2 + number2 * number3));
    }
}