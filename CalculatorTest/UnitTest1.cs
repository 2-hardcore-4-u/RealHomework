using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        public CalculatorLib.Calculator calculator = new CalculatorLib.Calculator();
        [TestMethod]
        public void DivisionTest()
        {
            double x = 10;
            double y = 3;
            double result = calculator.DivideVariables(x, y);
            Assert.AreEqual(result, x/y, 0.1);
        }
    }
}
