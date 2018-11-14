using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTraining.Tests
{
    public interface IFooD
    {
        void Bar();
    }

    public class MyDummy : IFooD
    {
        public void Bar() { }
    }

    public class DoublesDummyExample
    {
        private readonly IFooD _foo;
        public DoublesDummyExample(IFooD foo)
        {
            _foo = foo;
        }

        public string ToUpper(string input)
        {
            _foo.Bar();
            return input.ToUpper();
        }
    }
}
