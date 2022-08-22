using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Problem6
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(2);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push("Shravya");
            s.Push("Prakash");
            Console.WriteLine("Peek value");
            object t = s.Peek();
            Console.WriteLine(t);
            int cnt = s.Count;
            Console.WriteLine("Size of stack before popping");
            Console.WriteLine(cnt);
            object i = s.Pop();
            Console.WriteLine("Popped value:");
            Console.WriteLine(i);
            int cnt2 = s.Count;
            Console.WriteLine("Size of stack after popping");
            Console.WriteLine(cnt2);
        }
    }
