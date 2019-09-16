using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTraining.Tests.Fakes
{
    [TestClass]
    public class FakesTests
    {

        [TestMethod]
        public void TestDoublesFakeExample()
        {
            var fake = new MyFakeCache();
            var sut = new DoublesFakeExample(fake);
            var language = "es";
            sut.SetLanguage(language);
            Assert.AreEqual(language, sut.GetLanguage());
        }
    }
}
