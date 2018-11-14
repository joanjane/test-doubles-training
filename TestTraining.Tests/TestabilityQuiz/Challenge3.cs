
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTraining.Tests.TestabilityQuiz
{
    [TestClass]
    public class TestabilityQuiz3
    {

        // Challenge: What problems do you find on this test?
        [TestMethod]
        public void TestCalc()
        {
            var number = new Random().Next(1, 10);
            var isEven = number % 2 == 0;
            var sut = new EvenOddChecker();
            Assert.AreEqual(isEven, sut.IsEven(number));
        }
    }

    public class EvenOddChecker
    {
        public bool IsEven(int number) 
        {
            decimal a = (decimal)number / 2;
            int b = (int)number / 2;
            return a - b == 0;
        }
    }
}


