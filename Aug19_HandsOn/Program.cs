//problem 1 swapbyvalue

using system;
public class swapbyvalue
{
    public static void main(string[] args)
    {
        int number1, number2, temp;
        console.write("\ninput the first number : ");
        number1 = int.parse(console.readline());
        console.write("\ninput the second number : ");
        number2 = int.parse(console.readline());
        temp = number1;
        number1 = number2;
        number2 = temp;
        console.write("\nafter swapping : ");
        console.write("\nfirst number : " + number1);
        console.write("\nsecond number : " + number2);
        console.read();
    }
}

//problem 1 swapbyreference



// problem 2

using system;
public class multiply
{
    public static void main()
    {
        int num1, num2, num3;

        console.write("input the first number to multiply: ");
        num1 = convert.toint32(console.readline());

        console.write("input the second number to multiply: ");
        num2 = convert.toint32(console.readline());

        console.write("input the third number to multiply: ");
        num3 = convert.toint32(console.readline());

        int result = num1 * num2 * num3;
        console.writeline("output: {0} x {1} x {2} = {3}",
                            num1, num2, num3, result);
    }
}

//problem 3

using system;
public class calculation
{
    public static void main()
    {
        console.write("enter a number: ");
        int num1 = convert.toint32(console.readline());

        console.write("enter another number: ");
        int num2 = convert.toint32(console.readline());

        console.writeline("{0} + {1} = {2}", num1, num2, num1 + num2);
        console.writeline("{0} - {1} = {2}", num1, num2, num1 - num2);
        console.writeline("{0} x {1} = {2}", num1, num2, num1 * num2);
        console.writeline("{0} / {1} = {2}", num1, num2, num1 / num2);
        console.writeline("{0} mod {1} = {2}", num1, num2, num1 % num2);
    }
}

//problem 4

using system;
using system.io;
public class average
{
    public static void main()
    {
        double number1, number2, number3, number4;

        console.write("enter the first number: ");
        number1 = convert.todouble(console.readline());

        console.write("enter the second number: ");
        number2 = convert.todouble(console.readline());

        console.write("enter the third number: ");
        number3 = convert.todouble(console.readline());

        console.write("enter the fourth number: ");
        number4 = convert.todouble(console.readline());

        double result = (number1 + number2 + number3 + number4) / 4;
        console.writeline("the average of {0}, {1}, {2}, {3} is: {4} ",
     number1, number2, number3, number4, result);
    }
}

//problem 5

using system;
public class maths
{
    public static void main()
    {
        int number1, number2, number3;

        console.write("enter first number - ");
        number1 = convert.toint32(console.readline());

        console.write("enter second number - ");
        number2 = convert.toint32(console.readline());

        console.write("enter third number - ");
        number3 = convert.toint32(console.readline());

        console.write("result of specified numbers {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n",
            number1, number2, number3, ((number1 + number2) * number3), (number1 * number2 + number2 * number3));
    }
}


//problem 6

using system;
public class age
{
    public static void main()
    {
        int age;
        console.write("enter your age ");
        age = convert.toint32(console.readline());
        console.write("you look older than {0} ", age);
    }
}

//problem 7

using system;
public class digit
{
    public static void main()
    {
        int num;

        console.writeline("enter a digit: ");
        num = convert.toint32(console.readline());

        console.write(num);
        console.write(" ");
        console.write(num);
        console.write(" ");
        console.write(num);
        console.write(" ");
        console.write(num);
        console.writeline();

        console.write(num);
        console.write(num);
        console.write(num);
        console.writeline(num);
        console.writeline();
        console.writeline("{0} {0} {0} {0}", num);


        console.writeline("{0}{0}{0}{0}", num);
    }
}

//problem 8

using system;
public class digits
{
    public static void main()
    {
        console.writeline("enter a number");
        int x = int32.parse(console.readline());
        console.writeline("{0}{0}{0}", x);

        console.writeline("{0} {0}", x);

        console.writeline("{0} {0}", x);

        console.writeline("{0} {0}", x);

        console.writeline("{0}{0}{0}", x);
    }
}


//problem 9

using system;
public class ecelsiustokelvin
{
    public static void main()
    {
        console.writeline("enter temperature in celsius:");
        int celsius = int32.parse(console.readline());
        console.writeline("kelvin= {0}", celsius + 273);
        console.writeline("fahrenhit = {0}", celsius * 18 / 10 + 32);
    }
}

//problem 10

using system;
using system.collections.generic;

public class trueorfalse
{
    static void main(string[] args)
    {
        console.writeline("\ninput first integer:");
        int x = convert.toint32(console.readline());
        console.writeline("input second integer:");
        int y = convert.toint32(console.readline());
        console.writeline("check if one is negative and one is positive:");
        console.writeline((x > 0 && y > 0) || (x > 0 && y < 0));
    }
}

//problem 11

using system;
using system.collections.generic;

public class falseortrue
{
    static void main(string[] args)
    {
        console.writeline("\ninput first integer:");
        int x = convert.toint32(console.readline());
        console.writeline("input second integer:");
        int y = convert.toint32(console.readline());
        console.writeline("check if one is negative and one is positive:");
        console.writeline(x > 0 && y > 0);
    }
}

//problem 12

//problem 13

using system;

public class metertokm
{
    public static double metertokilometer(double meter)
    {
        double km = 0;

        km = meter / 1000;

        return km;
    }

    public static double kilometertometer(double km)
    {
        double meter = 0;

        meter = km * 1000;

        return meter;
    }

    static void main()
    {
        double meter = 0;
        double km = 0;

        console.write("enter the value of meter : ");
        meter = double.parse(console.readline());

        km = metertokilometer(meter);
        console.writeline("kilometer : " + km + "km");

        console.write("enter the value of kilometer : ");
        km = double.parse(console.readline());

        meter = kilometertometer(km);
        console.writeline("meter : " + meter + "m");

    }
}

//problem 14

using system;
namespace celsius
{
    class celsiustofahrenheit
    {
        static void main(string[] args)
        {
            console.write("enter temperature in celsius : ");
            double celsius = convert.todouble(console.readline());
            double fahrenheit = ((celsius * 9) / 5) + 32;
            console.writeline("the converted fahrenheit temperature is : " + fahrenheit);
            console.readline();
        }
    }
}

//program 15

using system;

class ustoindian
{
    public static void main(string[] args)
    {
        console.writeline("please enter dollars:");
        double dollars = convert.todouble(console.readline());
        double rupees = dollars * 64;
        console.writeline(rupees + " rupees");
    }
}


