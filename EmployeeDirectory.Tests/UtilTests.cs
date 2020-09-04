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

        [TestInitialize]
        public void Init()
        {
             ui = new Mock<IUI>();
             Util.SetUp(ui.Object);
        }


        [TestMethod]
        public void AskForString_ReturnsString()
        {

        }
    }
}
