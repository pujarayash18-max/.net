using System;

namespace Practical3
{
    class Expense
    {
        public int ExpenseId;
        public string Category;
        public double Amount;
        public string PaymentMode;
        public DateTime Date;

        public Expense()
        {
            Date = DateTime.Now;
        }

        public void Add()
        {
            Console.Write("Enter Expense ID: ");
            ExpenseId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Category: ");
            Category = Console.ReadLine();

            Console.Write("Enter Amount: ");
            Amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Payment Mode: ");
            PaymentMode = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("\nExpense ID      : " + ExpenseId);
            Console.WriteLine("Category        : " + Category);
            Console.WriteLine("Amount          : " + Amount);
            Console.WriteLine("Payment Mode    : " + PaymentMode);
            Console.WriteLine("Expense Date    : " + Date);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Expense[] exp = new Expense[20];
            int count = 0;
            int choice;

            do
            {
                Console.WriteLine("\n====== MENU ======");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View Expenses");
                Console.WriteLine("3. Total Expense");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            exp[count] = new Expense();
                            exp[count].Add();
                            count++;
                            Console.WriteLine("Expense Added.");
                            break;

                        case 2:
                            if (count == 0)
                            {
                                Console.WriteLine("No Expenses Found.");
                            }
                            else
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    exp[i].Display();
                                }
                            }
                            break;

                        case 3:
                            double total = 0;

                            for (int i = 0; i < count; i++)
                            {
                                total += exp[i].Amount;
                            }

                            Console.WriteLine("Total Expense = " + total);
                            break;

                        case 4:
                            Console.WriteLine("Program Closed.");
                            break;

                        default:
                            Console.WriteLine("Invalid Choice.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input! Please enter correct values.");
                    choice = 0;
                }

            } while (choice != 4);
        }
    }
}