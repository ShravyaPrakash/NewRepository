
using System;

public class Problem13
{
    public static double Metertokilometer(double meter)
    {
        double km = 0;

        km = meter / 1000;

        return km;
    }

    public static double Kilometertometer(double km)
    {
        double meter = 0;

        meter = km * 1000;

        return meter;
    }

    static void Main()
    {
        double meter = 0;
        double km = 0;

        Console.Write("enter the value of meter : ");
        meter = double.Parse(Console.ReadLine());

        km = Metertokilometer(meter);
        Console.WriteLine("kilometer : " + km + "km");

        Console.Write("enter the value of kilometer : ");
        km = double.Parse(Console.ReadLine());

        meter = Kilometertometer(km);
        Console.WriteLine("meter : " + meter + "m");

    }
}