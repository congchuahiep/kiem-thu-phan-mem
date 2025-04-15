using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorForm;

namespace CalculatorTester_54_Hiep
{
    [TestClass]
    public class UnitTest_54_Hiep
    {
        private Calculation_54_Hiep c;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void SetUp_54_Hiep()
        {
            c = new Calculation_54_Hiep(21, 7);
        }

        [TestMethod] // TC1: a = 21, b = 7, kq = 28
        public void TC1_Test_Cong_54_Hiep()
        {
            int expected;
            int actual;
            expected = 28;
            actual = c.Execute("+");

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod] // TC2: a = 21, b = 7, kq = 14
        public void TC2_Test_Tru_54_Hiep()
        {
            int expected;
            int actual;
            expected = 14;
            actual = c.Execute("-");

            Assert.AreEqual(expected, actual);
        }     
        
        [TestMethod] // TC3: a = 21, b = 7, kq = 147
        public void TC3_Test_Nhan_54_Hiep()
        {
            int expected;
            int actual;
            expected = 147;
            actual = c.Execute("*");

            Assert.AreEqual(expected, actual);
        }     
        
        [TestMethod] // TC4: a = 21, b = 7, kq = 3
        public void TC4_Test_Chia_54_Hiep()
        {
            int expected;
            int actual;
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

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data_54_Hiep\TestData_54_Hiep.csv",
            "TestData_54_Hiep#csv",
            DataAccessMethod.Sequential
        )]
        [TestMethod]
        // TC6:
        // a = 2, b = 3, kq = 5
        // a = -1, b = 1, kq = 0
        // a = 0, b = 0, kq = 0
        // a = 1, b = 1, kq = 2
        // a = 51, b = 49, kq = 100
        // a = -17, b = -3, kq = -20
        // a = -12, b = 14, kq = 2
        public void TC6_Test_Voi_Csv_Data_54_Hiep()
        {
            int a_54_Hiep = int.Parse(TestContext.DataRow[0].ToString());
            int b_54_Hiep = int.Parse(TestContext.DataRow[1].ToString());
            int expected_54_Hiep = int.Parse(TestContext.DataRow[2].ToString());

            Calculation_54_Hiep c_54_Hiep = new Calculation_54_Hiep(a_54_Hiep, b_54_Hiep);
            int actual_54_Hiep = c_54_Hiep.Execute("+");
            Assert.AreEqual(expected_54_Hiep, actual_54_Hiep);
        }

[DataSource(
    "Microsoft.VisualStudio.TestTools.DataSource.CSV",
    @".\Data_54_Hiep\TestData_WithOperater_54_Hiep.csv",
    "TestData_WithOperater_54_Hiep#csv",
    DataAccessMethod.Sequential
)]
[TestMethod]
// TC7:
// a = 12, b = 3, calSymbol = '+', expected = 15
// a = 12, b = 3, calSymbol = '-', expected = 9
// a = 12, b = 3, calSymbol = '*', expected = 36
// a = 12, b = 3, calSymbol = '/', expected = 4
// a = 8, b = 8, calSymbol = '+', expected = 16
// a = 8, b = 8, calSymbol = '-', expected = 0
// a = 8, b = 8, calSymbol = '*', expected = 64
// a = 8, b = 8, calSymbol = '/', expected = 1
public void TC7_Test_Voi_Csv_Data_Co_Toan_Tu_54_Hiep()
{
    int a_54_Hiep = int.Parse(TestContext.DataRow[0].ToString());
    int b_54_Hiep = int.Parse(TestContext.DataRow[1].ToString());
    string calSymbol_54_Hiep = TestContext.DataRow[2].ToString();
    int expected_54_Hiep = int.Parse(TestContext.DataRow[3].ToString());

    Calculation_54_Hiep c_54_Hiep = new Calculation_54_Hiep(a_54_Hiep, b_54_Hiep);
    int actual_54_Hiep = c_54_Hiep.Execute(calSymbol_54_Hiep);
    Assert.AreEqual(expected_54_Hiep, actual_54_Hiep);
}


    }
}
