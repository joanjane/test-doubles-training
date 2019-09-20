using System.Threading.Tasks;

namespace TestTraining.Kata.Sample
{
    public class EmojiSalesRenderer
    {
        private readonly ISalesReportService _salesReportService;

        public EmojiSalesRenderer(ISalesReportService salesReportService)
        {
            _salesReportService = salesReportService;
        }

        public async Task<string> RenderLastHourSales()
        {
            var sales = await _salesReportService.GetLastHourSales();

            if (sales.SalesCount > 1000)
            {
                return @"XDDD";
            }
            else if (sales.SalesCount > 25)
            {
                return @":)";
            }
            else if (sales.SalesCount > 15)
            {
                return @":/";
            }
            else if (sales.SalesCount > 5)
            {
                return @":(";
            }

            return @":'(";
        }
    }
}
