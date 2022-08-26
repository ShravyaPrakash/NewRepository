using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    internal class Problem2
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\HP\source\repos\Aug25\newfileProblem2\";
            Console.WriteLine("Enter the file name");
            string fname = Console.ReadLine();
            fname = string.Concat(path, fname);

            // Problem a
            File.Create(fname);
            File.WriteAllText(fname, "Hello, Good Morning");
            Console.WriteLine($"{fname} File Created...");

            //Problem b and c
            fname = string.Concat(fname,"\\");
            File.Copy(fname, "copy.txt");
            File.Move(fname, "move.txt");

            // Problem d -- Checking file existance
            bool fileExists = File.Exists(fname);
            Console.WriteLine("File Exists=  " + fileExists);

            //Problem e -- Delete file
            File.Delete(fname);

            // problem f -- creation time of the file..
             DateTime dt = new DateTime();
             FileInfo fi = new FileInfo(fname);
             dt = fi.CreationTime;
             Console.WriteLine($"Creation time of the file : {dt}");

            //  problem g --Directory of the file
            string str = fi.DirectoryName;
            Console.WriteLine($"{str} is directory name...");

            


        }
    }
