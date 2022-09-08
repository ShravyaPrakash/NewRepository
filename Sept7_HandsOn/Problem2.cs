using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public delegate string GreetDelegate(string Name);
    public class Problem2
    {

        public string GreetUser(string Name)
        {
            string greetmsg = "Hello " + Name + " , Welcome in my world!";
            return greetmsg;
        }
    }
}