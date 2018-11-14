using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTraining.Tests
{
    [TestClass]
    public class ExampleTests
    {
        public TestSeeder _testSeeder;

        [TestInitialize]
        public void Initialize() 
        {
            _testSeeder = new TestSeeder();
            _testSeeder.Seed();
        }
        
        [TestCleanup]
        public void Cleanup() 
        {
            _testSeeder.Cleanup();
        }
        

        [TestMethod]
        [DataRow("aa", "AA")]
        [DataRow("AA", "AA")]
        public void TestStringUpperCase(string input, string expected)
        {
            Assert.AreEqual(expected, input.ToUpper());
        }
    }

    public class TestSeeder 
    {

        public void Seed()
        {
            // Seed logic
        }
        
        public void Cleanup()
        {
            // Clean up logic
        }
    }
}
