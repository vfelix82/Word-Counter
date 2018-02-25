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
        public void Test_ReapeatCounter_Single_Word_True()
        {
            ReapeatCounter testReapeatCounter = new ReapeatCounter("I Love you", "Love");
            Assert.AreEqual(1, testReapeatCounter.FindDuplicates());
        }

        [TestMethod]
        public void Test_ReapeatCounter_Multiple_Words_True()
        {
            ReapeatCounter testReapeatCounter = new ReapeatCounter("I Love to Love", "Love");
            Assert.AreEqual(2, testReapeatCounter.FindDuplicates());
        }

        [TestMethod]
        public void Test_ReapeatCounter_Case_Sensitive_True()
        {
            ReapeatCounter testReapeatCounter = new ReapeatCounter("I Love to Love", "i");
            Assert.AreEqual(1, testReapeatCounter.FindDuplicates());
        }
     }
}
