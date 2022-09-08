using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public delegate int StringLenghtDelegate(string s);
    public class Problem1
    {
        public int len(string s)
        {
            int i = s.Length;
            return i;
        }
    }
}