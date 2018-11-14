using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTraining.Tests
{
    public interface IFooM
    {
        int Bar(int number);
    }

    public class MyMock : IFooM
    {
        private Dictionary<int, int> _mocks = new Dictionary<int, int>();
        private List<int> _verifiedMocks = new List<int>();

        public int Bar(int number)
        {
            if (!_mocks.ContainsKey(number))
            {
                throw new Exception($"Parameter Number '{number}' was not expected in mock");
            }
            _verifiedMocks.Add(number);
            return _mocks[number];
        }

        public void MockBar(int expectedNumberParameter, int mockValue)
        {
            _mocks[expectedNumberParameter] = mockValue;
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
        private readonly IFooM _foo;
        public DoublesMockExample(IFooM foo)
        {
            _foo = foo;
        }

        public string FooBar(int number)
        {
            return _foo.Bar(number).ToString();
        }
    }
}
