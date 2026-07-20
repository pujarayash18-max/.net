using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            string dept, name;

            age = newAge(age);
            dept = "CE";
            name = "Yash Pujara";
            Console.WriteLine("My name is " + name + "\nI am from " + dept + " Department\nMy age is " + age);

        }

        private static int newAge(int age)
        {
            int newAge;
            newAge = age + 2;
            return newAge;
        }
    }

}