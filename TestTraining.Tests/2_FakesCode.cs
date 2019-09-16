using System.Collections.Generic;

namespace TestTraining.Tests.Fakes
{
    public interface ICache
    {
        string Get(string key);
        void Set(string key, string value);
    }

    public class MyFakeCache : ICache
    {
        Dictionary<string, string> Entries { get; set; }

        public string Get(string key)
        {
            return Entries[key];
        }

        public void Set(string key, string value)
        {
            Entries[key] = value;
        }
    }

    public class DoublesFakeExample
    {
        private const string CacheKey = "language";
        private readonly ICache _cache;
        public DoublesFakeExample(ICache foo)
        {
            _cache = foo;
        }

        public string GetLanguage()
        {
            return _cache.Get(CacheKey);
        }

        public void SetLanguage(string value)
        {
            _cache.Set(CacheKey, value);
        }
    }
}
