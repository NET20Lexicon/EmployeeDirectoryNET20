using Microsoft.VisualBasic.CompilerServices;
using System;

namespace EmployeeDirectoryNET20
{
    class Program
    {
        //Create a new instance of payroll
        static Payroll payroll = new Payroll();
        private static IUI ui;
        //private static Util util = new Util(ui);

        static void Main(string[] args)
        {
            //Calls Add method on payroll instance
            //Only for demo purpose to have some data
            var startUp = new StrartUp();
            ui = startUp.GetUI();

            SeedData();

            do //Loop
            {
                PrintMeny();

            } while (true);
        }

        private static void PrintMeny()
        {
            ui.Print("1. Add new Employee");
            ui.Print("2. Print");
            ui.Print("Q. Quit");

            switch (Console.ReadLine())
            {
                case "1":
                    Add();
                    break;
                case "2":
                    Print();
                    break;
                case "Q":
                    //Exit application
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        private static void Print()
        {
            //Get a copy of the payroll
            Employee[] employees = payroll.GetEmployees();

            //Loop on all employees in payroll
            foreach (Employee employee in employees)
            {
                //Console.Writeline() method does a .ToString() on the Employee instance
                ui.Print(employee.ToString());

                //Ternary conditional operator
                //Same as if else
                ui.Print(employee.SalaryLevel.Equals(SalaryLevel.Junior) ? 
                    DoJuniorWork() : 
                    DoSeniorWork());
            }
        }

        private static string DoSeniorWork()
        {
            return "Do senior work";
        }

        private static string DoJuniorWork()
        {
            return "Do junior work";
        }

        private static void Add()
        {
            ui.Print("Add a new Employee, Quit with Q");

            do
            {
                string name = Util.AskForString("Name: ", ui);
                if (name == "Q") break; //Break exits the loop
                int salary = Util.AskForInt("Salary: ", ui);
                payroll.AddEmployee(name, salary);

            } while (true); //Endleess loop
        }

        private static void SeedData()
        {
            payroll.AddEmployee("Kalle",10000);
            payroll.AddEmployee("Nisse",30000);
            payroll.AddEmployee("Lisa",23000);
            payroll.AddEmployee("Anne",50000);
        }
    }
}
