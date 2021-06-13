using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator_MSTests_
{
    [TestClass]
    public class MSTest_isPositive
    {
        private CSharpCalculator.Calculator testCalculator;

        [TestInitialize]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void IsPositiveMSTestIntNegativeValue()
        {
            int argument = -10;
            bool expectedResult = false;
            bool actualResult = testCalculator.isPositive(argument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IsPositiveMSTestInt()
        {
            int argument = 50;
            bool expectedResult = true;
            bool actualResult = testCalculator.isPositive(argument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IsPositiveMSTestDouble()
        {
            double argument = 50.2;
            bool expectedResult = true;
            bool actualResult = testCalculator.isPositive(argument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IsPositiveMSTestZero()
        {
            int argument = 0;
            bool expectedResult = false;
            bool actualResult = testCalculator.isPositive(argument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IsPositiveMSTestString()
        {
            string argument = "50".ToString();
            bool expectedResult = true;
            bool actualResult = testCalculator.isPositive(argument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void IsPositiveMSTestException()
        {
            string input = "test";
            bool actualResult = testCalculator.isPositive(input);
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
