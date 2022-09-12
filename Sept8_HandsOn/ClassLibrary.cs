using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public delegate void Action_edit_update_del(int empid, Department dd);

    public delegate void Action_add();
    public class Department
    {
        public event Action_edit_update_del UpdateElist;

        public event Action_add AddEvent;
        private int _deptid;

        public int DeprtmentID
        {
            get { return _deptid; }
            set { _deptid = value; }
        }

        private string _deptname;

        public string DepartmentName
        {
            get { return _deptname; }
            set { _deptname = value; }
        }

        private string _location;

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        private List<Employee> _elist = new List<Employee>();

        public List<Employee> Elist
        {

            get { return _elist; }

            set
            {
                if (Elist.Count <= 10) _elist = value;

                else throw new Exception("Employee in a department should not exceed 10");

            }

        }

        public void getdetails()
        {
            Console.WriteLine("Enter Dept Id");
            this.DeprtmentID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Dept Name");
            this.DepartmentName = Console.ReadLine();

            Console.WriteLine("Enter Dept location");
            this.Location = Console.ReadLine();


        }

        public void showmenu()
        {
            Console.WriteLine("******************************************");

            Console.WriteLine("MENU \n1  - Add Employee from dept\n2 - Update Employee from dept\n3 - Delete Employee from dept");
            Console.WriteLine("******************************************");

        }
        //------------add----------------
        public void Add()
        {

            AddEvent();

        }

        public void Department_AddEvent()
        {
            Console.WriteLine("*********************************");
            Employee emp = new Employee();

            Console.WriteLine("Enter Employee Id");
            emp.EmployeeId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name");
            emp.EmployeeName = Console.ReadLine();

            Console.WriteLine("Enter Employee dept no");
            emp.DepartmantNO = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter Employee salary");
            emp.Salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter manager reporting status");
            emp.Manager = bool.Parse(Console.ReadLine());

            Elist.Add(emp);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Employee added successfully in list......");
            Console.ForegroundColor = ConsoleColor.White;
        }



        //------------------------------------

        //edit
        public void Edit()
        {

            Console.WriteLine("------EDIT OPERATION--------");
            Console.WriteLine("Enter Emplyee id to edit name ");
            int id = int.Parse(Console.ReadLine());

            UpdateElist(id, this);
        }
        //---------remove--------------------------------

        public void RemoveEmp()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------Remove OPERATION--------");
            Console.WriteLine("Enter Emplyee id to REMOVE ");
            int id = int.Parse(Console.ReadLine());

            UpdateElist(id, this);

        }

    }


    public class Employee
    {
        private int _empid;

        public int EmployeeId
        {
            get { return _empid; }
            set { _empid = value; }
        }

        private string _empName;

        public string EmployeeName
        {
            get { return _empName; }
            set { _empName = value; }
        }

        private int _deptno;

        public int DepartmantNO
        {
            get { return _deptno; }
            set { _deptno = value; }
        }

        private int _salary;

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        private bool _manager;

        public bool Manager
        {
            get { return _manager; }
            set { _manager = value; }
        }

    }
}