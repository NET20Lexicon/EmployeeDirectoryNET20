using System;

namespace EmployeeDirectoryNET20
{
    public class Employee
    {
        
        public string Name { get; }
        public int Salary { get; }
        public SalaryLevel SalaryLevel 
        {
            get
            {
                if(Salary < 15000)
                {
                    return SalaryLevel.Junior;
                }
                else
                {
                    return SalaryLevel.Senior;
                }
            } 
        }


        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary}";
        }

    }
}