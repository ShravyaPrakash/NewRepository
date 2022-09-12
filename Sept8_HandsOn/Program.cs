using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Sept8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Authenticate();

            Console.WriteLine("==============================");



            Department d = new Department();

            d.getdetails();

            d.showmenu();


            Console.WriteLine("Enter choice");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {

                case 1: //ADD
                    d.AddEvent += d.Department_AddEvent;
                    Console.WriteLine("Enter no of employess to be added in dlist(not>10)");
                    int n1 = int.Parse(Console.ReadLine());
                    if (n1 <= 10)
                    {
                        for (int i = 0; i < n1; i++) { d.Add(); }
                    }
                    else
                    {
                        throw new Exception("no of employees in dept should not exceed 10");
                    }
                    break;

                case 2: // UPDATE OR EDIT
                    d.AddEvent += d.Department_AddEvent;
                    Console.WriteLine("Enter no of employess to be added in dlist");
                    int n2 = int.Parse(Console.ReadLine());
                    if (n2 <= 10)
                    {
                        for (int i = 0; i < n2; i++) { d.Add(); }
                    }
                    else
                    {
                        throw new Exception("no of employees in dept should not exceed 10");
                    }
                    printlist(d);
                    d.UpdateElist += Editlist;
                    d.Edit();
                    break;
                case 3: // REMOVE
                    d.AddEvent += d.Department_AddEvent;
                    Console.WriteLine("Enter no of employess to be added in dlist");
                    int n3 = int.Parse(Console.ReadLine());
                    if (n3 <= 10)
                    {
                        for (int i = 0; i < n3; i++) { d.Add(); }
                    }
                    else
                    {
                        throw new Exception("no of employees in dept should not exceed 10");
                    }
                    printlist(d);
                    d.UpdateElist += Remove;
                    d.RemoveEmp();
                    break;
            }

            //Delegates - empdetails | Mgr report status true list

            Empshowdetails(d);

            MgrReporting(d);

            //General print list
            printlist(d);

            Console.ReadLine();


        } //main() end


        private static void MgrReporting(Department d)
        {
            Console.WriteLine("Manager report: true status list");

            List<Employee> mgrlist = d.Elist.FindAll(x => x.Manager == true);


            Action<List<Employee>> mrep = mlist =>
            {
                foreach (var item in mgrlist)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine($"Name    : {item.EmployeeName}");
                    Console.WriteLine($"EmpID   : {item.EmployeeId}");
                    Console.WriteLine($"DeptNo  : {item.DepartmantNO}");
                    Console.WriteLine($"Salary  : {item.Salary}");
                    Console.WriteLine($"Manager status : {item.Manager}");
                    Console.WriteLine("-------------------------------------");
                }
            };

            mrep(mgrlist);
            Console.WriteLine("=====================================================");

        }
        private static void Empshowdetails(Department d)
        {
            Console.WriteLine("Employee and dept details using delegates - action");

            Action<Department> deptdetails = dep =>
            {
                Console.WriteLine($"Department ID : {dep.DeprtmentID}");
                Console.WriteLine($"Department Name : {dep.DepartmentName}");
                Console.WriteLine($"Department Location: {dep.Location}");
            };

            deptdetails(d);


            Action<Department> empshow = obj =>
            {
                Console.WriteLine($"Department ID   : {obj.DeprtmentID}");
                Console.WriteLine($"Department Name : {obj.DepartmentName}");
                Console.WriteLine($"Department Location: {obj.Location}");

                foreach (var item in obj.Elist)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine($"Name    : {item.EmployeeName}");
                    Console.WriteLine($"EmpID   : {item.EmployeeId}");
                    Console.WriteLine($"DeptNo  : {item.DepartmantNO}");
                    Console.WriteLine($"Salary  : {item.Salary}");
                    Console.WriteLine($"Manager status : {item.Manager}");
                    Console.WriteLine("-------------------------------------");
                }

            };
            empshow(d);

        }

        private static void Authenticate()
        {
            Func<string, string, bool> auth = (Userid, password) =>
            {
                if (Userid != string.Empty && password != string.Empty &&
                   Userid == "Durgesh" && password == "Hello@123")
                {
                    return true;
                }
                else
                {

                    Console.WriteLine("Retry userid/password");

                    return false;

                }

            };
            Console.WriteLine("Enter userID");
            string _userid = Console.ReadLine();

            Console.WriteLine("Enter Password");
            string _password = Console.ReadLine();

            if (auth(_userid, _password))
            {


                Console.WriteLine("Logged in Successfully");

            }
            else
            {
                Environment.Exit(2);
            }
        }

        private static void printlist(Department d)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------Printing List-----------");
            foreach (var item in d.Elist)
            {
                Console.WriteLine(item.EmployeeId);
                Console.WriteLine(item.EmployeeName);
                Console.WriteLine(item.DepartmantNO);
                Console.WriteLine(item.Salary);
                Console.WriteLine(item.Manager);
                Console.WriteLine("----------------------");
            }
        }

        public static void Editlist(int id, Department dd)
        {
            Employee e = dd.Elist.Find(x => x.EmployeeId == id);


            Console.WriteLine("Edit Employee Id");
            e.EmployeeId = int.Parse(Console.ReadLine());

            Console.WriteLine("Edit Employee Name");
            e.EmployeeName = Console.ReadLine();

            Console.WriteLine("Edit Employee dept no");
            e.DepartmantNO = int.Parse(Console.ReadLine());


            Console.WriteLine("Edit Employee salary");
            e.Salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Edit manager reporting status");
            e.Manager = bool.Parse(Console.ReadLine());

        }



        public static void Remove(int id, Department dd)
        {
            Employee rem = dd.Elist.Find(x => x.EmployeeId == id);

            dd.Elist.Remove(rem);

            Console.WriteLine("Removed successfully");


        }
    }
}