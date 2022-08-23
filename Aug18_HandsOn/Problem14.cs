
using System;


    class Problem14
    {
        static void Main(string[] args)
        {
            Console.Write("enter temperature in celsius : ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = ((celsius * 9) / 5) + 32;
            Console.WriteLine("the converted fahrenheit temperature is : " + fahrenheit);
            Console.ReadLine();
        }
    }
