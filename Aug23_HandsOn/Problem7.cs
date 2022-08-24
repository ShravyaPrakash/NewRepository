using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

    internal class Problem7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First integer: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second integer: ");
            int j = Convert.ToInt32(Console.ReadLine());
            try
            {
                int div = i / j;
                Console.WriteLine($"Division : {div}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                int linenumber = (new StackTrace(ex, true)).GetFrame(0).GetFileLineNumber();
                Console.WriteLine($"The error found in line number : {linenumber}");
            }
            Console.ReadLine();
        }
    }

