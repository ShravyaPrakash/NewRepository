using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Bankss
    {
        public int x, y;
        public Bankss()
        {
            x = 1000;
            y = 2000;
        }


    }
    public static class curr
    {

        public static void current(this Bankss obj)
        {
            Console.WriteLine("current balance " + obj.x);
        }
        public static void deposits(this Bankss obj)
        {
            Console.WriteLine("enter the amount to deposit in current aacnt");
            int dep = Convert.ToInt32(Console.ReadLine());
            obj.x = dep + obj.x;
            Console.WriteLine("AMOUNT DEPOSIT");
        }
        public static void withdraw(this Bankss obj)
        {
            Console.WriteLine("enter the amount to withdraw in current aacnt");
            int with = Convert.ToInt32(Console.ReadLine());
            if (with < obj.x)
                obj.x = obj.x - with;
            else
                Console.WriteLine("amount can't be withdraw");
            Console.WriteLine("AMOUNT WITHDRAW");

        }
        public static void total_balc(this Bankss obj)
        {
            Console.WriteLine("total balance in current aacnt " + obj.x);
        }
    }
    public static class sav
    {

        public static void savings(this Bankss obj)
        {
            Console.WriteLine("saving balance" + obj.y);
        }
        public static void deposits1(this Bankss obj)
        {
            Console.WriteLine("enter the amount to deposit in savings accnt");
            int dep = Convert.ToInt32(Console.ReadLine());

            obj.y = dep + obj.y;
            Console.WriteLine("AMOUNT DEPOSIT");
        }
        public static void withdraw1(this Bankss obj)
        {
            Console.WriteLine("enter the amount to withdraw in savings accnt");
            int with = Convert.ToInt32(Console.ReadLine());
            if (with < obj.y)
                obj.y = obj.y - with;
            else
                Console.WriteLine("amount can't be withdraw");
            Console.WriteLine("AMOUNT WITHDRAW");
        }
        public static void total_balc1(this Bankss obj)
        {
            Console.WriteLine("total balance in current aacnt " + obj.y);
        }
    }
}