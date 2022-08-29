using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Problem3
    {
        public static void Main()
        {
            List<string> products = new List<string>();
            products.Add("Mobile");
            products.Add("Laptop");
            products.Add("Speaker");
            products.Add("Printer");

            Console.WriteLine("List of Products are:");

            foreach (string p in products)
            {

                Console.WriteLine(p);

            }
            Console.WriteLine("count is " + products.Count);
            Console.WriteLine("\n");

            products.Add("Scanner");

            foreach (string l in products)
            {

                Console.WriteLine(l);



            }
            Console.WriteLine("count after adding is " + products.Count);
            Console.WriteLine("\n");

            products.Remove("Laptop");
            products.Remove("Mobile");
            Console.WriteLine("count after deleting is " + products.Count);

            Console.WriteLine("List of Products are :");

            foreach (string l in products)
            {

                Console.WriteLine(l);



            }
            Console.Read();
        }
    }
