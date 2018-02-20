using System;
using System.Collections.Generic;
using System.Linq;
namespace WordCounter.Models
{
    // Class Object
    public class WordFrequency
    {
        private string _inputSentence;
        private string _inputWord;

        // Constructor
        public WordFrequency(string sentence, string word)
        {
            _inputSentence = sentence;
            _inputWord = word;
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
        public int FindFrequency()
        {
            int frequency = 0;
            string[] splitSentence = _inputSentence.Split();
            foreach (string word in splitSentence)
            {
                if (word == _inputWord)
                {
                    frequency += 1;
                }
            }
            return frequency;
        }
    }
}
