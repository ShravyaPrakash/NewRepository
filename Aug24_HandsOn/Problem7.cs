using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class Problem7
    {
        public static void Date(DateTime dt)
        {
            Console.WriteLine("DateTime Properties");
            Console.WriteLine($"Year : {dt.Year}");
            Console.WriteLine($"Month : {dt.Month}");
            Console.WriteLine($"Day : {dt.Day}");
            Console.WriteLine($"Hour : {dt.Hour}");
            Console.WriteLine($"Minute : {dt.Minute}");
            Console.WriteLine($"Second : {dt.Second}");
            Console.WriteLine($"MiliSeconds : {dt.Millisecond}");
        }
    }
}