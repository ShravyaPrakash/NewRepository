// program 1

using system;
using system.io;
using system.text;

namespace includehelp
{
    class test
    {
        static void main(string[] args)
        {
            int a;
            int b;
            int min;
            int max;

            console.write("enter first number : ");
            a = convert.toint32(console.readline());
            console.write("enter second number: ");
            b = convert.toint32(console.readline());
            if (a > b)
                max = a;
            else
                max = b;
            if (a < b)
                min = a;
            else
                min = b;

            console.writeline("using if-else...");
            console.writeline("minimum number = {0}", min);
            console.writeline("maximum number = {0}", max);

            max = (a > b) ? a : b;
            min = (a < b) ? a : b;
            console.writeline("using ternary operator...");
            console.writeline("minimum number = {0}", min);
            console.writeline("maximum number = {0}", max);
            console.readline();
        }
    }
}

// program 2

using system;
using system.io;
using system.text;

namespace includehelp
{
    class test
    {
        static void main(string[] args)
        {
            int a;
            int b;
            int c;
            int large;
            console.write("enter first number : ");
            a = convert.toint32(console.readline());
            console.write("enter second number: ");
            b = convert.toint32(console.readline());
            console.write("enter third number : ");
            c = convert.toint32(console.readline());
            if (a > b && a > c)
                large = a;
            else if (b > a && b > c)
                large = b;
            else large = c;

            console.writeline("using if-else...");
            console.writeline("largest number is {0}", large);
            large = (a > b && a > c) ? a : (b > a && b > c) ? b : c;
            console.writeline("using ternary operator...");
            console.writeline("largest number is {0}", large);

            console.readline();
        }
    }
}

// program 3

using system;

public class program
{
    public static void main()
    {
        char c1, c2;

        console.writeline("enter the first character : ");
        c1 = console.readline()[0];

        console.writeline("enter the second character : ");
        c2 = console.readline()[0];

        if (c1 == c2)
            console.writeline("both characters are equal");
        else
            console.writeline("characters are not equal");
    }
}

// problem 4

using system;
using system.io;
using system.text;

namespace includehelp
{
    class test
    {
        static void main(string[] args)
        {
            string str1;
            string str2;

            console.write("enter a string: ");
            str1 = console.readline();
            console.write("enter another string: ");
            str2 = console.readline();
            if (str1 == str2)
                console.writeline("\"{0}\" and \"{1}\" are equal", str1, str2);
            else
                console.writeline("\"{0}\" and \"{1}\" are not equal", str1, str2);

            console.readline();
        }
    }
}

// problem 5

using system;

public class program
{
    public static void main()
    {
        int first, second;

        console.writeline("enter the first number : ");
        first = convert.toint32(console.readline());

        console.writeline("enter the second number : ");
        second = convert.toint32(console.readline());

        if (first > second)
        {
            console.writeline("first number is biggest");
        }
        else
        {
            console.writeline("second number is biggest");
        }
    }
}

// problem 6

using system;

namespace ginktageconsoleapp
{
    internal class program
    {
        private static void main(string[] args)
        {
            int year;

            console.write("input the year ");

            year = int.parse(console.readline());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                console.writeline("the entered year {0} is a leap year", year);
            }
            else
            {
                console.writeline("the entered year {0} is not a leap year", year);
            }
            console.readline();
        }
    }
}

//problem 7

using system;
using system.collections.generic;
using system.linq;
using system.text;

public class csharpexercise
{
    static void main(string[] args)
    {
        double phy, che, m, total;
        double per;
        string div;

        console.write("\n\n");
        console.write("calculate the total, percentage and division to take marks of three subjects:\n");
        console.write("-------------------------------------------------------------------------------");
        console.write("\n\n");



        console.write("input  the marks of physics : ");
        phy = convert.toint32(console.readline());
        console.write("input  the marks of  chemistry : ");
        che = convert.toint32(console.readline());
        console.write("input  the marks of maths  : ");
        m = convert.toint32(console.readline());

        total = phy + che + m;
        per = total / 3.0;
        if (per >= 60)
            div = "first";
        else
            if (per < 60 && per >= 45)
            div = "second";
        else
                if (per < 45 && per >= 35)
            div = "third";
        else
            div = "fail";

        console.write("marks in physics : {0}\nmarks in chemistry : {1}\nmarks in maths : {2}\n", phy, che, m);
        console.write("total marks = {0}\npercentage = {1}\ndivision = {2}\n", total, per, div);

        console.readline();
    }
}

