
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTraining.Tests.TestabilityQuiz
{
    // Challenge: Add 2 unit tests
    // 1. Mock number provider and validate that first number is returned
    // 2. Test that an exception is thrown when number provider returns null
    public class NumberFoo
    {
        private static List<int> _cachedNumbers;
        private readonly INumberProvider _numberProvider;
        public NumberFoo(INumberProvider numberProvider)
        {
            _numberProvider = numberProvider;
        }

        public int GetFirstNumber()
        {
            if (_cachedNumbers == null)
            {
                _cachedNumbers = _numberProvider.Get() ?? throw new Exception("Numbers were expected");
            }

            return _cachedNumbers.First();
        }
    }

    public interface INumberProvider
    {
        List<int> Get();
    }
}


