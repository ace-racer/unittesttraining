using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleDotNetExample;

namespace UnitTestingTraining.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddReturnsCorrectSumOfTwoArguments()
        {
            int a = 10, b = 15;
            Assert.AreEqual(a + b, Calculator.Add(a, b));
        }

        [TestMethod]        
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddReturnsExceptionWhenArgumentsTooLarge()
        {
            int a = 2147483647;
            int b = 1;
            int c = Calculator.Add(a, b);
            Assert.IsTrue(c > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddReturnsExceptionWhenArgumentsTooSmall()
        {
            int a = -2147483648;
            int b = -1;
            int c = Calculator.Add(a, b);
            Assert.IsTrue(c < 0);
        }
    }
}
