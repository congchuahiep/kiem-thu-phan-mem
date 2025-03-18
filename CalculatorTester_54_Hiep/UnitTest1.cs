using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TH1_54_Hiep;

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
    }
}
