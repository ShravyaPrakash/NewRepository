using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlTypes;


    internal class Problem1
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Press 1. To create a file:");
            Console.WriteLine("Press 2. To write the file:");
            Console.WriteLine("Press 3. To read something:");
            Console.WriteLine("Press 4. To trucate: ");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("Enter a file name to create a file : ");
                    string txt = Console.ReadLine();
                    FileStream fs = new FileStream(txt, mode: FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    fs.Close();
                    fs.Dispose();
                    break;

                case 2:
                    Console.Write("File name : ");
                    string str1 = Console.ReadLine();
                    Console.Write("Enter the text to add: ");
                    string str = Console.ReadLine();
                    StreamWriter sw = new StreamWriter(str1);
                    sw.WriteLine(str);
                    sw.Flush();
                    sw.Close();
                    sw.Dispose();
                    break;
                case 3:
                    Console.Write("File name : ");
                    string str2 = Console.ReadLine();
                    StreamReader sr = new StreamReader(str2);
                    string content = sr.ReadToEnd();
                    Console.Write(content);
                    sr.Close();
                    sr.Dispose();
                    break;
                case 4:
                    Console.WriteLine("Enter the file name to truncate...");
                    string str3 = Console.ReadLine();
                    FileStream ts = new FileStream(str3, FileMode.Truncate, FileAccess.Write);
                    Console.WriteLine("Truncated");
                    ts.Close();
                    ts.Dispose();
                    break;
            }
            Console.ReadLine();




        }
    }
