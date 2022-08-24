using System;

 class Problem2
{
	public int sum(int a, int b )
	{
		return (a + b);
	}
	public static void Main(string[] args)
	{
		int p, q, r;
		Problem2 p1 = new Problem2();
		Console.Write("Enter 2 numbers \n");
		p = int.Parse(Console.ReadLine());
		q= int.Parse(Console.ReadLine());

		r = p1.sum(p, q);
		Console.WriteLine("Sum= " + r);
		Console.ReadLine();
    }
}
