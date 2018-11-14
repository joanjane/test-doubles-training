using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTraining.Tests
{
    [TestClass]
    public class DummiesTests
    {

        [TestMethod]
        [DataRow("aa", "AA")]
        [DataRow("AA", "AA")]
        public void TestDoublesDummyExample(string input, string expected)
        {
            var dummy = new MyDummy();
            var sut = new DoublesDummyExample(dummy);
            Assert.AreEqual(expected, sut.ToUpper(input));
        }
    }
}
