using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Problem12
    {
        static void Main(string[] args)
        {
            string str = "";
            string str1 = string.Empty;
            string str2;
            Console.WriteLine("enter first number: ");
            string i1 = Console.ReadLine();
            Console.WriteLine("enter second number: ");
            string i2 = Console.ReadLine();
            bool b1 = string.IsNullOrEmpty(i1);
            Console.WriteLine(b1);
            bool b2 = string.IsNullOrEmpty(i2);
            Console.WriteLine(b2);
        }
    }
