using NUnit.Framework;
using System;

namespace Calculator_NUnitTests_
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class NUnit_Pow
    {
        private CSharpCalculator.Calculator testCalculator;

        [SetUp]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestCase(-6.5, 2, 42.25)] //Bug: Doesn't work with double
        public void PowNUnitTestDouble(double num, double pow, double expectedResult)
        {
            double actualResult = testCalculator.Pow(num, pow);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(-10, -2, 0)] //Bug: Doesn't work with int
        [TestCase(5, 3, 125)]
        public void PowNUnitTestInt(int num, int pow, int expectedResult)
        {
            double actualResult = testCalculator.Pow(num, pow);
            Assert.AreEqual(expectedResult, actualResult, 0.1);
        }

        [TestCase("2", "-2", 0.25)] //Bug: Doesn't work with string values
        [TestCase("5", "3", 125)]
        [TestCase("-6.5", "2", 42.25)]
        public void PowNUnitTestString(string num, string pow, double expectedResult)
        {
            double actualResult = testCalculator.Pow(num, pow);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestCase("test", "test")]
        public void PowNUnitTestException(string num, string pow)
        {

            Assert.That(() => testCalculator.Pow(num, pow),
                Throws.TypeOf<NotFiniteNumberException>());
        }

        [TearDown]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}