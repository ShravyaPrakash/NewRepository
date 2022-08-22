using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Problem10
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> h = new Dictionary<int, string>();
            h.Add(1, "AAA");
            h.Add(2, "BBB");
            h.Add(3, "CCC");
            h.Add(4, "DDD");
            h.Add(5, "EEE");

            string s = h[5].ToString();
            IDictionaryEnumerator ie = h.GetEnumerator();
            Console.WriteLine("While (Before Remove)");
            while (ie.MoveNext())
            {
                Console.WriteLine("items {0}  {1}", ie.Key, ie.Value);
            }
            Console.WriteLine("forEach(After Remove)");
            h.Remove(5);
            foreach (var item in h)
            {
                Console.WriteLine($"key {item.Key} value {item.Value}");
            }
            Console.WriteLine("TOstring");
            Console.WriteLine(s); ;
        }
    }

