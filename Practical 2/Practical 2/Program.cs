using System;

namespace Practical_2
{
    class Employee
    {
        public int employeeId;
        public string employeeName;
        public double basicSalary;

        public virtual void AcceptDetails()
        {
            Console.Write("Enter Employee ID: ");
            employeeId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            employeeName = Console.ReadLine();

            Console.Write("Enter Basic Salary: ");
            basicSalary = Convert.ToDouble(Console.ReadLine());
        }

        public virtual void CalculateSalary()
        {
        }

        public virtual void DisplayDetails()
        {
        }
    }

    class FullTimeEmployee : Employee
    {
        double hra, da, grossSalary;

        public override void CalculateSalary()
        {
            hra = basicSalary * 0.20;
            da = basicSalary * 0.10;
            grossSalary = basicSalary + hra + da;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("\n===== Full-Time Employee =====");
            Console.WriteLine("Employee ID   : " + employeeId);
            Console.WriteLine("Employee Name : " + employeeName);
            Console.WriteLine("Employee Type : Full-Time");
            Console.WriteLine("Basic Salary  : " + basicSalary);
            Console.WriteLine("HRA           : " + hra);
            Console.WriteLine("DA            : " + da);
            Console.WriteLine("Gross Salary  : " + grossSalary);
        }
    }

    class HalfTimeEmployee : Employee
    {
        double grossSalary;

        public override void CalculateSalary()
        {
            grossSalary = basicSalary;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("\n===== Half-Time Employee =====");
            Console.WriteLine("Employee ID   : " + employeeId);
            Console.WriteLine("Employee Name : " + employeeName);
            Console.WriteLine("Employee Type : Half-Time");
            Console.WriteLine("Basic Salary  : " + basicSalary);
            Console.WriteLine("Gross Salary  : " + grossSalary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== Employee Payroll Menu =====");
                Console.WriteLine("1. Full-Time Employee");
                Console.WriteLine("2. Half-Time Employee");
                Console.WriteLine("3. Exit");
                Console.Write("Enter Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                Employee emp = null;

                switch (choice)
                {
                    case 1:
                        emp = new FullTimeEmployee();
                        break;

                    case 2:
                        emp = new HalfTimeEmployee();
                        break;

                    case 3:
                        Console.WriteLine("Thank You!");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

                if (emp != null)
                {
                    emp.AcceptDetails();
                    emp.CalculateSalary();
                    emp.DisplayDetails();
                }

            } while (choice != 3);
        }
    }
}
