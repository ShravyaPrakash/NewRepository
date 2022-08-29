using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Students
    {
        private int rollno;
        private string name;
        private int age;

        public void SetInfo(string name, int rollno, int age)
        {
            this.rollno = rollno;
            this.age = age;
            this.name = name;
        }

        public void printInfo()
        {
            Console.WriteLine("Student Record: ");
            Console.WriteLine("\tName     : " + name);
            Console.WriteLine("\tRollNo   : " + rollno);
            Console.WriteLine("\tAge      : " + age);
        }

    }

    class Problem2
    {
        static void Main()
        {
            Students[] S = new Students[2];
            S[0] = new Students();
            S[1] = new Students();
            S[0].SetInfo("Shravya", 101, 25);
            S[0].printInfo();
            S[1].SetInfo("Prakash", 102, 27);
            S[1].printInfo();

        }
    }
