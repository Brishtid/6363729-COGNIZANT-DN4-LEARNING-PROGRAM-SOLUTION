using NUnit.Framework;
using CalcLibrary;
using System;

namespace CalcLibraryNunit.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new SimpleCalculator();
        }

        [TearDown]
        public void TearDown()
        {
            calc = null;
        }

        [Test]
        public void Addition_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            double num1 = 5.0;
            double num2 = 3.0;
            double expectedResult = 8.0;

            double actualResult = calc.Addition(num1, num2);

            Assert.That(actualResult, Is.EqualTo(expectedResult), "The sum of positive numbers was incorrect.");
        }

        [TestCase(2.0, 3.0, 5.0)]
        [TestCase(10.0, 5.0, 15.0)]
        [TestCase(0.0, 0.0, 0.0)]
        [TestCase(-4.0, 4.0, 0.0)]
        [TestCase(-5.0, -7.0, -12.0)]
        public void Addition_ReturnsCorrectSum(double a, double b, double expected)
        {
            double result = calc.Addition(a, b);
            Assert.That(result, Is.EqualTo(expected), $"Addition({a}, {b}) should be {expected}");
        }
    }
}
