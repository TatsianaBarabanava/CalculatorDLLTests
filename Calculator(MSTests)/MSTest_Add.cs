using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator_MSTests_
{
    [TestClass]
    public class MSTest_Add
    {
        private CSharpCalculator.Calculator testCalculator;

        [TestInitialize]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestMethod] // Bug: Doesn't work with int values
        public void AddMSTestInt()
        {
            int num1 = 15;
            int num2 = 7;
            int expectedResult = 22;
            double actualResult = testCalculator.Add(num1, num2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AddMSTestDouble()
        {
            double num1 = 15.2;
            double num2 = -7;
            double expectedResult = 8.2;
            double actualResult = testCalculator.Add(num1, num2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //Bug: Doesn't work with String values
        public void AddMSTestString()
        {
            string num1 = "15";
            string num2 = "7";
            string expectedResult = "22";
            double actualResult = testCalculator.Add(num1, num2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //Bug: Throws the wrong exception
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void AddMSTestException()
        {
            string num1 = "test";
            string num2 = "test";
            double actualResult = testCalculator.Add(num1, num2);
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
