using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTraining.Tests.Spies
{
    [TestClass]
    public class SpiesTests
    {

        [TestMethod]
        public void TestDoublesSpyExample()
        {
            var spy = new EmailSenderSpy();
            var sut = new DoublesSpyExample(spy);
            sut.SendWelcomeEmail("test@test.com");
            // Assert that EmailSenderSpy.SendEmail() 
            // was called by DoublesSpyExample
            Assert.AreEqual(1, spy.SentEmailCount);
        }
    }
}
