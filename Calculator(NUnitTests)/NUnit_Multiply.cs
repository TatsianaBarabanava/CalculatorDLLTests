using NUnit.Framework;

[assembly: LevelOfParallelism(2)]
namespace Calculator_NUnitTests_
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class NUnit_Multiply
    {
        private CSharpCalculator.Calculator testCalculator;

        [SetUp]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestCase(1.2, 2.3, 2.76)]
        [TestCase(2, 8, 16)]
        [TestCase(-3, -2.5, 7.5)]
        [TestCase(7, 0, 0)]
        [TestCase("10", "2", 20)]
        public void MultiplyNUnitTest(double num1, double num2, double expectedResult)
        {
            double actualResult = testCalculator.Multiply(num1, num2);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TearDown]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}