using System;

struct Employees
{
    public int empno;
    public string ename;
    public int sal;
    public int deptno;
};

public class Problem3
{
    public static void Main(string[] args)
    {
        Employees emp1;   
        Employees emp2;   

        emp1.empno = 100;
        emp1.ename = "Shravya";
        emp1.sal = 10000000;
        emp1.deptno = 500;

        emp2.empno = 200;
        emp2.ename = "Prakash";
        emp2.sal = 20000000;
        emp2.deptno = 600;

      
        Console.WriteLine("Employee 1 Number : {0}", emp1.empno);
        Console.WriteLine("Employee 1 Name : {0}", emp1.ename);
        Console.WriteLine("Employee 1 Salary : {0}", emp1.sal);
        Console.WriteLine("Employee 1 Department Number : {0}", emp1.deptno);


        Console.WriteLine("Employee 2 Number : {0}", emp2.empno);
        Console.WriteLine("Employee 2 Name : {0}", emp2.ename);
        Console.WriteLine("Employee 2 Salary : {0}", emp2.sal);
        Console.WriteLine("Employee 2 Department Number : {0}", emp2.deptno);

        Console.ReadKey();
    }
}