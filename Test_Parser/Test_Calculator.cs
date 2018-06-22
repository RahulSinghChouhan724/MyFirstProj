using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using personInfo;

namespace personInfo
{
    [TestClass]
    public class Test_Calculator
    {
        [TestMethod]
        public void theMethodShouldReturn10()
        {
            var calc = new Calculator();

            var result = calc.Multiply(2, 5);

            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void theMethodShouldAlsoReturn10()
        {
            var calc = new Calculator();

            var result = calc.Multiply(5, 2);

            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void theMethodShouldReturn100()
        {
            var calc = new Calculator();

            var result = calc.Multiply(2, 50);

            Assert.AreEqual(result, 100);
        }

        [TestMethod]
        public void theMethodShouldReturnNegetive20()
        {
            var calc = new Calculator();

            var result = calc.Multiply(2, -10);

            Assert.AreEqual(result, -20);
        }
    }
}
