using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
            double result = SimpleMath.Add(num1, num2);
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(2, 6)]
        [DataRow(7, 9)]
        [DataRow(6, -4)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            double result = SimpleMath.Multiply(num1, num2);
        }

        [TestMethod]
        [DataRow(5, 0)]
        [DataRow(0, 500)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(num1, num2));
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(10, 5)]
        [DataRow(100, 4)]
        [DataRow(63, 7)]
        public void Divide_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            double result = SimpleMath.Divide(num1, num2);
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(10, 5)]
        [DataRow(4, 4)]
        [DataRow(1000000000000000000, 1)]
        public void Subtract_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            double result = SimpleMath.Subtract(num1, num2);
        }
    }
}