using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Problem5
    {
        struct Employee
        {
            public int Empno;
            public string Empname;
            public int Salary;
            public int Deptno;

            public void AcceptBookData(int empno, string empname, int salary, int deptno)
            {
                Empno = empno;
                Empname = empname;
                Salary = salary;
                Deptno = deptno;


            }

            public void DisplayInfo()
            {
                Console.WriteLine();
                Console.WriteLine("Now Printing the details....");
                Console.WriteLine(Empno);
                Console.WriteLine(Empname);
                Console.WriteLine(Salary);
                Console.WriteLine(Deptno);

            }
            static void Main(string[] args)
            {
                Console.Write("Enter the no of array: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Employee[] emp = new Employee[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Taking Data for {i + 1} Employee");
                    Console.Write("Enter employee EmpId: ");
                    emp[i].Empno = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter employee EmpName: ");
                    emp[i].Empname = Console.ReadLine();
                    Console.Write("Enter employee salary: ");
                    emp[i].Salary = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter employee department number: ");
                    emp[i].Deptno = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();


                    Console.WriteLine($"Details of {i + 1} Employee");
                    emp[i].DisplayInfo();

                }
                Console.ReadLine();
            }
        }
    }
