using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator_MSTests_
{
    [TestClass]
    public class MSTest_Divide
    {
        private CSharpCalculator.Calculator testCalculator;

        [TestInitialize]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void DivideMSTestInt()
        {
            double num1 = 30;
            double num2 = 5;
            double expectedResult = 6;
            double actualResult = testCalculator.Divide(num1, num2);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void DivideMSTestDouble()
        {
            double num1 = 50.5;
            double num2 = 10.1;
            double expectedResult = 5;
            double actualResult = testCalculator.Divide(num1, num2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DivideMSTestString()
        {
            string num1 = "50";
            string num2 = "10";
            double expectedResult = 5;
            double actualResult = testCalculator.Divide(Convert.ToDouble(num1), Convert.ToDouble(num2));
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //Bug: Divides by 0
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideMSTestException()
        {
            double num1 = 2.5;
            double num2 = 0;
            double actualResult = testCalculator.Divide(num1, num2);
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
