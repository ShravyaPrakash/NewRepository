using System;

public struct Student
{

    public int RollNo;
    public string Name;
    public int Percentage;
    public void SetStudent(int Rollno, string name, int percent)
    {
        RollNo = Rollno;
        Name = name;
        Percentage = percent;
    }

    public void DisplayStudent()
    {
        Console.WriteLine("Student Details:");
        Console.WriteLine("\tRoll Number : " + RollNo);
        Console.WriteLine("\tName : " + Name);
        Console.WriteLine("\tPercentage : " + Percentage);
        Console.WriteLine("\n");
    }
}

public class Problem1
{

    static void Main(string[] args)
    {

        Student[] std = { new Student(), new Student(), new Student() };

        std[0].SetStudent(1, "AAA", 95);
        std[1].SetStudent(2, "BBB", 94);
        std[2].SetStudent(3, "CCC", 96);


        std[0].DisplayStudent();
        std[1].DisplayStudent();
        std[2].DisplayStudent();
    }
}