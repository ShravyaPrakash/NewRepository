using System;
class Problem1
{
    public void sum()
    {
        int a, b;
        Console.WriteLine("Enter two numbers: ");
        a = int.Parse(Console.ReadLine());
        b= int.Parse(Console.ReadLine());
        Console.WriteLine("Sum= " + (a + b));
    }
    public static void Main(string[] args)
    {
        Problem1 p1 = new Problem1();
        p1.sum();
        Console.ReadLine();
       
    }
}