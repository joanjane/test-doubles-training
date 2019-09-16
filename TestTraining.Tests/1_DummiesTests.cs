using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTraining.Tests.Dummies
{
    [TestClass]
    public class DummiesTests
    {

        [TestMethod]
        [DataRow("aa", "AA")]
        [DataRow("AA", "AA")]
        public void TestDoublesDummyExample(string input, string expected)
        {
            var dummy = new DummyLogger();
            var sut = new DoublesDummyExample(dummy);
            Assert.AreEqual(expected, sut.ToUpper(input));
        }
    }
}
