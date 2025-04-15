using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorForm;

namespace CalculatorTester_54_Hiep
{

	[TestClass]
	public class UnitTest_Radix_54_Hiep
	{
        [TestMethod] // TC15: number = 10, radix = 2, expected = "1010"
        public void TC15_Chuyen_Doi_Thap_Phan_Sang_Nhi_Phan_54_Hiep()
        {
            Radix_54_Hiep r_54_Hiep = new Radix_54_Hiep(10);
            string actual_54_Hiep = r_54_Hiep.ConvertDecimalToAnother_54_Hiep(2);
            string expected_54_Hiep = "1010";

            Assert.AreEqual(expected_54_Hiep, actual_54_Hiep);
        }

        [TestMethod] // TC16: number = 255, radix = 16, expected = "FF"
        public void TC16_Chuyen_Doi_Thap_Phan_Sang_Thap_Luc_Phan_54_Hiep()
        {
            Radix_54_Hiep r_54_Hiep = new Radix_54_Hiep(255);
            string actual_54_Hiep = r_54_Hiep.ConvertDecimalToAnother_54_Hiep(16);
            string expected_54_Hiep = "FF";

            Assert.AreEqual(expected_54_Hiep, actual_54_Hiep);
        }

        [TestMethod] // TC17: number = 100, radix = 8, expected = "144"
        public void TC17_Chuyen_Doi_Thap_Phan_Sang_Bat_Phan_54_Hiep()
        {
            Radix_54_Hiep r_54_Hiep = new Radix_54_Hiep(100);
            string actual_54_Hiep = r_54_Hiep.ConvertDecimalToAnother_54_Hiep(8);
            string expected_54_Hiep = "144";

            Assert.AreEqual(expected_54_Hiep, actual_54_Hiep);
        }

        [TestMethod] // TC18: number = 0, radix = 2, expected = "0"
        public void TC18_Chuyen_Doi_So_0_54_Hiep()
        {
            Radix_54_Hiep r_54_Hiep = new Radix_54_Hiep(0);
            string actual_54_Hiep = r_54_Hiep.ConvertDecimalToAnother_54_Hiep(2);
            string expected_54_Hiep = "";

            Assert.AreEqual(expected_54_Hiep, actual_54_Hiep);
        }

        [TestMethod] // TC19: number = 10, radix = 1, expected = ExceptionArgumentException
        [ExpectedException(typeof(ArgumentException))]
        public void TC19_Radix_Nho_Hon_2_54_Hiep()
        {
            Radix_54_Hiep r_54_Hiep = new Radix_54_Hiep(10);
            r_54_Hiep.ConvertDecimalToAnother_54_Hiep(1);
        }

        [TestMethod] // TC20: number = 10, radix = 17, expected = ExceptionArgumentException
        [ExpectedException(typeof(ArgumentException))]
        public void TC20_Radix_Lon_Hon_16_54_Hiep()
        {
            Radix_54_Hiep r_54_Hiep = new Radix_54_Hiep(10);
            r_54_Hiep.ConvertDecimalToAnother_54_Hiep(17);
        }

        [TestMethod] // TC21: number = -5, expected = ExceptionArgumentException
        [ExpectedException(typeof(ArgumentException))]
        public void TC21_So_Am_Khong_Hop_Le_54_Hiep()
        {
            Radix_54_Hiep r_54_Hiep = new Radix_54_Hiep(-5);
        }
    }
}
