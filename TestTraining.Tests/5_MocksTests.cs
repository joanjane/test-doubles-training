using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTraining.Tests
{
    [TestClass]
    public class MocksTests
    {

        [TestMethod]
        public void TestDoublesMockExample()
        {
            var mock = new MyMock();
            // Define mock expectatinons
            mock.MockBar(expectedNumberParameter: 1, mockValue: 11);

            // use mock
            var sut = new DoublesMockExample(mock);
            var result = sut.FooBar(1);

            // verify mock expectations
            mock.Verify();

            // Assert logic
            Assert.AreEqual("11", result);
        }
    }
}
