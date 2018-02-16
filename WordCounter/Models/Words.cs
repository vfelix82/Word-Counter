using System;
using System.Collections.Generic;
using System.Linq;
namespace WordCounter.Models
{
    public class Words
    {
        private string _currentString;
        List<String> _listOfWords = new List<string>{};
        public Words(string inputString)
        {
            _currentString = inputString;
        }

        public string CharArrayToString(char[] inputArray)
        {
            string outPutString = "";
            for(int i = 0; i < inputArray.Length; i ++)
            {
                outPutString += inputArray[i];
            }
            return outPutString;
        }

        public string Results()
        {
            return returnListAsString();
        }
        public void GenerateWordFrequency();
        {

        }
    }

}
