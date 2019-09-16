using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTraining.Tests.Stubs
{
    [TestClass]
    public class StubsTests
    {

        [TestMethod]
        public void TestDoublesStubExample()
        {
            var language = "fr";
            var stub = new LanguageProviderStub(language);
            var sut = new DoublesStubExample(stub);
            Assert.AreEqual("es", sut.GetSessionLanguage());
        }
    }
}
