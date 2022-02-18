using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            double expectedSum = num1 + num2;
            double actualSum = SimpleMath.Add(num1, num2);
            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        [DataRow(3, 6)]
        [DataRow(20, 4)]
        [DataRow(2.2, 3.23)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
           double expectedProduct = num1 * num2;
           double actualProduct = SimpleMath.Multiply(num1, num2);  
           Assert.AreEqual(expectedProduct, actualProduct);
        }

        [TestMethod]
        [DataRow(2.2)]
        [DataRow(3.6)]
        [DataRow(4.5)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double testDoubles)
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(testDoubles, 0));
            
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(2, 1)]
        [DataRow(43.2, 38.7)]
        [DataRow(24, 1.5)]
        public void Divide_TwoNumbers_ReturnsDividend(double num1, double num2)
        {
            double expectedDividend = num1 / num2;
            double actualDividend = SimpleMath.Divide(num1, num2);
            Assert.AreEqual(expectedDividend, actualDividend);
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(4, 1)]
        [DataRow(6.5, 2)]
        [DataRow(8.88, 1.23)]
        public void Subtract_TwoNumbers_ReturnsDifference(double num1, double num2)
        {
            double expectedDifference = num1 - num2;
            double actualDifference = SimpleMath.Subtract(num1, num2);
            Assert.AreEqual(actualDifference, expectedDifference);
        }
    }
}