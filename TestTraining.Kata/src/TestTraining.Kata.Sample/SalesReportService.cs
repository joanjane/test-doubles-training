using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestTraining.Kata.Sample
{
    public interface ISalesReportService
    {
        Task<Sales> GetLastHourSales();
    }

    public class Sales
    {
        public decimal SalesCount { get; set; }
    }

    public class SalesReportService : ISalesReportService
    {
        private readonly HttpClient _httpClient;

        public SalesReportService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Sales> GetLastHourSales()
        {
            var request = $"https://jjane.free.beeceptor.com/sales/{RandomResponse()}";
            var response = await _httpClient.GetAsync(request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Sales>(content);
        }

        private static int RandomResponse()
        {
            return new Random().Next(1, 6);
        }
    }
}
