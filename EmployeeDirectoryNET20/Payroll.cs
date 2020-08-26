using System;
using System.Collections.Generic;

namespace EmployeeDirectoryNET20
{
    internal class Payroll
    {
        private List<Employee> payroll;

        public Payroll()
        {
            payroll = new List<Employee>();
        }

        internal Employee[] GetEmployees()
        {
            return payroll.ToArray();
        }

        internal void AddEmployee(string name, int salary)
        {
            payroll.Add(new Employee(name, salary));
        }
    }
}