using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Problem11
    {
        static void Main(string[] args)
        {
            SortedList<int, string> s = new SortedList<int, string>();
            s.Add(23, "AAA");
            s.Add(45, "BBB");
            s.Add(56, "CCC");
            s.Add(54, "DDD");
            s.Add(433, "EEE");
            s.Add(65, "FFF");
            foreach (var item in s)
            {
                Console.WriteLine($"key : {item.Key} value : {item.Value}");
            }
        }
    }

