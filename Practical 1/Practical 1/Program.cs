using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_1
{
    public class Student
    {
        public int admissionId;
        public string name;
        public string course;
        public int sem;

        private int fees;
        private const double scholershipRate = 0.10;
        private bool isEligible;

        public Student()
        {
            Console.WriteLine("============================");
            Console.WriteLine("  Student Admission System  ");
            Console.WriteLine("============================");

            course = "Computer Engineering";
            sem = 5;
        }

        public void displayStudentDetails()
        {
            double Finalfees = fees;
            if (isEligible)
            {
                Finalfees = fees - (fees * scholershipRate);
            }

            Console.WriteLine("============================");
            Console.WriteLine("       Student Details      ");
            Console.WriteLine("============================");

            Console.WriteLine("Admission Id : " + admissionId);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Course : " + course);
            Console.WriteLine("Sem : " + sem);
            Console.WriteLine("Fees : " + fees);
            Console.WriteLine("Scholarship Eligible : " + isEligible);
            Console.WriteLine("Final Fees : " + Finalfees); ;
        }

        public void scholershipEligliblity()
        {
            if (fees <= 50000)
            {
                isEligible = true;
            }
            else
            {
                isEligible = false;
            }
        }

        public void studentdetails()
        {

            Console.Write("Enter an Admission Id : ");
            admissionId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a Name : ");
            name = Console.ReadLine();

            Console.Write("Enter a Course : ");
            course = Console.ReadLine();

            Console.Write("Enter a Sem : ");
            sem = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a Fees : ");
            fees = Convert.ToInt32(Console.ReadLine());
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            s1.studentdetails();
            s1.scholershipEligliblity();
            s1.displayStudentDetails();
        }
    }
}