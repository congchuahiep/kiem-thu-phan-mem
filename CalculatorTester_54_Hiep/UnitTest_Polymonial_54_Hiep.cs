using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorForm;

namespace CalculatorTester_54_Hiep
{
	[TestClass]
	public class UnitTest_Polymonial_54_Hiep
	{
        Polymonial_54_Hiep p_54_Hiep;

        public UnitTest_Polymonial_54_Hiep()
		{
			int[] a = { 2, 3, 4, 5 };
            List<int> a_54_Hiep = new List<int>(a);

            p_54_Hiep = new Polymonial_54_Hiep(3, a_54_Hiep);
        }

		[TestMethod] // TC9: n = 2, a = { 2, 3, 4, 5 }, x = 2, kq = 64
        public void TC9_Test_Da_Thuc_Don_Gian_54_Hiep()
		{
			double actual_54_Hiep = p_54_Hiep.Calculate_54_Hiep(2);
            double expected_54_Hiep = 64;

            Assert.AreEqual(expected_54_Hiep, actual_54_Hiep);
        }

        [TestMethod] // TC10: n = 2, a = { 2, 3, 4, 5 }, x = -3, kq = -106
        public void TC10_Test_Da_Thuc_So_Am_54_Hiep()
        {
            double actual_54_Hiep = p_54_Hiep.Calculate_54_Hiep(-3);
            double expected_54_Hiep = -106;

            Assert.AreEqual(expected_54_Hiep, actual_54_Hiep);
        }

        [TestMethod] // TC11: n = 2, a = { 2, 3, 4, 5 }, x = 0, kq = 5
        public void TC11_Test_Da_Thuc_X_Bang_0_54_Hiep()
        {
            double actual_54_Hiep = p_54_Hiep.Calculate_54_Hiep(0);
            double expected_54_Hiep = 2;

            Assert.AreEqual(expected_54_Hiep, actual_54_Hiep);
        }

        [TestMethod] // TC12: n = 2, a = { 2, 3, 4, 5 }, x = 1, kq = 14
        public void TC12_Test_Da_Thuc_X_Bang_1_54_Hiep()
        {
            double actual_54_Hiep = p_54_Hiep.Calculate_54_Hiep(1);
            double expected_54_Hiep = 14;

            Assert.AreEqual(expected_54_Hiep, actual_54_Hiep);
        }

        
        [TestMethod] // TC13: n = 2, a = {} , kq = ExceptionArgumentException
        [ExpectedException(typeof(ArgumentException))]
        public void TC13_Test_Da_Thuc_Rong_54_Hiep()
        {
            int[] a = {};
            List<int> a_54_Hiep = new List<int>(a);
            new Polymonial_54_Hiep(2, a_54_Hiep);
        }

        [TestMethod] // TC14: n = 10, a = { 2, 3, 4 }, kq = ExceptionArgumentException
        [ExpectedException(typeof(ArgumentException))]
        public void TC14_Test_Da_Thuc_Khong_Dung_54_Hiep()
        {
            int[] a = { 2, 3, 4 };
            List<int> a_54_Hiep = new List<int>(a);
            new Polymonial_54_Hiep(10, a_54_Hiep);
        }
    }
}
