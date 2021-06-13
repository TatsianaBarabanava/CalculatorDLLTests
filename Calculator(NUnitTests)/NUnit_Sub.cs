using NUnit.Framework;
using System;

namespace Calculator_NUnitTests_
{
    [TestFixture]
    public class NUnit_Sub
    {
        private CSharpCalculator.Calculator testCalculator;

        [SetUp]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestCase(8, 7, 1)]
        [TestCase(-10, -7, -3)]
        [TestCase(-12, 7, -19)]
        [TestCase(0, 7, -7)]
        public void SubNUnitTestInt(int num1, int num2, int expectedResult)
        {
            double actualResult = testCalculator.Sub(num1, num2);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestCase(1.2, 2.3, -1.1)]
        [TestCase(-3.3, -2.5, -0.8)]
        [TestCase(-4.3, 2.5, -6.8)]
        public void SubNUnitTestDouble(double num1, double num2, double expectedResult)
        {
            double actualResult = testCalculator.Sub(num1, num2);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestCase("1.2", "2.3", "-1.1")]
        [TestCase("-3", "-2.5", "-0.5")]
        [TestCase("8", "7", "1")]
        public void SubNUnitTestString(string num1, string num2, string expectedResult)
        {
            double actualResult = testCalculator.Sub(num1, num2);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult, 0.1);
        }

        [Test]
        public void SinNUnitTestException()
        {
            string num1 = "test";
            string num2 = "test";
            Assert.That(() => testCalculator.Sub(num1, num2),
                Throws.TypeOf<NotFiniteNumberException>());
        }

        [TearDown]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}