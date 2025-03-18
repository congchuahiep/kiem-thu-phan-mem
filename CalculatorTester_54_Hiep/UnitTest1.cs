using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorForm;

namespace CalculatorTester_54_Hiep
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation_54_Hiep c;

        [TestInitialize]
        public void SetUp_54_Hiep()
        {
            c = new Calculation_54_Hiep(21, 7);
        }

        public TestContext TestContext { get; set; }

        [TestMethod] // TC1: a = 21, b = 7, kq = 28
        public void TC1_Test_Cong_54_Hiep()
        {
            int expected, actual;
            expected = 28;
            actual = c.Execute("+");

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod] // TC2: a = 21, b = 7, kq = 14
        public void TC2_Test_Tru_54_Hiep()
        {
            int expected, actual;
            expected = 14;
            actual = c.Execute("-");

            Assert.AreEqual(expected, actual);
        }     
        
        [TestMethod] // TC3: a = 21, b = 7, kq = 147
        public void TC3_Test_Nhan_54_Hiep()
        {
            int expected, actual;
            expected = 147;
            actual = c.Execute("*");

            Assert.AreEqual(expected, actual);
        }     
        
        [TestMethod] // TC4: a = 21, b = 7, kq = 3
        public void TC4_Test_Chia_54_Hiep()
        {
            int expected, actual;
            expected = 3;
            actual = c.Execute("/");

            Assert.AreEqual(expected, actual);
        }     
        
        [TestMethod] // TC5: a = 5, b = 0, kq = ExceptionDivideByZeroException
        [ExpectedException(typeof(DivideByZeroException))]
        public void TC5_Test_Chia_Zero_54_Hiep()
        {
            c = new Calculation_54_Hiep(5, 0);
            c.Execute("/");
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod] // TC6:
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());

            Calculation_54_Hiep c = new Calculation_54_Hiep(a, b);
            int actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }
    }
}
