using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Problem3
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\HP\source\repos\Aug25\";
            Console.WriteLine("Enter the directory name...");
            string str = Console.ReadLine();
            path = path + str;
            //Creationofdirectories(path);
            Gothroughthdirectories(path);
            Console.ReadLine();
            Console.ReadLine();
        }

        private static void Gothroughthdirectories(string path)
        {
            string[] fnames = Directory.GetDirectories(path);
            foreach (var item in fnames)
            {
                Console.WriteLine();
                Console.WriteLine($"{item} directory");
                Console.WriteLine(item);
                string[] ename = Directory.GetDirectories(item);
                foreach (var item1 in ename)
                {
                    Console.WriteLine(item1);
                    string[] kname = Directory.GetDirectories(item1);
                }
            }
        }

        private static void Creationofdirectories(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine($"{path} Directory is Created...");
            }
            Console.WriteLine("Enter a number to create subdirectory");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the Subdirectory Name");
                string subdir = "";
                subdir = Console.ReadLine();
                subdir = path + "\\" + subdir;
                if (!Directory.Exists(subdir))
                {
                    Directory.CreateDirectory(subdir);
                    Console.WriteLine($"{subdir} Subdirectory is Created...");
                }
                Console.Write("Enter the number of files to create: ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the files name to create in this directory...");
                string[] str1 = new string[m];
                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++)
                {
                    str1[j] = s[j];
                }
                foreach (string st in str1)
                {
                    string str2 = "";
                    str2 = subdir + "\\" + st;
                    Directory.CreateDirectory(str2);
                    Console.WriteLine($"{str2} Subdirectory is Created...");

                }



            }
        }
    }
