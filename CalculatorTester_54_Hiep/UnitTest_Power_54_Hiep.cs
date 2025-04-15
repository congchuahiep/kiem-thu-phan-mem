using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorForm;

namespace CalculatorTester_54_Hiep
{
	/// <summary>
	/// Summary description for UnitTest_Power_54_Hiep
	/// </summary>
	[TestClass]
	public class UnitTest_Power_54_Hiep
	{
		public UnitTest_Power_54_Hiep()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		//
		// You can use the following additional attributes as you write your tests:
		//
		// Use ClassInitialize to run code before running the first test in the class
		// [ClassInitialize()]
		// public static void MyClassInitialize(TestContext testContext) { }
		//
		// Use ClassCleanup to run code after all tests in a class have run
		// [ClassCleanup()]
		// public static void MyClassCleanup() { }
		//
		// Use TestInitialize to run code before running each test 
		// [TestInitialize()]
		// public void MyTestInitialize() { }
		//
		// Use TestCleanup to run code after each test has run
		// [TestCleanup()]
		// public void MyTestCleanup() { }
		//
		#endregion

		[TestMethod] // TC8: a = 5, b = 3, kq = 125
		public void TC8_Test_So_Mu_Hop_Le_54_Hiep()
		{
			double actual_54_Hiep = Math_54_Hiep.Power_54_Hiep(5, 3);
			double expected_54_Hiep = 125;

			Assert.AreEqual(expected_54_Hiep, actual_54_Hiep);
		}

        [TestMethod] // TC9: a = 5, b = -3, kq = 0.008
        public void TC9_Test_So_Mu_Am_54_Hiep()
        {
            double actual_54_Hiep = Math_54_Hiep.Power_54_Hiep(5, -3);
            double expected_54_Hiep = 0.008;
            Assert.AreEqual(expected_54_Hiep, actual_54_Hiep);
        }
    }
}
