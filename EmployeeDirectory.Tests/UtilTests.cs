using EmployeeDirectoryNET20;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDirectory.Tests

{
    [TestClass]
    public class UtilTests
    {
        private Mock<IUI> ui;
       // private Util util;

        [TestInitialize]
        public void Init()
        {
             ui = new Mock<IUI>();
           //  util = new Util(ui.Object);
             //Util.SetUp(ui.Object);
        }


        [TestMethod]
        public void AskForString_ReturnsString()
        {
            const string expected = "Kalle";
            ui.Setup(u => u.GetInput()).Returns(expected);

            var actual = Util.AskForString("Name: ", ui.Object);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("5")]
        [DataRow("10")]
        [DataRow("15")]
        public void AskForInt_ReturnsExpected(string value)
        {
            ui.Setup(u => u.GetInput()).Returns(value);
            var actual = Util.AskForInt("Salary: ", ui.Object);

            Assert.AreEqual(int.Parse(value), actual);


        }
    }
}
