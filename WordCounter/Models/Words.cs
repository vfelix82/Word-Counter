using System;
using System.Collections.Generic;
using System.Linq;
namespace WordCounter.Models
{
    // Class Object
    public class WordsCounter
    {
        private string _inputSentence;
        private string _inputWord;
        private int _wordCount = 0;

        // Constructor
        public WordsCounter()
        {
            _inputSentence = "";
            _inputWord = "";
        }

        public WordsCounter(string sentence, string word)
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
        public int GetWordCount()
        {

            return _wordCount;
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
    }
}
