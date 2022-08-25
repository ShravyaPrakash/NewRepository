using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReusableCodeLibrary;

namespace Aug24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1.PrintString();
            Console.ReadLine();

            // Problem 1
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();
            Problem1.Compare(str1, str2);

            // Problem 2
            Console.Write("Enter a string: ");
            string str3 = Console.ReadLine();
            Problem2.Copy(str3);

            // Problem 3
            Console.Write("Enter a string: ");
            string str4 = Console.ReadLine();
            Console.Write("Enter a Character which index have to find : ");
            char ch = Convert.ToChar(Console.ReadLine());
            Problem3.Index(str4, ch);

            // Problem 4
            Console.Write("Enter the string :");
            string str5 = Console.ReadLine();
            Problem4.Splite(str5);

            // Problem 5
            Console.Write("Enter the string :");
            string str6 = Console.ReadLine();
            Problem5.Case(str6);

            // Problem 6
            Problem6.FirstFile();

            // Problem 7
            DateTime dt = DateTime.Now;
            Problem7.Date(dt);





        }
    }
}