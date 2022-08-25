using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class Problem4
    {
        public static void Splite(string str)
        {
            string[] sep = { "#" };
            string[] result = str.Split(sep, 2, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}