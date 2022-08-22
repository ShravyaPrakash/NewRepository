using System;
public class Problem3
{
    public static void Main()
    {
        int[] arr = new int[100];
        int i, n, sum = 0;


        Console.WriteLine("Enter size of array :");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input {0} elements in the array :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("element - {0} : ", i + 1);
            arr[i] = Convert.ToInt32(Console.ReadLine()); // read user input
        }

        for (i = 0; i < n; i++)
        {
            sum += arr[i];
        }

        Console.Write("Sum of all elements in the array is : {0}\n\n", sum);
    }
}