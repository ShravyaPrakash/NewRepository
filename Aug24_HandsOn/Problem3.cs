using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class Problem3
    {
        public static void Index(string str, char ch)
        {
            int i = str.IndexOf(ch);
            Console.WriteLine($"Index of {ch} in given string {str} is : {i}");

        }
    }
}