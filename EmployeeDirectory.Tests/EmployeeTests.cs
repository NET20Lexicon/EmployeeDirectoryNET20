using EmployeeDirectoryNET20;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeDirectory.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void Employee_Get_ShouldReturnsSalaryLevelJunior()
        {
            const int salary = 10000;
            var employee = new Employee("Kalle", salary);

            var actual = employee.SalaryLevel;

            Assert.AreEqual(SalaryLevel.Junior, actual);
        }
    }
}
