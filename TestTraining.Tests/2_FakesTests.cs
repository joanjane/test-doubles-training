using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTraining.Tests
{
    [TestClass]
    public class FakesTests
    {

        [TestMethod]
        [DataRow("aa", "AA")]
        [DataRow("AA", "AA")]
        public void TestDoublesFakeExample(string input, string expected)
        {
            var fake = new MyFakeRepository();
            var sut = new DoublesFakeExample(fake);

            sut.Initialize(input);
            Assert.AreEqual(expected, sut.ToUpper());
        }
    }
}
