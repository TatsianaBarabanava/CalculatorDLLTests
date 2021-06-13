using NUnit.Framework;
using System;

namespace Calculator_NUnitTests_
{
    [TestFixture]
    public class NUnit_Sqrt
    {
        private CSharpCalculator.Calculator testCalculator;

        [SetUp]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestCase(4, 2)]
        [TestCase(0, 0)]
        public void SqrtNUnitTestInt(int num, int expectedResult)
        {
            double actualResult = testCalculator.Sqrt(num);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }


        [TestCase(2.7, 1.643)] //Bug:Calculates wrong value for Double
        [TestCase(0, 0)]
        [TestCase(5, 2.236)]
        public void SqrtNUnitTestDouble(double num, double expectedResult)
        {
            double actualResult = testCalculator.Sqrt(num);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [TestCase("2.7", "1.643")] //Bug: Doesn't work with Double values in String
        [TestCase("0", "0")]
        [TestCase("5", "2.236")]
        public void SqrtNUnitTestString(string num, string expectedResult)
        {
            double actualResult = testCalculator.Sqrt(num);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult, 0.0001);
        }


        [TestCase("-36")]//Bug: Throws the wrong exception
        [TestCase("test")]
        public void SqrtNUnitTestException(string input)
        {
            Assert.That(() => testCalculator.Sqrt(input),
                Throws.TypeOf<NotFiniteNumberException>());
        }


        [TearDown]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}