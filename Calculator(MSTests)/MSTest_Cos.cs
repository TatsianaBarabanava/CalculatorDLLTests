using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator_MSTests_
{
    [TestClass]
    public class MSTest_Cos
    {
        private CSharpCalculator.Calculator testCalculator;

        [TestInitialize]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }
        [TestMethod]
        public void CosMSTestDouble()
        {
            double argument = 6.372;
            double expectedResult = 1;
            double actualResult = testCalculator.Cos(argument);
            Assert.AreEqual(expectedResult, actualResult, 0.1);
        }

        [TestMethod]
        public void CosMSTestNegativeValue()
        {
            double argument = -6.372;
            double expectedResult = 1;
            double actualResult = testCalculator.Cos(argument);
            Assert.AreEqual(expectedResult, actualResult, 0.1);
        }

        [TestMethod]
        public void CosMSTestZeroValue()
        {
            double argument = 0;
            double expectedResult = 1;
            double actualResult = testCalculator.Cos(argument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CosMSTestInt()
        {
            int argument = 250;
            double expectedResult = 0.24;
            double actualResult = testCalculator.Cos(argument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [TestMethod]
        public void CosMSTestString()
        {
            string argument = "250";
            string expectedResult = "0.240988305285259";
            double actualResult = testCalculator.Cos(argument);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void CosMSTestException()
        {
            string input = "test";
            double actualResult = testCalculator.Cos(input);
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
