using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace TestCalculation
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation cal;
        [TestInitialize]

        public void SetUp()
        {
            this.cal = new Calculation(10, 5);
        }

        [TestMethod]
        public void TestAddOperator()
        {
            Assert.AreEqual(cal.Excecute("+"), 15);
        }

        [TestMethod]
        public void TestSubOperator()
        {
            Assert.AreEqual(cal.Excecute("-"), 5);
        }

        [TestMethod]
        public void TestMulOperator()
        {
            Assert.AreEqual(cal.Excecute("*"), 50);
        }

        [TestMethod]
        public void TestDivOperator()
        {
            Assert.AreEqual(cal.Excecute("/"), 2);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Calculation c = new Calculation(2, 0);
            c.Excecute("/");
        }

    }
}
