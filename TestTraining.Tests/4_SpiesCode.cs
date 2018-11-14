using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTraining.Tests
{
    public interface IFooSp
    {
        void Bar();
    }

    public class MySpy : IFooSp
    {
        public int BarCount { get; private set; }

        public void Bar()
        {
            BarCount++;
        }
    }

    public class DoublesSpyExample
    {
        private readonly IFooSp _foo;
        public DoublesSpyExample(IFooSp foo)
        {
            _foo = foo;
        }

        public void FooBar()
        {
            _foo.Bar();
        }
    }
}
