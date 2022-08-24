using System;

struct Employee
{
    public int empno;
    public string ename;
    public int sal;
    public int deptno;
    public Employee(int employeeId, string employeeName, int salary, int departmentNo)
    {

        empno = employeeId;
        ename = employeeName;
        sal = salary;
        deptno = departmentNo;
    }
}

class Problem4
{
    static void Main(string[] args)
    {

        Employee emp = new Employee();
        Console.Write("Enter Employee Number " );
        emp.empno = int.Parse(Console.ReadLine());
        Console.Write("Enter Employee Name ");
        emp.ename = Console.ReadLine();
        Console.Write("Enter Employee Salary ");
        emp.sal = int.Parse(Console.ReadLine());
        Console.Write("Enter Employee Department Number ");
        emp.deptno = int.Parse(Console.ReadLine());

        Console.WriteLine("Employee Number: " + emp.empno);
        Console.WriteLine("Employee Name: " + emp.ename);
        Console.WriteLine("Employee Salary: " + emp.sal);
        Console.WriteLine("Employee Department Number: " + emp.deptno);

        Console.ReadLine();
    }
}
