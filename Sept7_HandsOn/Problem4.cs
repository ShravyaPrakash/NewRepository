using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public delegate void ProductDelegateID(int id);
    public delegate void ProductDelegateName(String Name);
    public class Problem4
    {
        public void prodId(int id)
        {
            Console.WriteLine("Product Id : {0}", id);
        }
        public void prodName(string Name)
        {
            Console.WriteLine("Product Name : {0}", Name);
        }
    }
}