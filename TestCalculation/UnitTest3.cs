using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace TestCalculation
{
    [TestClass]
    public class UnitTest3
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @".\Data\TestData2.csv", "TestData2#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource2()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            string o = TestContext.DataRow[2].ToString();
            o = o.Remove(0, 1);
            int expected = int.Parse(TestContext.DataRow[3].ToString());
            
            Calculation c = new Calculation(a, b);
            int actual = c.Excecute(o);
            Assert.AreEqual(expected, actual);
        }

    }
}
