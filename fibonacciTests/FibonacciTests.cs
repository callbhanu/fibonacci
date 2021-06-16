using Microsoft.VisualStudio.TestTools.UnitTesting;
using fibonacci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci.Tests
{
    [TestClass()]
    public class FibonacciTests
    {
        [TestMethod()]
        public void FibonacciWithPositiveNumber()
        {
            Fibonacci obj = new Fibonacci();
            string actual= obj.getFibonacciNumbers(5);
            string expected = "0 1 1 2 3";
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void FibonacciWithNegativeNumber()
        {
            Fibonacci obj = new Fibonacci();
            string actual = obj.getFibonacciNumbers(-5);
            string expected = string.Empty;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void FibonacciWithZeroAsInput()
        {
            Fibonacci obj = new Fibonacci();
            string actual = obj.getFibonacciNumbers(0);
            string expected = string.Empty;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void FibonacciWithOneAsInput()
        {
            Fibonacci obj = new Fibonacci();
            string actual = obj.getFibonacciNumbers(1);
            string expected = "0";
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void FibonacciWithLargeNumber()
        {
            Exception expectedExcetpion = null;
            try
            {
                Fibonacci obj = new Fibonacci();
                string actual = obj.getFibonacciNumbers(99999999);
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            // Assert
            Assert.IsNotNull(expectedExcetpion);

        }
    }
}