using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("EmployeeDirectory.Tests")]
namespace EmployeeDirectoryNET20
{
    internal class Payroll
    {
        //Private collection of employee objects
        //Only accessable from inside this class
        private List<Employee> payroll;

        //Construktor runs when a payroll is created ( new Payroll() )
        public Payroll()
        {
            //Initializes a new List
            payroll = new List<Employee>();
        }

        internal Employee[] GetEmployees()
        {
            //Returns a copy of emplyee list
            return payroll.ToArray();
        }

        internal void AddEmployee(string name, int salary)
        {
            //New instance of employee
            //Add emplyee to list
            payroll.Add(new Employee(name, salary));
        }
    }
}