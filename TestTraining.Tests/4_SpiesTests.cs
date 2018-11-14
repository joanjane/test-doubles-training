using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTraining.Tests
{
    [TestClass]
    public class SpiesTests
    {

        [TestMethod]
        public void TestDoublesSpyExample()
        {
            var spy = new MySpy();
            var sut = new DoublesSpyExample(spy);
            sut.FooBar();
            // Assert that IFooSp.Bar() was called by DoublesSpyExample
            Assert.AreEqual(1, spy.BarCount);
        }
    }
}
