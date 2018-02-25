using System;
using System.Collections.Generic;
using System.Linq;
namespace WordCounter.Models
{
    // Class Object
    public class ReapeatCounter
    {
        private string _inputSentence;
        private string _inputWord;

        // Constructor
        public ReapeatCounter(string sentence, string word)
        {
            _inputSentence = sentence.ToLower();
            _inputWord = word.ToLower();
        }

        // Getters
        public string GetSentence()
        {
            return _inputSentence;
        }
        public string GetWord()
        {
            return _inputWord;
        }

        // Setters
        public void SetSentence(string setSentence)
        {
            _inputSentence = setSentence;
        }
        public void SetWord(string setWord)
        {
            _inputWord = setWord;
        }

        // Find Frequency split
        public int FindDuplicates()
        {
            int duplicates = 0;
            string[] splitSentence = _inputSentence.Split();
            foreach (string word in splitSentence)
            {
                if (word == _inputWord)
                {
                    duplicates += 1;
                }
            }
            return duplicates;
        }
    }
}
