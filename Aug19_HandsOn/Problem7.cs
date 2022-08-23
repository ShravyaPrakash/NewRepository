using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Problem7
{
    static void Main(string[] args)
    {
        double phy, che, m, total;
        double per;
        string div;


        Console.Write("input  the marks of physics : ");
        phy = Convert.ToInt32(Console.ReadLine());
        Console.Write("input  the marks of  chemistry : ");
        che = Convert.ToInt32(Console.ReadLine());
        Console.Write("input  the marks of maths  : ");
        m = Convert.ToInt32(Console.ReadLine());

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

        Console.Write("marks in physics : {0}\nmarks in chemistry : {1}\nmarks in maths : {2}\n", phy, che, m);
        Console.Write("total marks = {0}\npercentage = {1}\ndivision = {2}\n", total, per, div);

        Console.ReadLine();
    }
}
