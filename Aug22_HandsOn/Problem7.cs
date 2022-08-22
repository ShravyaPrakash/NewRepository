using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Problem7
    {
        static void Main(string[] args)
        {
            Queue s = new Queue(2);
            s.Enqueue(1);
            s.Enqueue(2);
            s.Enqueue(3);
            s.Enqueue("Shravya");
            s.Enqueue("Prakash");
            Console.WriteLine("Peek value");
            object t = s.Peek();
            Console.WriteLine(t);
            int cnt = s.Count;
            Console.WriteLine("Size of stack before dequeing");
            Console.WriteLine(cnt);
            object i = s.Dequeue();
            Console.WriteLine("deqeued value:");
            Console.WriteLine(i);
            int cnt2 = s.Count;
            Console.WriteLine("Size of stack after dequeing");
            Console.WriteLine(cnt2);
        }
    }
