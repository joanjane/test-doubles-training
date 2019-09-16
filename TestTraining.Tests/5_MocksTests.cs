using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTraining.Tests.Mocks
{
    [TestClass]
    public class MocksTests
    {

        [TestMethod]
        public void TestDoublesMockExample()
        {
            var productId = 11111;
            var mockStockQuantity = 9;
            var mock = new CurrencyConverterMock();
            // Define mock expectatinons
            mock.MockStock(productId, mockStockQuantity);

            // use mock
            var sut = new DoublesMockExample(mock);
            var result = sut.FormatStock(productId);

            // verify mock expectations
            mock.Verify();

            // Assert logic
            Assert.AreEqual("Last units!", result);
        }
    }
}
