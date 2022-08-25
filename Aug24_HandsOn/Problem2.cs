using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class Problem2
    {
        public static void Copy(string str3)
        {
            string str4 = String.Copy(str3);
            Console.WriteLine($"Original string : {str3}");
            Console.WriteLine($"Copied string : {str4}");
        }
    }
}