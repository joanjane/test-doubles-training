using System.Collections.Generic;
using System.Linq;

namespace TestTraining.Tests.Stubs
{
    public interface ILanguageProvider
    {
        string GetLanguage();
    }

    public class LanguageProviderStub : ILanguageProvider
    {
        private readonly string _language;
        public LanguageProviderStub(string language)
        {
            _language = language;
        }

        public string GetLanguage()
        {
            return _language;
        }
    }

    public class DoublesStubExample
    {
        private string DefaultLanguage = "es";
        private IEnumerable<string> SupportedLanguages = new List<string>() { "es", "en" };
        private readonly ILanguageProvider _languageProvider;
        public DoublesStubExample(ILanguageProvider languageProvider)
        {
            _languageProvider = languageProvider;
        }

        public string GetSessionLanguage()
        {
            var language = _languageProvider.GetLanguage();
            if (!SupportedLanguages.Any(l => l == language))
            {
                return DefaultLanguage;
            }
            return language;
        }
    }
}
