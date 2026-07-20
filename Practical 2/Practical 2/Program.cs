using System;

namespace Practical_2
{
    class Employee
    {
        public int employeeId;
        public string employeeName;
        public double basicSalary;

        public void AcceptDetails()
        {
            Console.Write("Enter Employee ID: ");
            employeeId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            employeeName = Console.ReadLine();

            Console.Write("Enter Basic Salary: ");
            basicSalary = Convert.ToDouble(Console.ReadLine());
        }
    }

    class FullTimeEmployee : Employee
    {
        double hra, da, grossSalary;

        public void CalculateSalary()
        {
            hra = basicSalary * 0.20;
            da = basicSalary * 0.10;
            grossSalary = basicSalary + hra + da;
        }

        public void DisplayDetails()
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

        public void CalculateSalary()
        {
            grossSalary = basicSalary;
        }

        public void DisplayDetails()
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
        static void FullTime()
        {
            FullTimeEmployee emp = new FullTimeEmployee();

            emp.AcceptDetails();
            emp.CalculateSalary();
            emp.DisplayDetails();
        }

        static void HalfTime()
        {
            HalfTimeEmployee emp = new HalfTimeEmployee();

            emp.AcceptDetails();
            emp.CalculateSalary();
            emp.DisplayDetails();
        }

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

                switch (choice)
                {
                    case 1:
                        FullTime();
                        break;

                    case 2:
                        HalfTime();
                        break;

                    case 3:
                        Console.WriteLine("Thank You!");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (choice != 3);
        }
    }
}
