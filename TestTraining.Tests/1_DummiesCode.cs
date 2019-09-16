namespace TestTraining.Tests.Dummies
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class DummyLogger : ILogger
    {
        public void Log(string message) { }
    }

    public class DoublesDummyExample
    {
        private readonly ILogger _logger;
        public DoublesDummyExample(ILogger foo)
        {
            _logger = foo;
        }

        public string ToUpper(string input)
        {
            _logger.Log($"Converting {input} to upper");
            return input.ToUpper();
        }
    }
}
