using EmployeeDirectoryNET20;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDirectory.Tests
{
   [TestClass]
    public class PayrollTests
    {
        [TestMethod]
        public void GetEmplyees_ShouldReturnInstance()
        {
            var payroll = new Payroll();

            var actual = payroll.GetEmployees();

            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void AddEmployee_Should_Add()
        {
            var payroll = new Payroll();
            var expectedName = "Kalle";
            var expectedSalary = 10000;

            payroll.AddEmployee(expectedName, expectedSalary);
            var actual = payroll.GetEmployees()[0];

            Assert.AreEqual(expectedName, actual.Name);
            Assert.AreEqual(expectedSalary, actual.Salary);
        }
    }
}
