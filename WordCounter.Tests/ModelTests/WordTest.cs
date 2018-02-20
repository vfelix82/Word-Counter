using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
namespace WordCounter.Tests
{
    [TestClass]
    public class WordFrequencyTest
    {
        [TestMethod]
        public void Test_WordFrequency_True()
        {
            WordFrequency testFrequency = new WordFrequency;
            Assert.AreEqual(1, testFrequency.FindFrequency("Love Love Love"));
        }
     }
}
