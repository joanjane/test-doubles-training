using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTraining.Tests
{
    [TestClass]
    public class StubsTests
    {

        [TestMethod]
        [DataRow("aa", "AA")]
        [DataRow("AA", "AA")]
        public void TestDoublesStubExample(string input, string expected)
        {
            var stub = new MyStub(input);
            var sut = new DoublesStubExample(stub);
            Assert.AreEqual(expected, sut.ToUpper());
        }
    }
}
