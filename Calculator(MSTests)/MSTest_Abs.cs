using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator_MSTests_
{
    [TestClass]
    public class MSTest_Abs
    {
        private CSharpCalculator.Calculator testCalculator;

        [TestInitialize]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void AbsMSTestInt()
        {
            int argument = -5;
            int expected = 5;
            double result = testCalculator.Abs(argument);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AbsMSTestStringInt()
        {
            string argument2 = "-6";
            string expectedResult = "6";
            double actualResult = testCalculator.Abs(argument2);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult);
        }

        [TestMethod] //Bug: Doesn't work with Double values
        public void AbsMSTestDouble()
        {
            double argument = -5.2;
            double expected = 5.2;
            double result = testCalculator.Abs(argument);
            Assert.AreEqual(expected, result);

        }

        [TestMethod] //Bug: Doesn't work with Double values  in String
        public void AbsMSTestString()
        {
            string argument2 = "-6.2";
            string expectedResult = "6.2";
            double actualResult = testCalculator.Abs(argument2);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void AbsMethodException()
        {
            string input = "test";
            double actualResult = testCalculator.Abs(input);
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
