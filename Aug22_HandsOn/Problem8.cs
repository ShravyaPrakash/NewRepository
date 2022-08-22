using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  internal class Problem8
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(1, "Bihar");
            h.Add(2, "UttarPradesh");
            h.Add(3, "Delhi");
            h.Add(4, "Jharkhand");
            h.Add(5, "Uttrakhand");
            IDictionaryEnumerator ie = h.GetEnumerator();
            while (ie.MoveNext())
            {
                {
                    Console.WriteLine(ie.Key + "  " + ie.Value);
                }
                Console.WriteLine("Using for each");
                foreach (DictionaryEntry item in h)
                {
                    Console.WriteLine(item.Key + "  " + item.Value);

                }

            }
            Console.ReadLine();
        }
    }