//problem 8

using system;
using system.collections.generic;
using system.linq;
using system.text;
namespace starpattern
{
    class program
    {
        static void main(string[] args)
        {
            int x, y;
            for (x = 1; x <= 6; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    console.write("*");
                }
                console.writeline();
            }
            console.readline();
        }
    }
}

//problem 9

using system;
public class exercise
{
    public static void main()
    {
        int i, n, sum = 0;
        console.write("\n\n");

        console.write("input number of terms : ");
        n = convert.toint32(console.readline());
        console.write("\nthe odd numbers are :");
        for (i = 1; i <= n; i++)
        {
            console.write("{0} ", 2 * i - 1);
            sum += 2 * i - 1;
        }
        console.write("\nthe sum of odd natural number upto {0} terms : {1} \n", n, sum);
    }
}

//problem 10

using system;
public class exercise37
{
    public static void main()
    {
        int num, r, sum = 0, t;

        console.write("\n\n");


        console.write("input a number: ");
        num = convert.toint32(console.readline());

        for (t = num; t != 0; t = t / 10)
        {
            r = t % 10;
            sum = sum * 10 + r;
        }
        console.write("the number in reverse order is : {0} \n", sum);
    }
}

//program 11

using system;
public class exercise
{
    public static void main()
    {
        int i, sum = 0;


        console.write("numbers between 100 and 200 : \n");
        for (i = 101; i < 200; i++)
        {
            console.write("{0}  ", i);
            sum += i;
        }
        console.write("\n\nthe sum : {0} \n", sum);
    }
}


//program 12

using system;
public class exercise
{
    public static void main()
    {
        int i, sum = 0;

        console.write("numbers between 100 and 200, divisible by 9 : \n");
        for (i = 101; i < 200; i++)
        {
            if (i % 9 == 0)
            {
                console.write("{0}  ", i);
                sum += i;
            }
        }
        console.write("\n\nthe sum : {0} \n", sum);
    }
}


// program 13

using system;
public class exercise
{
    public static void main()
    {
        int num1, rem1;
        console.write("input an integer : ");
        num1 = convert.toint32(console.readline());
        rem1 = num1 % 2;
        if (num1 == 0)
            console.writeline("{0} is zero\n", num1);
        if (rem1 == 0)
            console.writeline("{0} is an even integer.\n", num1);
        if (rem1 != 0)
            console.writeline("{0} is an odd integer.\n", num1);
        if (num1 % 10 == 0)
            console.writeline("{0} is a multiple of 10\n", num1);
        if (num1 > 100)
            console.writeline("{0} is greater than 100\n", num1);

    }
}

// problem 14

using system;
using system.collections.generic;
using system.linq;
using system.text;
using system.threading.tasks;

namespace _19th_handson
{
    internal class problem14
    {
        static void main()
        {
            int i;
            console.writeline("enter a number : ");
            i = convert.toint32(console.readline());
            switch (i % 2)
            {
                case 0:
                    console.writeline("the number is even");
                    break;
                case 1:
                    console.writeline("the number is odd");
                    break;
                default:
                    console.writeline("the number is zero");
                    break;
            }
            console.readline();


        }
    }
}

// problem 15

using system;
using system.collections.generic;
using system.linq;
using system.text;
using system.threading.tasks;

namespace _19th_handson
{
    internal class exercise
    {
        static void main()
        {
            int i = 0, j = 25;
            while (i <= j)
            {
                console.writeline($"i = {i} and j = {j}");
                i++;
                j--;
            }
            console.writeline("crossed over");
            console.readline();

        }
    }
}

// problem 16

using system;
using system.collections.generic;
using system.linq;
using system.text;
using system.threading.tasks;

namespace _19th_handson
{
    internal class problem16
    {
        static void main()
        {
            int player = 100;
            string str;
            for (int i = 0; i < 4; i++)
            {
                console.write("enter hit or miss : ");
                str = console.readline();
                if (str == "hit")
                    player += 10;
                else if (str == "miss")
                    player -= 20;

            }
            console.writeline($"the player score after 4 shoot: {player}");
        }
    }
}


