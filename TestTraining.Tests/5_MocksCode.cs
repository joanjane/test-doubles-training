using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTraining.Tests.Mocks
{
    public interface IStockQuery
    {
        int CountProductStock(int productId);
    }

    public class CurrencyConverterMock : IStockQuery
    {
        private Dictionary<int, int> _mocks = new Dictionary<int, int>();
        private List<int> _verifiedMocks = new List<int>();

        public int CountProductStock(int productId)
        {
            if (!_mocks.ContainsKey(productId))
            {
                throw new Exception($"Mock of product {productId} was not set");
            }
            _verifiedMocks.Add(productId);
            return _mocks[productId];
        }

        public void MockStock(int productId, int mockStockValue)
        {
            _mocks[productId] = mockStockValue;
        }

        public void Verify()
        {
            var anyMockPending = _mocks.Keys.Any(number =>
                !_verifiedMocks.Any(verifiedNumber => number == verifiedNumber));
            if (anyMockPending)
            {
                throw new Exception($"Some mocks were expected to be consumed");
            }
        }
    }

    public class DoublesMockExample
    {
        private readonly IStockQuery _stockQuery;
        public DoublesMockExample(IStockQuery stockQuery)
        {
            _stockQuery = stockQuery;
        }

        public string FormatStock(int productId)
        {
            var stock = _stockQuery.CountProductStock(productId);
            if (stock < 10) 
            {
                return "Last units!";
            }
            return $"There are {stock} units";
        }
    }
}
