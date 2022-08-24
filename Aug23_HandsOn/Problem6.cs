using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Problem6
    {
        enum deptnames
        {
            Purchase = 1,
            Sales = 2,
            Training = 3,
            Accounts = 4

        }
        public static void Main()
        {
            int count = 0;
            foreach (deptnames d in Enum.GetValues(typeof(deptnames)))
            {
                count++;
                Console.Write("deptname " + count + "...");
                Console.WriteLine(d);
            }
        }
    }
