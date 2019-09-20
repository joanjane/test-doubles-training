using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTraining.Kata.Sample;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestTraining.Kata.Tests
{
    [TestClass]
    public class EmojiSalesRendererTests
    {
        // Este test funciona a veces. Cómo podemos solucionarlo?
        [TestMethod]
        public async Task TestRenderLastHourSales()
        {
            var sut = new EmojiSalesRenderer(new SalesReportService(new HttpClient()));
            var result = await sut.RenderLastHourSales();
            
            Assert.AreEqual(":)", result);
        }
    }
}
