using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTraining.Tests
{
    public interface IFooS
    {
        string Bar();
    }

    public class MyStub : IFooS
    {
        private readonly string _bar;
        public MyStub(string bar)
        {
            _bar = bar;
        }
        public string Bar()
        {
            return _bar;
        }
    }

    public class DoublesStubExample
    {
        private readonly IFooS _foo;
        public DoublesStubExample(IFooS foo)
        {
            _foo = foo;
        }

        public string ToUpper()
        {
            return _foo.Bar().ToUpper();
        }
    }
}
