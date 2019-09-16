
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTraining.Tests.TestabilityQuiz
{
    // Challenge: Add 2 unit tests
    // 1. Mock number provider and validate that first number is returned
    // 2. Test that an exception is thrown when number provider returns null
    // Any problem?
    public class DailyWordClue
    {
        private static string _cachedWord;
        private readonly IDailyWordProvider _dailyWordProvider;
        public DailyWordClue(IDailyWordProvider dailyWordProvider)
        {
            _dailyWordProvider = dailyWordProvider;
        }

        public char GetFirstDailyWordLetter()
        {
            if (_cachedWord == null)
            {
                _cachedWord = _dailyWordProvider.GetDailyWord() ??
                    throw new Exception("Daily word must not be null");
            }

            return _cachedWord.First();
        }
    }

    public interface IDailyWordProvider
    {
        string GetDailyWord();
    }

    public class DailyWordProviderStub : IDailyWordProvider
    {
        public string Word { get; }
        public DailyWordProviderStub(string word)
        {
            Word = word;
        }

        public string GetDailyWord() 
        {
            return Word;
        }
    }

    [TestClass]
    public class NumberFooTests 
    {
        [TestMethod]
        public void TestFirst()
        {
            var numberFoo = new DailyWordClue(new DailyWordProviderStub("hello"));
            var firstLetter = numberFoo.GetFirstDailyWordLetter();
            Assert.AreEqual('h', firstLetter);
        }

        // [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestNull()
        {
            var dailyWordClue = new DailyWordClue(new DailyWordProviderStub(null));
            var firstLetter = dailyWordClue.GetFirstDailyWordLetter();
        }
    }
}


