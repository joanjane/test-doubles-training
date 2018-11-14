using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTraining.Tests
{
    public interface IFooRepository
    {
        string Get();
        void Set(string bar);
    }

    public class MyFakeRepository : IFooRepository
    {
        private string Bar { get; set; }

        public string Get()
        {
            return Bar;
        }

        public void Set(string bar)
        {
            Bar = bar;
        }
    }

    public class DoublesFakeExample
    {
        private readonly IFooRepository _foo;
        public DoublesFakeExample(IFooRepository foo)
        {
            _foo = foo;
        }

        public void Initialize(string value)
        {
            _foo.Set(value);
        }

        public string ToUpper()
        {
            return _foo.Get().ToUpper();
        }
    }
}
