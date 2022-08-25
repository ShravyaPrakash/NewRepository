using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class Problem6
    {
        public static void FirstFile()
        {
            string path = @"C:\Users\HP\source\repos\Aug24\CreateFile";
            Console.WriteLine("File Created");
            File.Create(path);
        }
    }
}