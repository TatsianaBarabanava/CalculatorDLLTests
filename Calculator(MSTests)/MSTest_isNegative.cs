using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator_MSTests_
{
    [TestClass]
    public class MSTest_isNegative
    {
        private CSharpCalculator.Calculator testCalculator;

        [TestInitialize]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void IsNegativeMSTestIntPositiveValue()
        {
            int argument = 10;
            bool expectedResult = false;
            bool actualResult = testCalculator.isNegative(argument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IsNegativeMSTestInt()
        {
            int argument = -30;
            bool expectedResult = true;
            bool actualResult = testCalculator.isNegative(argument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //Bug: 0 has no +/- sign
        public void IsNegativeMSTestZero()
        {
            int argument = 0;
            bool expectedResult = false;
            bool actualResult = testCalculator.isNegative(argument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IsNegativeMSTestDouble()
        {
            double argument = -50.2;
            bool expectedResult = true;
            bool actualResult = testCalculator.isNegative(argument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IsNegativeMSTestString()
        {
            string argument = "-50.2";
            bool expectedResult = true;
            bool actualResult = testCalculator.isNegative(argument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void IsNegativeMSTestException()
        {
            string input = "test";
            bool actualResult = testCalculator.isNegative(input);
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
