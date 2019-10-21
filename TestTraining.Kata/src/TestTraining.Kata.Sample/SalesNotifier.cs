using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestTraining.Kata.Sample
{
    /*
     * [Ejercicio] Testear el envío de email
     * - Cuando las ventas bajan de 10, se envia una alerta por email con subject "Bad sales"
     * - Cuando las ventas están por encima de 25, se envia una alerta por email con subject "Good sales"
     */
    public class SalesNotifier
    {
        private const string Sender = "test@test";
        private readonly IMailingService _mailingService;
        private readonly ISalesByCommerceProvider _salesByCommerceProvider;

        public SalesNotifier(IMailingService mailingService, ISalesByCommerceProvider salesByCommerceProvider)
        {
            _mailingService = mailingService;
            _salesByCommerceProvider = salesByCommerceProvider;
        }

        public async Task CheckSales(string commerceId)
        {
            var sales = _salesByCommerceProvider.GetSalesOfCommerce(commerceId);
            if (sales < 15)
            {
                await _mailingService.SendEmail(
                    Sender,
                    "Bad sales",
                    $"The current sales for commerce {commerceId} are {sales}");
            }
            else if (sales > 25)
            {
                await _mailingService.SendEmail(
                    Sender,
                    "Good sales",
                    $"The current sales for commerce {commerceId} are {sales}");
            }
        }
    }

    public interface ISalesByCommerceProvider
    {
        int GetSalesOfCommerce(string commerceId);
    }

    public interface IMailingService
    {
        Task SendEmail(string to, string subject, string body);
    }
}
