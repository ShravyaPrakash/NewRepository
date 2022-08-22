using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Problem9
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(9.34f);

            al.Add(1.2f);
            al.Add(1.3f);
            al.Add(34.4f);
            al.Add(34.45f);
            al.Add(33.65f);
            al.Add(11.11f);
            foreach (float i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("IN asscending order: " );
            al.Sort();
            foreach (float i in al)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
