using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calc.Tests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void WhenPassed1And1_Returns2()
        {
            //Arrange 
            int num1 = 1;
            int num2 = 1;

            //Act
            int sum = Calc.Add(num1, num2);

            Assert.AreEqual(2, sum);
        }
    }
}
