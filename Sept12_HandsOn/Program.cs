using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sept12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\INDIA\source\New Repo\HandsON\12_Sep_Handson\ClassLibrary\bin\Debug\ClassLibrary.dll";

            Assembly asm = Assembly.LoadFrom(path);
            //  Assembly asm1=Assembly.GetAssembly(typeof(path));
            Type[] types = asm.GetTypes();
            foreach (var item in types)
            {
                Console.WriteLine("name= " + item.Name);//classname
                Console.WriteLine("Full Name= " + item.FullName);//(assemblyname/namespacename) . class

                Console.WriteLine("IS Class=" + item.IsClass);
                Console.WriteLine("IS Absatract=" + item.IsAbstract);
                Console.WriteLine("Whether public " + item.IsPublic);


                Console.WriteLine("-----------------");
                MethodInfo[] methods = item.GetMethods();
                foreach (var method in methods)
                {
                    // for displaying each method
                    Console.WriteLine("--> Method : {0}", method.Name);



                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        Console.WriteLine(" Parameter : {0} Type : {1}",
                        arg.Name, arg.ParameterType);


                    }
                }
                Console.WriteLine("#############################################3");
                Type t = null;
                t = asm.GetType(item.FullName);

                object obj = Activator.CreateInstance(t);

                int ans = (int)item.InvokeMember("Cube", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[2] { 4, 9 });


                //double ans1 = (double)
                item.InvokeMember("SquareRoot", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[2] { 16.00, 100.00 });

                break;

            }          //Part A
            Console.WriteLine("#######################");
            Program.WritedataForEachCode(typeof(Song));
            Console.Read();
        }
        static void WritedataForEachCode(Type t)
        {
            Console.WriteLine("Methods " + t.Name);

            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);  // Reflection.  

            // Displaying output.  
            foreach (System.Attribute attr in attrs)
            {
                if (attr is DeveloperAttribute)
                {
                    DeveloperAttribute a = (DeveloperAttribute)attr;
                    Console.WriteLine(a.SongName);

                }
            }
            Console.WriteLine("---------------------------------");
            MemberInfo[] minfo = t.GetMembers();

            foreach (var item in minfo)
            {
                System.Attribute[] attrs1 = System.Attribute.GetCustomAttributes(item);

                foreach (System.Attribute attrItem in attrs1)
                {
                    if (attrItem is DeveloperAttribute)
                    {
                        DeveloperAttribute a = (DeveloperAttribute)attrItem;
                        System.Console.WriteLine(a.SongName);
                        //System.Console.WriteLine(a.Language);
                        //System.Console.WriteLine(a.Lyrics);
                    }
                }

            }
        }
    }
}